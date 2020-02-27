using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple.WinForms
{
    static class Program
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
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Hans.Connector.BuildAndStart();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SimpleWinForm());
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
