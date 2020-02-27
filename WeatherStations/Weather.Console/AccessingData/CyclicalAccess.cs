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
    using HansPlc;

    /// <summary>
    /// This class writes and reads PLC data via 'cyclic' access.
    /// </summary>
    class CyclicAccess
    {
        /// <summary>
        /// Creates new instance of <see cref="CyclicAccess"/> class.
        /// </summary>
        /// <param name="hansPlc">Hans plc Twin Controller.</param>
        public CyclicAccess(HansPlc.HansPlcTwinController hansPlc)
        {
            this.Hans = hansPlc;
            this.Stations = this.Hans.prgWeatherStations._weatherStationsCyclicAccess;
        }
        
        /// <summary>
        /// Weather Stations container.
        /// </summary>
        readonly fbWorldWeatherWatch Stations;

        /// <summary>
        /// Hans PLC.
        /// </summary>
        readonly HansPlc.HansPlcTwinController Hans;
        
        private IEnumerable<object> GetWeatherStations()
        {
            // This retrieves all children of 'Hans.MAIN._weatherStations' object that are of type 'structWeatherNow'.
            return Stations.GetChildren().Where(p => p.GetType() == typeof(structWeatherStation));

            // It would be the same as
            // return new List<object>() { Hans.MAIN._weatherStations.NorthPole, Hans.MAIN._weatherStations.Verl, Hans.MAIN._weatherStations.Kriva, Hans.MAIN._weatherStations.SouthPole };
            
            // The advantage of the former approach is that when a station is added/removed in the PLC structure it will reflect the change automatically.
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

            // Alternatively you could update the stations explicitely. The advantage of previous approach is that when the number of stations changes the change will reflect automatically.

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
        internal void ReadWeatherStationsData(int iteration)
        {                               
            System.Console.WriteLine($"-------------------------------------------------------- {nameof(SynchronAccess)}.{nameof(ReadWeatherStationsData)}- Iteration: {iteration}--------------------------------------------------------");

            foreach (structWeatherStation station in this.GetWeatherStations())
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
           

            var output = $"{station.AttributeName} [{(enumStationStatus)station.StationStatus.Cyclic}][{station.StationICAO.Cyclic}]:" +
                         $"{station.DewPoint.AttributeName}: {station.DewPoint.Cyclic} [{station.DewPoint.AttributeUnits}] " +
                         $"{station.Temp.AttributeName}: {station.Temp.Cyclic} [{station.Temp.AttributeUnits}] " +
                         $"{station.Pressure.AttributeName}: {station.Pressure.Cyclic} [{station.Pressure.AttributeUnits}] " +
                         $"{station.Visibility.AttributeName}: {station.Visibility.Cyclic} [{station.Visibility.AttributeUnits}] " +
                         $"{station.WindSpeed.AttributeName}: {station.WindSpeed.Cyclic} [{station.WindSpeed.AttributeUnits}] " +
                         $"{station.WindHeading.AttributeName}: {station.WindHeading.Cyclic} [{station.WindHeading.AttributeUnits}]";

            System.Console.WriteLine(output);
        }

        /// <summary>
        /// Demonstrates cyclic write and cyclic read.
        /// </summary>
        public void DoIt()
        {

            Console.WriteLine("\n\n");
            WriteWeatherStationData();

            // Notice that when the data are read for the first time some of the items will have default value.
            // This is because some items are accessed cyclically for the first time. 
            // Once an item is accessed it is queued for cyclical reading from that moment on.
            // Cyclical reading is great for  UI scenarios as this kind of reading implements on value change notifications.
            // When the data are required immediately 'Synchron' or 'Batched' access is should be used.

            for (int i = 0; i < 2; i++)
            {
                System.Threading.Thread.Sleep(1500);
                ReadWeatherStationsData(i+1);
            }

            Console.WriteLine("\n\n");
        }
    }
}
