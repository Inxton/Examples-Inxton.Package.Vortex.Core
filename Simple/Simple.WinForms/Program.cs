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
        } = HansPlc.Entry.HansPlc;
    }
}
