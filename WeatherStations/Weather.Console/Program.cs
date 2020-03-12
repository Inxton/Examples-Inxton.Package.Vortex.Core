﻿namespace Weather.Console
{
    using System;
    using HansPlc;

    /// <summary>
    /// Demonstrates reading and writing of PLC data from weather stations around the world.
    /// Using 'Cyclic', 'Synchron' and 'Batched' access.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Gets the Twin Controller of 'HansPlc'.
        /// </summary>
        static HansPlcTwinController Hans
        {
            get;
        } = HansPlc.Entry.HansPlc;

        /// <summary>
        /// Main app entry.
        /// </summary>
        /// <param name="args">arguments</param>
        static void Main(string[] args)
        {
            // Kicks out operations for HansPlc
            Hans.Connector.BuildAndStart();

            // SetCulture("en"); // Default
            // SetCulture("de"); // Uncomment for German
            // SetCulture("fr"); // Uncomment for French
          

            // Reading modes
            new CyclicAccess(Hans).DoIt();
            new BatchAccess(Hans).DoIt();
            new SynchronAccess(Hans).DoIt();


            // Saving data to csv file
            var csvLogger = new CsvLogger(Hans.prgWeatherStations._weatherStationsCyclicAccess, 500);
           

            Console.WriteLine("Press any key to continue...");
            Console.Read();

            csvLogger.OpenInNotepad();
        }
        
        /// <summary>
        /// Sets app's culture.
        /// </summary>
        /// <param name="culture">Culture name.</param>
        private static void SetCulture(string culture)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(culture);
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture);
        }
    }
}
