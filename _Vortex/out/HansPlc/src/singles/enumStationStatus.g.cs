using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace HansPlc
{
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("", "enumStationStatus", "HansPlc", TypeComplexityEnum.Enumerator)]
	public enum enumStationStatus
	{
		Unknown = 0,
		Available = 1,
		UnAvailable = 2
	}
}