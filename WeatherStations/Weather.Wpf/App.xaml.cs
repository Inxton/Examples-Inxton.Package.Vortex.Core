using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Weather.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {               
        public App()
        {
            Hans.Connector.BuildAndStart();

            // Uncomment/Comment to change language of the application

            // SetCulture("en"); // Default
            // SetCulture("de"); // Uncomment for German
            // SetCulture("fr"); // Uncomment for French
            // SetCulture("ru"); // Uncomment for Russian
            // SetCulture("ja"); // Uncomment for Japanese
            // SetCulture("he"); //  for Hebrew
             SetCulture("ar"); // Uncomment for Arabic
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

        public static HansPlc.HansPlcTwinController Hans { get; } = HansPlc.Entry.HansPlc;
    }
}
