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

        /// <summary>
        /// Ams id of target system.        
        /// </summary>
        const string AmsId = "172.20.10.102.1.1"; // null for local

        /// <summary>
        /// Ams port of HansPlc
        /// </summary>
        const int AmsPort = 851;

        public App()
        {
            Hans.Connector.BuildAndStart();

            SetCulture("en");
            // SetCulture("de");
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

        public static HansPlc.HansPlcTwinController Hans { get; } = new HansPlc.HansPlcTwinController(Vortex.Adapters.Connector.Tc3.Adapter.Tc3ConnectorAdapter.Create(AmsId, AmsPort, true));
    }
}
