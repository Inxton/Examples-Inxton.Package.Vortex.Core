using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace HansPlc
{
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "structWeatherNow", "HansPlc", TypeComplexityEnum.Complex)]
	public partial class structWeatherNow : Vortex.Connector.IVortexObject, IstructWeatherNow, IShadowstructWeatherNow, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerString _StationICAO;
		public Vortex.Connector.ValueTypes.OnlinerString StationICAO
		{
			get
			{
				return _StationICAO;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IstructWeatherNow.StationICAO
		{
			get
			{
				return StationICAO;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowstructWeatherNow.StationICAO
		{
			get
			{
				return StationICAO;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _StationStatus;
		[Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (enumStationStatus))]
		public Vortex.Connector.ValueTypes.OnlinerInt StationStatus
		{
			get
			{
				return _StationStatus;
			}
		}

		[Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (enumStationStatus))]
		Vortex.Connector.ValueTypes.Online.IOnlineInt IstructWeatherNow.StationStatus
		{
			get
			{
				return StationStatus;
			}
		}

		[Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (enumStationStatus))]
		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowstructWeatherNow.StationStatus
		{
			get
			{
				return StationStatus;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal _DewPoint;
		public Vortex.Connector.ValueTypes.OnlinerReal DewPoint
		{
			get
			{
				return _DewPoint;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstructWeatherNow.DewPoint
		{
			get
			{
				return DewPoint;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstructWeatherNow.DewPoint
		{
			get
			{
				return DewPoint;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal _Pressure;
		public Vortex.Connector.ValueTypes.OnlinerReal Pressure
		{
			get
			{
				return _Pressure;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstructWeatherNow.Pressure
		{
			get
			{
				return Pressure;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstructWeatherNow.Pressure
		{
			get
			{
				return Pressure;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal _Temp;
		public Vortex.Connector.ValueTypes.OnlinerReal Temp
		{
			get
			{
				return _Temp;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstructWeatherNow.Temp
		{
			get
			{
				return Temp;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstructWeatherNow.Temp
		{
			get
			{
				return Temp;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal _Visibility;
		public Vortex.Connector.ValueTypes.OnlinerReal Visibility
		{
			get
			{
				return _Visibility;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstructWeatherNow.Visibility
		{
			get
			{
				return Visibility;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstructWeatherNow.Visibility
		{
			get
			{
				return Visibility;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUInt _WindHeading;
		public Vortex.Connector.ValueTypes.OnlinerUInt WindHeading
		{
			get
			{
				return _WindHeading;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt IstructWeatherNow.WindHeading
		{
			get
			{
				return WindHeading;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowstructWeatherNow.WindHeading
		{
			get
			{
				return WindHeading;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal _WindSpeed;
		public Vortex.Connector.ValueTypes.OnlinerReal WindSpeed
		{
			get
			{
				return _WindSpeed;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstructWeatherNow.WindSpeed
		{
			get
			{
				return WindSpeed;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstructWeatherNow.WindSpeed
		{
			get
			{
				return WindSpeed;
			}
		}

		public void LazyOnlineToShadow()
		{
			StationICAO.Shadow = StationICAO.LastValue;
			StationStatus.Shadow = StationStatus.LastValue;
			DewPoint.Shadow = DewPoint.LastValue;
			Pressure.Shadow = Pressure.LastValue;
			Temp.Shadow = Temp.LastValue;
			Visibility.Shadow = Visibility.LastValue;
			WindHeading.Shadow = WindHeading.LastValue;
			WindSpeed.Shadow = WindSpeed.LastValue;
		}

		public void LazyShadowToOnline()
		{
			StationICAO.Cyclic = StationICAO.Shadow;
			StationStatus.Cyclic = StationStatus.Shadow;
			DewPoint.Cyclic = DewPoint.Shadow;
			Pressure.Cyclic = Pressure.Shadow;
			Temp.Cyclic = Temp.Shadow;
			Visibility.Cyclic = Visibility.Shadow;
			WindHeading.Cyclic = WindHeading.Shadow;
			WindSpeed.Cyclic = WindSpeed.Shadow;
		}

		public PlainstructWeatherNow CreatePlainerType()
		{
			var cloned = new PlainstructWeatherNow();
			return cloned;
		}

		protected PlainstructWeatherNow CreatePlainerType(PlainstructWeatherNow cloned)
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

		public void FlushPlainToOnline(HansPlc.PlainstructWeatherNow source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(HansPlc.PlainstructWeatherNow source)
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

		public void FlushOnlineToPlain(HansPlc.PlainstructWeatherNow source)
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

		public structWeatherNow(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_StationICAO = @Connector.Online.Adapter.CreateSTRING(this, "<#Station name (ICAO)#>", "StationICAO");
			StationICAO.AttributeName = "<#Station name (ICAO)#>";
			_StationStatus = @Connector.Online.Adapter.CreateINT(this, "<#Station status#>", "StationStatus");
			StationStatus.AttributeName = "<#Station status#>";
			_DewPoint = @Connector.Online.Adapter.CreateREAL(this, "<#Dew Point#>", "DewPoint");
			DewPoint.AttributeName = "<#Dew Point#>";
			DewPoint.AttributeUnits = "°C";
			_Pressure = @Connector.Online.Adapter.CreateREAL(this, "<#Pressure#>", "Pressure");
			Pressure.AttributeName = "<#Pressure#>";
			Pressure.AttributeUnits = "Torr";
			_Temp = @Connector.Online.Adapter.CreateREAL(this, "<#Temperature#>", "Temp");
			Temp.AttributeName = "<#Temperature#>";
			Temp.AttributeUnits = "°C";
			_Visibility = @Connector.Online.Adapter.CreateREAL(this, "<#Visibility#>", "Visibility");
			Visibility.AttributeName = "<#Visibility#>";
			Visibility.AttributeUnits = "km";
			_WindHeading = @Connector.Online.Adapter.CreateUINT(this, "<#Wind heading#>", "WindHeading");
			WindHeading.AttributeName = "<#Wind heading#>";
			WindHeading.AttributeUnits = "Azimuth";
			_WindSpeed = @Connector.Online.Adapter.CreateREAL(this, "<#Wind speed#>", "WindSpeed");
			WindSpeed.AttributeName = "<#Wind speed#>";
			WindSpeed.AttributeUnits = "m/s";
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public structWeatherNow()
		{
			PexPreConstructorParameterless();
			_StationICAO = Vortex.Connector.IConnectorFactory.CreateSTRING();
			StationICAO.AttributeName = "<#Station name (ICAO)#>";
			_StationStatus = Vortex.Connector.IConnectorFactory.CreateINT();
			StationStatus.AttributeName = "<#Station status#>";
			_DewPoint = Vortex.Connector.IConnectorFactory.CreateREAL();
			DewPoint.AttributeName = "<#Dew Point#>";
			DewPoint.AttributeUnits = "°C";
			_Pressure = Vortex.Connector.IConnectorFactory.CreateREAL();
			Pressure.AttributeName = "<#Pressure#>";
			Pressure.AttributeUnits = "Torr";
			_Temp = Vortex.Connector.IConnectorFactory.CreateREAL();
			Temp.AttributeName = "<#Temperature#>";
			Temp.AttributeUnits = "°C";
			_Visibility = Vortex.Connector.IConnectorFactory.CreateREAL();
			Visibility.AttributeName = "<#Visibility#>";
			Visibility.AttributeUnits = "km";
			_WindHeading = Vortex.Connector.IConnectorFactory.CreateUINT();
			WindHeading.AttributeName = "<#Wind heading#>";
			WindHeading.AttributeUnits = "Azimuth";
			_WindSpeed = Vortex.Connector.IConnectorFactory.CreateREAL();
			WindSpeed.AttributeName = "<#Wind speed#>";
			WindSpeed.AttributeUnits = "m/s";
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcstructWeatherNow
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcstructWeatherNow()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IstructWeatherNow : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineString StationICAO
		{
			get;
		}

		[Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (enumStationStatus))]
		Vortex.Connector.ValueTypes.Online.IOnlineInt StationStatus
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal DewPoint
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal Pressure
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal Temp
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal Visibility
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt WindHeading
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal WindSpeed
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		HansPlc.PlainstructWeatherNow CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(HansPlc.PlainstructWeatherNow source);
		void FlushOnlineToPlain(HansPlc.PlainstructWeatherNow source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowstructWeatherNow : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowString StationICAO
		{
			get;
		}

		[Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (enumStationStatus))]
		Vortex.Connector.ValueTypes.Shadows.IShadowInt StationStatus
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal DewPoint
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal Pressure
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal Temp
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal Visibility
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt WindHeading
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal WindSpeed
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		HansPlc.PlainstructWeatherNow CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(HansPlc.PlainstructWeatherNow source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainstructWeatherNow : Vortex.Connector.IPlain
	{
		System.String _StationICAO;
		public System.String StationICAO
		{
			get
			{
				return _StationICAO;
			}

			set
			{
				_StationICAO = value;
			}
		}

		System.Int16 _StationStatus;
		[Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (enumStationStatus))]
		public System.Int16 StationStatus
		{
			get
			{
				return _StationStatus;
			}

			set
			{
				_StationStatus = value;
			}
		}

		System.Single _DewPoint;
		public System.Single DewPoint
		{
			get
			{
				return _DewPoint;
			}

			set
			{
				_DewPoint = value;
			}
		}

		System.Single _Pressure;
		public System.Single Pressure
		{
			get
			{
				return _Pressure;
			}

			set
			{
				_Pressure = value;
			}
		}

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

		System.Single _Visibility;
		public System.Single Visibility
		{
			get
			{
				return _Visibility;
			}

			set
			{
				_Visibility = value;
			}
		}

		System.UInt16 _WindHeading;
		public System.UInt16 WindHeading
		{
			get
			{
				return _WindHeading;
			}

			set
			{
				_WindHeading = value;
			}
		}

		System.Single _WindSpeed;
		public System.Single WindSpeed
		{
			get
			{
				return _WindSpeed;
			}

			set
			{
				_WindSpeed = value;
			}
		}

		public void CopyPlainToCyclic(HansPlc.structWeatherNow target)
		{
			target.StationICAO.Cyclic = StationICAO;
			target.StationStatus.Cyclic = StationStatus;
			target.DewPoint.Cyclic = DewPoint;
			target.Pressure.Cyclic = Pressure;
			target.Temp.Cyclic = Temp;
			target.Visibility.Cyclic = Visibility;
			target.WindHeading.Cyclic = WindHeading;
			target.WindSpeed.Cyclic = WindSpeed;
		}

		public void CopyPlainToCyclic(HansPlc.IstructWeatherNow target)
		{
			this.CopyPlainToCyclic((HansPlc.structWeatherNow)target);
		}

		public void CopyPlainToShadow(HansPlc.structWeatherNow target)
		{
			target.StationICAO.Shadow = StationICAO;
			target.StationStatus.Shadow = StationStatus;
			target.DewPoint.Shadow = DewPoint;
			target.Pressure.Shadow = Pressure;
			target.Temp.Shadow = Temp;
			target.Visibility.Shadow = Visibility;
			target.WindHeading.Shadow = WindHeading;
			target.WindSpeed.Shadow = WindSpeed;
		}

		public void CopyPlainToShadow(HansPlc.IShadowstructWeatherNow target)
		{
			this.CopyPlainToShadow((HansPlc.structWeatherNow)target);
		}

		public void CopyCyclicToPlain(HansPlc.structWeatherNow source)
		{
			StationICAO = source.StationICAO.LastValue;
			StationStatus = source.StationStatus.LastValue;
			DewPoint = source.DewPoint.LastValue;
			Pressure = source.Pressure.LastValue;
			Temp = source.Temp.LastValue;
			Visibility = source.Visibility.LastValue;
			WindHeading = source.WindHeading.LastValue;
			WindSpeed = source.WindSpeed.LastValue;
		}

		public void CopyCyclicToPlain(HansPlc.IstructWeatherNow source)
		{
			this.CopyCyclicToPlain((HansPlc.structWeatherNow)source);
		}

		public void CopyShadowToPlain(HansPlc.structWeatherNow source)
		{
			StationICAO = source.StationICAO.Shadow;
			StationStatus = source.StationStatus.Shadow;
			DewPoint = source.DewPoint.Shadow;
			Pressure = source.Pressure.Shadow;
			Temp = source.Temp.Shadow;
			Visibility = source.Visibility.Shadow;
			WindHeading = source.WindHeading.Shadow;
			WindSpeed = source.WindSpeed.Shadow;
		}

		public void CopyShadowToPlain(HansPlc.IShadowstructWeatherNow source)
		{
			this.CopyShadowToPlain((HansPlc.structWeatherNow)source);
		}

		public PlainstructWeatherNow()
		{
		}
	}
}