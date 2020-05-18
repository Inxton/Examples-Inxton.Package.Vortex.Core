using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace HansPlc
{
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "prgWeatherStations", "HansPlc", TypeComplexityEnum.Complex)]
	public partial class prgWeatherStations : Vortex.Connector.IVortexObject, IprgWeatherStations, IShadowprgWeatherStations, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
	{
		public string Symbol
		{
			get;
			protected set;
		}

		public string HumanReadable
		{
			get
			{
				return HansPlcTwinController.Translator.Translate(_humanReadable).Interpolate(this);
			}

			protected set
			{
				_humanReadable = value;
			}
		}

		protected string _humanReadable;
		fbWorldWeatherWatch __weatherStationsCyclicAccess;
		[Container(Layout.Wrap)]
		public fbWorldWeatherWatch _weatherStationsCyclicAccess
		{
			get
			{
				return __weatherStationsCyclicAccess;
			}
		}

		[Container(Layout.Wrap)]
		IfbWorldWeatherWatch IprgWeatherStations._weatherStationsCyclicAccess
		{
			get
			{
				return _weatherStationsCyclicAccess;
			}
		}

		[Container(Layout.Wrap)]
		IShadowfbWorldWeatherWatch IShadowprgWeatherStations._weatherStationsCyclicAccess
		{
			get
			{
				return _weatherStationsCyclicAccess;
			}
		}

		fbWorldWeatherWatch __weatherStationsBatchAccess;
		public fbWorldWeatherWatch _weatherStationsBatchAccess
		{
			get
			{
				return __weatherStationsBatchAccess;
			}
		}

		IfbWorldWeatherWatch IprgWeatherStations._weatherStationsBatchAccess
		{
			get
			{
				return _weatherStationsBatchAccess;
			}
		}

		IShadowfbWorldWeatherWatch IShadowprgWeatherStations._weatherStationsBatchAccess
		{
			get
			{
				return _weatherStationsBatchAccess;
			}
		}

		fbWorldWeatherWatch __weatherStationsSynchronAccess;
		public fbWorldWeatherWatch _weatherStationsSynchronAccess
		{
			get
			{
				return __weatherStationsSynchronAccess;
			}
		}

		IfbWorldWeatherWatch IprgWeatherStations._weatherStationsSynchronAccess
		{
			get
			{
				return _weatherStationsSynchronAccess;
			}
		}

		IShadowfbWorldWeatherWatch IShadowprgWeatherStations._weatherStationsSynchronAccess
		{
			get
			{
				return _weatherStationsSynchronAccess;
			}
		}

		public void LazyOnlineToShadow()
		{
			_weatherStationsCyclicAccess.LazyOnlineToShadow();
			_weatherStationsBatchAccess.LazyOnlineToShadow();
			_weatherStationsSynchronAccess.LazyOnlineToShadow();
		}

		public void LazyShadowToOnline()
		{
			_weatherStationsCyclicAccess.LazyShadowToOnline();
			_weatherStationsBatchAccess.LazyShadowToOnline();
			_weatherStationsSynchronAccess.LazyShadowToOnline();
		}

		public PlainprgWeatherStations CreatePlainerType()
		{
			var cloned = new PlainprgWeatherStations();
			cloned._weatherStationsCyclicAccess = _weatherStationsCyclicAccess.CreatePlainerType();
			cloned._weatherStationsBatchAccess = _weatherStationsBatchAccess.CreatePlainerType();
			cloned._weatherStationsSynchronAccess = _weatherStationsSynchronAccess.CreatePlainerType();
			return cloned;
		}

		protected PlainprgWeatherStations CreatePlainerType(PlainprgWeatherStations cloned)
		{
			cloned._weatherStationsCyclicAccess = _weatherStationsCyclicAccess.CreatePlainerType();
			cloned._weatherStationsBatchAccess = _weatherStationsBatchAccess.CreatePlainerType();
			cloned._weatherStationsSynchronAccess = _weatherStationsSynchronAccess.CreatePlainerType();
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
		partial void PexConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexConstructorParameterless();
		protected Vortex.Connector.IVortexObject @Parent
		{
			get;
			set;
		}

		public Vortex.Connector.IVortexObject GetParent()
		{
			return this.@Parent;
		}

		private System.Collections.Generic.List<Vortex.Connector.IVortexObject> @Children
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IVortexObject> @GetChildren()
		{
			return this.@Children;
		}

		public void AddChild(Vortex.Connector.IVortexObject vortexObject)
		{
			this.@Children.Add(vortexObject);
		}

		private System.Collections.Generic.List<Vortex.Connector.IValueTag> @ValueTags
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IValueTag> GetValueTags()
		{
			return this.@ValueTags;
		}

		public void AddValueTag(Vortex.Connector.IValueTag valueTag)
		{
			this.@ValueTags.Add(valueTag);
		}

		protected Vortex.Connector.IConnector @Connector
		{
			get;
			set;
		}

		public Vortex.Connector.IConnector GetConnector()
		{
			return this.@Connector;
		}

		public void FlushPlainToOnline(HansPlc.PlainprgWeatherStations source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(HansPlc.PlainprgWeatherStations source)
		{
			source.CopyPlainToShadow(this);
		}

		public void FlushShadowToOnline()
		{
			this.LazyShadowToOnline();
			this.Write();
		}

		public void FlushOnlineToShadow()
		{
			this.Read();
			this.LazyOnlineToShadow();
		}

		public void FlushOnlineToPlain(HansPlc.PlainprgWeatherStations source)
		{
			this.Read();
			source.CopyCyclicToPlain(this);
		}

		protected System.String @SymbolTail
		{
			get;
			set;
		}

		public System.String GetSymbolTail()
		{
			return this.SymbolTail;
		}

		public System.String AttributeName
		{
			get
			{
				return HansPlcTwinController.Translator.Translate(_AttributeName).Interpolate(this);
			}

			set
			{
				_AttributeName = value;
			}
		}

		private System.String _AttributeName
		{
			get;
			set;
		}

		public prgWeatherStations(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			__weatherStationsCyclicAccess = new fbWorldWeatherWatch(this, "", "_weatherStationsCyclicAccess");
			__weatherStationsBatchAccess = new fbWorldWeatherWatch(this, "", "_weatherStationsBatchAccess");
			__weatherStationsSynchronAccess = new fbWorldWeatherWatch(this, "", "_weatherStationsSynchronAccess");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public prgWeatherStations()
		{
			PexPreConstructorParameterless();
			__weatherStationsCyclicAccess = new fbWorldWeatherWatch();
			__weatherStationsBatchAccess = new fbWorldWeatherWatch();
			__weatherStationsSynchronAccess = new fbWorldWeatherWatch();
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcprgWeatherStations
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcprgWeatherStations()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IprgWeatherStations : Vortex.Connector.IVortexOnlineObject
	{
		[Container(Layout.Wrap)]
		IfbWorldWeatherWatch _weatherStationsCyclicAccess
		{
			get;
		}

		IfbWorldWeatherWatch _weatherStationsBatchAccess
		{
			get;
		}

		IfbWorldWeatherWatch _weatherStationsSynchronAccess
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		HansPlc.PlainprgWeatherStations CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(HansPlc.PlainprgWeatherStations source);
		void FlushOnlineToPlain(HansPlc.PlainprgWeatherStations source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowprgWeatherStations : Vortex.Connector.IVortexShadowObject
	{
		[Container(Layout.Wrap)]
		IShadowfbWorldWeatherWatch _weatherStationsCyclicAccess
		{
			get;
		}

		IShadowfbWorldWeatherWatch _weatherStationsBatchAccess
		{
			get;
		}

		IShadowfbWorldWeatherWatch _weatherStationsSynchronAccess
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		HansPlc.PlainprgWeatherStations CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(HansPlc.PlainprgWeatherStations source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainprgWeatherStations : Vortex.Connector.IPlain
	{
		PlainfbWorldWeatherWatch __weatherStationsCyclicAccess;
		[Container(Layout.Wrap)]
		public PlainfbWorldWeatherWatch _weatherStationsCyclicAccess
		{
			get
			{
				return __weatherStationsCyclicAccess;
			}

			set
			{
				__weatherStationsCyclicAccess = value;
			}
		}

		PlainfbWorldWeatherWatch __weatherStationsBatchAccess;
		public PlainfbWorldWeatherWatch _weatherStationsBatchAccess
		{
			get
			{
				return __weatherStationsBatchAccess;
			}

			set
			{
				__weatherStationsBatchAccess = value;
			}
		}

		PlainfbWorldWeatherWatch __weatherStationsSynchronAccess;
		public PlainfbWorldWeatherWatch _weatherStationsSynchronAccess
		{
			get
			{
				return __weatherStationsSynchronAccess;
			}

			set
			{
				__weatherStationsSynchronAccess = value;
			}
		}

		public void CopyPlainToCyclic(HansPlc.prgWeatherStations target)
		{
			_weatherStationsCyclicAccess.CopyPlainToCyclic(target._weatherStationsCyclicAccess);
			_weatherStationsBatchAccess.CopyPlainToCyclic(target._weatherStationsBatchAccess);
			_weatherStationsSynchronAccess.CopyPlainToCyclic(target._weatherStationsSynchronAccess);
		}

		public void CopyPlainToCyclic(HansPlc.IprgWeatherStations target)
		{
			this.CopyPlainToCyclic((HansPlc.prgWeatherStations)target);
		}

		public void CopyPlainToShadow(HansPlc.prgWeatherStations target)
		{
			_weatherStationsCyclicAccess.CopyPlainToShadow(target._weatherStationsCyclicAccess);
			_weatherStationsBatchAccess.CopyPlainToShadow(target._weatherStationsBatchAccess);
			_weatherStationsSynchronAccess.CopyPlainToShadow(target._weatherStationsSynchronAccess);
		}

		public void CopyPlainToShadow(HansPlc.IShadowprgWeatherStations target)
		{
			this.CopyPlainToShadow((HansPlc.prgWeatherStations)target);
		}

		public void CopyCyclicToPlain(HansPlc.prgWeatherStations source)
		{
			_weatherStationsCyclicAccess.CopyCyclicToPlain(source._weatherStationsCyclicAccess);
			_weatherStationsBatchAccess.CopyCyclicToPlain(source._weatherStationsBatchAccess);
			_weatherStationsSynchronAccess.CopyCyclicToPlain(source._weatherStationsSynchronAccess);
		}

		public void CopyCyclicToPlain(HansPlc.IprgWeatherStations source)
		{
			this.CopyCyclicToPlain((HansPlc.prgWeatherStations)source);
		}

		public void CopyShadowToPlain(HansPlc.prgWeatherStations source)
		{
			_weatherStationsCyclicAccess.CopyShadowToPlain(source._weatherStationsCyclicAccess);
			_weatherStationsBatchAccess.CopyShadowToPlain(source._weatherStationsBatchAccess);
			_weatherStationsSynchronAccess.CopyShadowToPlain(source._weatherStationsSynchronAccess);
		}

		public void CopyShadowToPlain(HansPlc.IShadowprgWeatherStations source)
		{
			this.CopyShadowToPlain((HansPlc.prgWeatherStations)source);
		}

		public PlainprgWeatherStations()
		{
			__weatherStationsCyclicAccess = new PlainfbWorldWeatherWatch();
			__weatherStationsBatchAccess = new PlainfbWorldWeatherWatch();
			__weatherStationsSynchronAccess = new PlainfbWorldWeatherWatch();
		}
	}
}