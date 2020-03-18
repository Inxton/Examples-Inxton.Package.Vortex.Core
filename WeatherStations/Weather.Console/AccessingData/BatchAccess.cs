namespace Weather.Console
{
    // This is the PLC structure that is written/read.
    /*
     TYPE structWeatherNow :
        STRUCT
            {attribute addProperty Name "<#Station name (ICAO)#>"}	
            StationICAO : STRING(4);
            {attribute addProperty Name "<#Station status#>"}
            StationStatus : enumStationStatus; 
            {attribute addProperty Name "<#Dew Point#>"}	// is rendered as 'AttributeName'
            {attribute addProperty Units "<#°C#>"}          // is rendered as 'AttributeUnits'
            DewPoint : REAL;                                // Value is in properties 'Cyclic', 'Synchron', 'LastValue'
            {attribute addProperty Name "<#Pressure#>"}
            {attribute addProperty Units "<#Torr#>"}	
            Pressure : REAL;
            {attribute addProperty Name "<#Temperature#>"}
            {attribute addProperty Units "<#°C#>"}
            Temp : REAL;
            {attribute addProperty Name "<#Visibility#>"}
            {attribute addProperty Units "<#km#>"}	
            Visibility : REAL;			
            {attribute addProperty Name "<#Wind heading#>"}
            {attribute addProperty Units "<#Azimuth#>"}	
            WindHeading : UINT;	
            {attribute addProperty Name "<#Wind speed#>"}
            {attribute addProperty Units "<#m/s#>"}	
            WindSpeed : REAL;
        END_STRUCT
    END_TYPE
    */

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using HansPlc;
    using Vortex.Connector;

    /// <summary>
    /// This class writes and reads PLC data via 'Batch' access.
    /// </summary>
    class BatchAccess
    {
        /// <summary>
        /// Creates new instance of <see cref="BatchAccess"/> class.
        /// </summary>
        /// <param name="hansPlc">Hans plc Twin Controller.</param>
        public BatchAccess(HansPlc.HansPlcTwinController hansPlc)
        {
            this.Hans = hansPlc;
            this.Stations = this.Hans.prgWeatherStations._weatherStationsBatchAccess;
        }

        readonly fbWorldWeatherWatch Stations;

        /// <summary>
        /// Hans PLC.
        /// </summary>
        readonly HansPlc.HansPlcTwinController Hans;


        private IEnumerable<object> GetWeatherStations()
        {
            // This retrieves all children of 'Hans.MAIN._weatherStations' object that are of type 'structWeatherNow'.
            return this.Stations.GetChildren().Where(p => p.GetType() == typeof(structWeatherStation));

            // It would be the same as
            // return new List<object>() { Hans.MAIN._weatherStations.NorthPole, Hans.MAIN._weatherStations.Verl, Hans.MAIN._weatherStations.Kriva, Hans.MAIN._weatherStations.SouthPole };
            
            // The advantage of the former approach is that when a station is added in the PLC structure it will reflect automatically.
        }


        /// <summary>
        /// Writes structure 'Main.WeatherStationsPlcSimulated' to 'Cyclic' property.
        /// </summary>
        internal void WriteWeatherStationData()
        {                                                 
            foreach (structWeatherStation station in GetWeatherStations())
            {
                UpdateStationData(station);                
            }

            // Alternatively you could update the stations explicitely. The advantage of previous approach is that when a 

            // UpdateStationData(Hans.MAIN._weatherStations.NorthPole);
            // UpdateStationData(Hans.MAIN._weatherStations.Verl);
            // UpdateStationData(Hans.MAIN._weatherStations.Kriva);
            // UpdateStationData(Hans.MAIN._weatherStations.SouthPole);

            // This writes all variables in a single shot.
            this.Stations.Write();
        }

        /// <summary>
        /// Updates station's data.
        /// </summary>
        /// <param name="station">Station to update.</param>
        internal void UpdateStationData(structWeatherStation station)
        {
            try
            {                
                // Reads Weather Data from the internet.

                var icao = OpenWeather.MetarStationLookup.Instance.Lookup(station.StationICAO.Synchron);
                                
                station.StationStatus.Cyclic = (short)enumStationStatus.Available;
                station.DewPoint.Cyclic = (float)icao.Weather.Dewpoint;
                station.Temp.Cyclic = (float)icao.Weather.Temperature;
                station.Pressure.Cyclic = (float)icao.Weather.Pressure;
                station.WindSpeed.Cyclic = (float)icao.Weather.WindSpeed;
                station.WindHeading.Cyclic = (ushort)icao.Weather.WindHeading;
                station.Visibility.Cyclic = (float)icao.Weather.Visibility;
            }
            catch (Exception ex)
            {
                // When online data not available we simulate the values.

                station.StationStatus.Cyclic = (short)enumStationStatus.Unknown;
                SimulateValues(station, new Random().Next());                
            }            
        }

        /// <summary>
        /// Simulates values when no online data are available.
        /// </summary>
        /// <param name="station">Station to update.</param>
        /// <param name="x">Randomizer.</param>
        private void SimulateValues(structWeatherStation station, float x)
        {            
            station.StationStatus.Cyclic = (short)enumStationStatus.Unknown;
            station.DewPoint.Cyclic = 30.0f * x;
            station.Temp.Cyclic = -50.0f * x;
            station.Pressure.Cyclic = 800.0f * x;
            station.WindSpeed.Cyclic = 50.0f * x;
            station.WindHeading.Cyclic = (ushort)(360f * x);
            station.Visibility.Cyclic = 15.0f * x;
        }

        /// <summary>
        /// Reads structure 'Main.WeatherStationsPlcSimulated' from 'Cyclic' property and outputs data to console.
        /// </summary>
        internal void ReadWeatherStationsData()
        {                               
            System.Console.WriteLine($"-------------------------------------------------------- {nameof(BatchAccess)}.{nameof(ReadWeatherStationsData)}--------------------------------------------------------");

            this.Stations.Read();

            foreach (structWeatherStation station in this.Stations.GetChildren().Where(p => p.GetType() == typeof(structWeatherStation)))
            {
                PrintOutStationData(station);
            }           
        }

        /// <summary>
        /// Outputs data read from the PLC to the console.
        /// </summary>
        /// <param name="station">Station to output data.</param>
        private void PrintOutStationData(structWeatherStation station)
        {           
            // Notice that we use property 'LastValue' to read the value of the PLC variable. 'LastValue' is the last value read from the 
            // controller using Batched reading. When you access 'LastValue' system does not adds this variable to the cyclic reading queue.

            var output = $"{station.AttributeName} [{(enumStationStatus)station.StationStatus.LastValue}][{station.StationICAO.LastValue}]:" +
                         $"{station.DewPoint.AttributeName}: {station.DewPoint.LastValue} [{station.DewPoint.AttributeUnits}] " +
                         $"{station.Temp.AttributeName}: {station.Temp.LastValue} [{station.Temp.AttributeUnits}] " +
                         $"{station.Pressure.AttributeName}: {station.Pressure.LastValue} [{station.Pressure.AttributeUnits}] " +
                         $"{station.Visibility.AttributeName}: {station.Visibility.LastValue} [{station.Visibility.AttributeUnits}] " +
                         $"{station.WindSpeed.AttributeName}: {station.WindSpeed.LastValue} [{station.WindSpeed.AttributeUnits}] " +
                         $"{station.WindHeading.AttributeName}: {station.WindHeading.LastValue} [{station.WindHeading.AttributeUnits}]";

            System.Console.WriteLine(output);
        }

        /// <summary>
        /// Demonstrates 'Batch' write and cyclic read.
        /// </summary>
        public void DoIt()
        {
            Console.WriteLine("\n\n");
            WriteWeatherStationData();
            ReadWeatherStationsData();
            Console.WriteLine("\n\n");
        }
    }
}
