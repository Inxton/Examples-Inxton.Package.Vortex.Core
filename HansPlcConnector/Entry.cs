#define REMOTE

using HansPlc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vortex.Adapters.Connector.Tc3.Adapter;

namespace HansPlc
{
    public static class Entry
    {
#if REMOTE
        /// <summary>
        /// Target system ams id.
        /// </summary>
        const string AmsId = "172.20.10.102.1.1"; // set to 'null' if local

        /// <summary>
        /// Port of the target system.
        /// </summary>
        const int Port = 851;
#else
        /// <summary>
        /// Target system ams id. (local)
        /// </summary>
        const string AmsId = null

        /// <summary>
        /// Port of the target system.
        /// </summary>
        const int Port = 851;

#endif

        public static HansPlcTwinController HansPlc { get; } = new HansPlcTwinController(Tc3ConnectorAdapter.Create(AmsId, Port));

    }
}
