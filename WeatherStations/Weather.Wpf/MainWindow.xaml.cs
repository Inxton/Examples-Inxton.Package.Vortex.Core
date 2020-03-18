using HansPlc;
using OpenWeatherMap.Standard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace Weather.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Current currentWeather = new Current("b798849c1f92d2694d041bc44212b40e");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WriteWeatherStationData();
        }

        HansPlc.fbWorldWeatherWatch Stations = App.Hans.prgWeatherStations._weatherStationsCyclicAccess;

        /// <summary>
        /// Writes structure 'Main.WeatherStationsPlcSimulated' to 'Cyclic' property.
        /// </summary>
        internal void WriteWeatherStationData()
        {
            foreach (structWeatherStation station in GetWeatherStations())
            {
                UpdateStationData(station);
            }           
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

        private IEnumerable<object> GetWeatherStations()
        {        
            return Stations.GetChildren().Where(p => p.GetType() == typeof(structWeatherStation));        
        }
    }
}
