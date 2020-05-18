namespace Weather.Console
{
    using CsvHelper;
    using HansPlc;
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Timers;

    /// <summary>
    /// Demonstrates data logging into CSV file, via Plainer object (POCO like).
    /// </summary>
    class CsvLogger
    {
        readonly Timer _timer;
        readonly string outputFile = Path.Combine(Environment.CurrentDirectory, "weather_log.csv");
        readonly fbWorldWeatherWatch _watcher;

        /// <summary>
        /// Creates new instance of <see cref="CsvLogger"/>
        /// </summary>
        /// <param name="interval">Logging period in milliseconds.</param>
        public CsvLogger(fbWorldWeatherWatch watcher, double interval)
        {
            _watcher = watcher;
            _timer = new Timer() { Enabled = false, Interval = interval };
            _timer.Elapsed += _timer_Elapsed;
            PeriodicLogging(false);
            _timer.Enabled = true;
        }

        /// <summary>
        /// Method fires on timer elapsed.
        /// </summary>
        /// <param name="sender">Sender object</param>
        /// <param name="e">Args</param>
        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            PeriodicLogging(true);
        }
       
        /// <summary>
        /// Creates record from weather stations.
        /// </summary>
        /// <param name="append">When 'true' record are added, when 'false' new file is created.</param>
        private void PeriodicLogging(bool append)
        {                                   
            using (var writer = new StreamWriter(outputFile, append))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.Configuration.HasHeaderRecord = !append;
                csv.WriteRecords(_watcher.GetStationsPOCO());
            }
        }

        /// <summary>
        /// Opens file in Notepad.
        /// </summary>
        public void OpenInNotepad()
        {
            try
            {
                System.Diagnostics.Process.Start("notepad.exe", outputFile);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
            }
            
        }
    }
}
