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
    /// This class writes and reads PLC data via 'Synchron' access.
    /// </summary>
    class SynchronAccess
    {
        /// <summary>
        /// Creates new instance of <see cref="SynchronAccess"/> class.
        /// </summary>
        /// <param name="hansPlc">Hans plc Twin Controller.</param>
        public SynchronAccess(HansPlc.HansPlcTwinController hansPlc)
        {
            this.Hans = hansPlc;
            this.Stations = this.Hans.prgWeatherStations._weatherStationsSynchronAccess;
        }
        
        readonly fbWorldWeatherWatch Stations;

        /// <summary>
        /// Hans PLC.
        /// </summary>
        readonly HansPlc.HansPlcTwinController Hans;
        
        private IEnumerable<object> GetWeatherStations()
        {
            // This retrieves all children of 'Hans.MAIN._weatherStations' object that are of type 'structWeatherNow'.
            return Stations.GetChildren().Where(p => p is structWeatherStation);

            // It would be the same as
            // return new List<object>() { Hans.MAIN._weatherStations.NorthPole, Hans.MAIN._weatherStations.Verl, Hans.MAIN._weatherStations.Kriva, Hans.MAIN._weatherStations.SouthPole };
            
            // The advantage of the former approach is that when a station is added in the PLC structure it will reflect automatically.
        }


        /// <summary>
        /// Writes structure 'Main.WeatherStationsPlcSimulated' to 'Synchron' property.
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
                                
                station.StationStatus.Synchron = (short)enumStationStatus.Available;
                station.DewPoint.Synchron = (float)icao.Weather.Dewpoint;
                station.Temp.Synchron = (float)icao.Weather.Temperature;
                station.Pressure.Synchron = (float)icao.Weather.Pressure;
                station.WindSpeed.Synchron = (float)icao.Weather.WindSpeed;
                station.WindHeading.Synchron = (ushort)icao.Weather.WindHeading;
                station.Visibility.Synchron = (float)icao.Weather.Visibility;
            }
            catch (Exception ex)
            {
                // When online data not available we simulate the values.

                station.StationStatus.Synchron = (short)enumStationStatus.Unknown;
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
            station.StationStatus.Synchron = (short)enumStationStatus.Unknown;
            station.DewPoint.Synchron = 30.0f * x;
            station.Temp.Synchron = -50.0f * x;
            station.Pressure.Synchron = 800.0f * x;
            station.WindSpeed.Synchron = 50.0f * x;
            station.WindHeading.Synchron = (ushort)(360f * x);
            station.Visibility.Synchron = 15.0f * x;
        }

        /// <summary>
        /// Reads structure 'Main.WeatherStationsPlcSimulated' from 'Synchron' property and outputs data to console.
        /// </summary>
        internal void ReadWeatherStationsData()
        {                               
            System.Console.WriteLine($"-------------------------------------------------------- {nameof(SynchronAccess)}.{nameof(ReadWeatherStationsData)}---------------------------------------------------------");

            foreach (structWeatherStation station in Stations.GetChildren().Where(p => p.GetType() == typeof(structWeatherStation)))
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
           

            var output = $"{station.AttributeName} [{(enumStationStatus)station.StationStatus.Synchron}][{station.StationICAO.Synchron}]:" +
                         $"{station.DewPoint.AttributeName}: {station.DewPoint.Synchron} [{station.DewPoint.AttributeUnits}] " +
                         $"{station.Temp.AttributeName}: {station.Temp.Synchron} [{station.Temp.AttributeUnits}] " +
                         $"{station.Pressure.AttributeName}: {station.Pressure.Synchron} [{station.Pressure.AttributeUnits}] " +
                         $"{station.Visibility.AttributeName}: {station.Visibility.Synchron} [{station.Visibility.AttributeUnits}] " +
                         $"{station.WindSpeed.AttributeName}: {station.WindSpeed.Synchron} [{station.WindSpeed.AttributeUnits}] " +
                         $"{station.WindHeading.AttributeName}: {station.WindHeading.Synchron} [{station.WindHeading.AttributeUnits}]";

            System.Console.WriteLine(output);
        }

        /// <summary>
        /// Demonstrates Synchron write and Synchron read.
        /// </summary>
        public void DoIt()
        {
            Console.WriteLine("\n\n");
            WriteWeatherStationData();
            ReadWeatherStationsData();           
        }
    }
}
