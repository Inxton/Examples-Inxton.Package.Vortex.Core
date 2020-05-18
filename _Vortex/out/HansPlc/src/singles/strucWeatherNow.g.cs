using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace HansPlc
{
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "strucWeatherNow", "HansPlc", TypeComplexityEnum.Complex)]
	public partial class strucWeatherNow : Vortex.Connector.IVortexObject, IstrucWeatherNow, IShadowstrucWeatherNow, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerReal _Temp;
		public Vortex.Connector.ValueTypes.OnlinerReal Temp
		{
			get
			{
				return _Temp;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstrucWeatherNow.Temp
		{
			get
			{
				return Temp;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstrucWeatherNow.Temp
		{
			get
			{
				return Temp;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal _Hum;
		public Vortex.Connector.ValueTypes.OnlinerReal Hum
		{
			get
			{
				return _Hum;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstrucWeatherNow.Hum
		{
			get
			{
				return Hum;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstrucWeatherNow.Hum
		{
			get
			{
				return Hum;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal _UV;
		public Vortex.Connector.ValueTypes.OnlinerReal UV
		{
			get
			{
				return _UV;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstrucWeatherNow.UV
		{
			get
			{
				return UV;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstrucWeatherNow.UV
		{
			get
			{
				return UV;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal _Wind;
		public Vortex.Connector.ValueTypes.OnlinerReal Wind
		{
			get
			{
				return _Wind;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstrucWeatherNow.Wind
		{
			get
			{
				return Wind;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstrucWeatherNow.Wind
		{
			get
			{
				return Wind;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUInt _WindDir;
		public Vortex.Connector.ValueTypes.OnlinerUInt WindDir
		{
			get
			{
				return _WindDir;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt IstrucWeatherNow.WindDir
		{
			get
			{
				return WindDir;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowstrucWeatherNow.WindDir
		{
			get
			{
				return WindDir;
			}
		}

		public void LazyOnlineToShadow()
		{
			Temp.Shadow = Temp.LastValue;
			Hum.Shadow = Hum.LastValue;
			UV.Shadow = UV.LastValue;
			Wind.Shadow = Wind.LastValue;
			WindDir.Shadow = WindDir.LastValue;
		}

		public void LazyShadowToOnline()
		{
			Temp.Cyclic = Temp.Shadow;
			Hum.Cyclic = Hum.Shadow;
			UV.Cyclic = UV.Shadow;
			Wind.Cyclic = Wind.Shadow;
			WindDir.Cyclic = WindDir.Shadow;
		}

		public PlainstrucWeatherNow CreatePlainerType()
		{
			var cloned = new PlainstrucWeatherNow();
			return cloned;
		}

		protected PlainstrucWeatherNow CreatePlainerType(PlainstrucWeatherNow cloned)
		{
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

		public void FlushPlainToOnline(HansPlc.PlainstrucWeatherNow source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(HansPlc.PlainstrucWeatherNow source)
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

		public void FlushOnlineToPlain(HansPlc.PlainstrucWeatherNow source)
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

		public strucWeatherNow(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_Temp = @Connector.Online.Adapter.CreateREAL(this, "<#Temparature#>", "Temp");
			Temp.AttributeName = "<#Temparature#>";
			Temp.AttributeUnits = "C";
			_Hum = @Connector.Online.Adapter.CreateREAL(this, "<#Humidity#>", "Hum");
			Hum.AttributeName = "<#Humidity#>";
			Hum.AttributeUnits = "%";
			_UV = @Connector.Online.Adapter.CreateREAL(this, "<#Ultra Violet level#>", "UV");
			UV.AttributeName = "<#Ultra Violet level#>";
			UV.AttributeUnits = "0-10";
			_Wind = @Connector.Online.Adapter.CreateREAL(this, "<#Wind speed#>", "Wind");
			Wind.AttributeName = "<#Wind speed#>";
			Wind.AttributeUnits = "m/s";
			_WindDir = @Connector.Online.Adapter.CreateUINT(this, "<#Wind direction#>", "WindDir");
			WindDir.AttributeName = "<#Wind direction#>";
			WindDir.AttributeUnits = "Azimuth °";
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public strucWeatherNow()
		{
			PexPreConstructorParameterless();
			_Temp = Vortex.Connector.IConnectorFactory.CreateREAL();
			Temp.AttributeName = "<#Temparature#>";
			Temp.AttributeUnits = "C";
			_Hum = Vortex.Connector.IConnectorFactory.CreateREAL();
			Hum.AttributeName = "<#Humidity#>";
			Hum.AttributeUnits = "%";
			_UV = Vortex.Connector.IConnectorFactory.CreateREAL();
			UV.AttributeName = "<#Ultra Violet level#>";
			UV.AttributeUnits = "0-10";
			_Wind = Vortex.Connector.IConnectorFactory.CreateREAL();
			Wind.AttributeName = "<#Wind speed#>";
			Wind.AttributeUnits = "m/s";
			_WindDir = Vortex.Connector.IConnectorFactory.CreateUINT();
			WindDir.AttributeName = "<#Wind direction#>";
			WindDir.AttributeUnits = "Azimuth °";
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcstrucWeatherNow
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcstrucWeatherNow()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IstrucWeatherNow : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineReal Temp
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal Hum
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal UV
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal Wind
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt WindDir
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		HansPlc.PlainstrucWeatherNow CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(HansPlc.PlainstrucWeatherNow source);
		void FlushOnlineToPlain(HansPlc.PlainstrucWeatherNow source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowstrucWeatherNow : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowReal Temp
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal Hum
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal UV
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal Wind
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt WindDir
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		HansPlc.PlainstrucWeatherNow CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(HansPlc.PlainstrucWeatherNow source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainstrucWeatherNow : Vortex.Connector.IPlain
	{
		System.Single _Temp;
		public System.Single Temp
		{
			get
			{
				return _Temp;
			}

			set
			{
				_Temp = value;
			}
		}

		System.Single _Hum;
		public System.Single Hum
		{
			get
			{
				return _Hum;
			}

			set
			{
				_Hum = value;
			}
		}

		System.Single _UV;
		public System.Single UV
		{
			get
			{
				return _UV;
			}

			set
			{
				_UV = value;
			}
		}

		System.Single _Wind;
		public System.Single Wind
		{
			get
			{
				return _Wind;
			}

			set
			{
				_Wind = value;
			}
		}

		System.UInt16 _WindDir;
		public System.UInt16 WindDir
		{
			get
			{
				return _WindDir;
			}

			set
			{
				_WindDir = value;
			}
		}

		public void CopyPlainToCyclic(HansPlc.strucWeatherNow target)
		{
			target.Temp.Cyclic = Temp;
			target.Hum.Cyclic = Hum;
			target.UV.Cyclic = UV;
			target.Wind.Cyclic = Wind;
			target.WindDir.Cyclic = WindDir;
		}

		public void CopyPlainToCyclic(HansPlc.IstrucWeatherNow target)
		{
			this.CopyPlainToCyclic((HansPlc.strucWeatherNow)target);
		}

		public void CopyPlainToShadow(HansPlc.strucWeatherNow target)
		{
			target.Temp.Shadow = Temp;
			target.Hum.Shadow = Hum;
			target.UV.Shadow = UV;
			target.Wind.Shadow = Wind;
			target.WindDir.Shadow = WindDir;
		}

		public void CopyPlainToShadow(HansPlc.IShadowstrucWeatherNow target)
		{
			this.CopyPlainToShadow((HansPlc.strucWeatherNow)target);
		}

		public void CopyCyclicToPlain(HansPlc.strucWeatherNow source)
		{
			Temp = source.Temp.LastValue;
			Hum = source.Hum.LastValue;
			UV = source.UV.LastValue;
			Wind = source.Wind.LastValue;
			WindDir = source.WindDir.LastValue;
		}

		public void CopyCyclicToPlain(HansPlc.IstrucWeatherNow source)
		{
			this.CopyCyclicToPlain((HansPlc.strucWeatherNow)source);
		}

		public void CopyShadowToPlain(HansPlc.strucWeatherNow source)
		{
			Temp = source.Temp.Shadow;
			Hum = source.Hum.Shadow;
			UV = source.UV.Shadow;
			Wind = source.Wind.Shadow;
			WindDir = source.WindDir.Shadow;
		}

		public void CopyShadowToPlain(HansPlc.IShadowstrucWeatherNow source)
		{
			this.CopyShadowToPlain((HansPlc.strucWeatherNow)source);
		}

		public PlainstrucWeatherNow()
		{
		}
	}
}