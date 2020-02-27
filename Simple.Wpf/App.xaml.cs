using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Simple.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Target system ams id.
        /// </summary>
        const string AmsId = "172.20.10.102.1.1"; // set to 'null' if local

        /// <summary>
        /// Port of the target system.
        /// </summary>
        const int Port = 851;

        /// <summary>
        /// Creates new instance of <see cref="App"/> class.
        /// </summary>
        public App()
        {
            // Starts operation on hans plc twin controller.
            Hans.Connector.BuildAndStart();
        }

        /// <summary>
        /// Gets TwinController of HansPlc.
        /// </summary>
        public static HansPlc.HansPlcTwinController Hans
        {
            get;
        } = new HansPlc.HansPlcTwinController(Vortex.Adapters.Connector.Tc3.Adapter.Tc3ConnectorAdapter.Create(AmsId, 851, true));
    }
}
