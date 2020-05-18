using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace PLC
{
	
            /// <summary>
            /// This is an external type. No documentation available.
            /// </summary>
            /// <exclude />
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("", "EPlcPersistentStatus", "PLC", TypeComplexityEnum.Enumerator)]
	public enum EPlcPersistentStatus : System.Byte
	{
		PS_None = 0,
		PS_All = 1,
		PS_Partial = 2
	}
}