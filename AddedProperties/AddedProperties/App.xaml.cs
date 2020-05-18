using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace AddedProperties.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
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
        } = HansPlc.Entry.HansPlc;
    }
}
