using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace HansPlc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "structWeatherStation", "HansPlc", TypeComplexityEnum.Complex)]
	public partial class structWeatherStation : Vortex.Connector.IVortexObject, IstructWeatherStation, IShadowstructWeatherStation, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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

		Vortex.Connector.ValueTypes.Online.IOnlineString IstructWeatherStation.StationICAO
		{
			get
			{
				return StationICAO;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowstructWeatherStation.StationICAO
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
		Vortex.Connector.ValueTypes.Online.IOnlineInt IstructWeatherStation.StationStatus
		{
			get
			{
				return StationStatus;
			}
		}

		[Vortex.Connector.EnumeratorDiscriminatorAttribute(typeof (enumStationStatus))]
		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowstructWeatherStation.StationStatus
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

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstructWeatherStation.DewPoint
		{
			get
			{
				return DewPoint;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstructWeatherStation.DewPoint
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

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstructWeatherStation.Pressure
		{
			get
			{
				return Pressure;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstructWeatherStation.Pressure
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

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstructWeatherStation.Temp
		{
			get
			{
				return Temp;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstructWeatherStation.Temp
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

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstructWeatherStation.Visibility
		{
			get
			{
				return Visibility;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstructWeatherStation.Visibility
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

		Vortex.Connector.ValueTypes.Online.IOnlineUInt IstructWeatherStation.WindHeading
		{
			get
			{
				return WindHeading;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowstructWeatherStation.WindHeading
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

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstructWeatherStation.WindSpeed
		{
			get
			{
				return WindSpeed;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstructWeatherStation.WindSpeed
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

		public PlainstructWeatherStation CreatePlainerType()
		{
			var cloned = new PlainstructWeatherStation();
			return cloned;
		}

		protected PlainstructWeatherStation CreatePlainerType(PlainstructWeatherStation cloned)
		{
			return cloned;
		}

		partial void PexPreConstructor(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail);
		partial void PexPreConstructorParameterless();
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

		private System.Collections.Generic.List<Vortex.Connector.IVortexElement> Kids
		{
			get;
			set;
		}

		public System.Collections.Generic.IEnumerable<Vortex.Connector.IVortexElement> GetKids()
		{
			return this.Kids;
		}

		public void AddKid(Vortex.Connector.IVortexElement vortexElement)
		{
			this.Kids.Add(vortexElement);
		}

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

		public void FlushPlainToOnline(HansPlc.PlainstructWeatherStation source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(HansPlc.PlainstructWeatherStation source)
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

		public void FlushOnlineToPlain(HansPlc.PlainstructWeatherStation source)
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

		public structWeatherStation(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			this.Kids = new System.Collections.Generic.List<Vortex.Connector.IVortexElement>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
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
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public structWeatherStation()
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
		protected abstract class PlcstructWeatherStation
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcstructWeatherStation()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IstructWeatherStation : Vortex.Connector.IVortexOnlineObject
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

		HansPlc.PlainstructWeatherStation CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(HansPlc.PlainstructWeatherStation source);
		void FlushOnlineToPlain(HansPlc.PlainstructWeatherStation source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowstructWeatherStation : Vortex.Connector.IVortexShadowObject
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

		HansPlc.PlainstructWeatherStation CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(HansPlc.PlainstructWeatherStation source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainstructWeatherStation : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
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
				if (_StationICAO != value)
				{
					_StationICAO = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(StationICAO)));
				}
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
				if (_StationStatus != value)
				{
					_StationStatus = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(StationStatus)));
				}
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
				if (_DewPoint != value)
				{
					_DewPoint = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(DewPoint)));
				}
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
				if (_Pressure != value)
				{
					_Pressure = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Pressure)));
				}
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
				if (_Temp != value)
				{
					_Temp = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Temp)));
				}
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
				if (_Visibility != value)
				{
					_Visibility = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Visibility)));
				}
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
				if (_WindHeading != value)
				{
					_WindHeading = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(WindHeading)));
				}
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
				if (_WindSpeed != value)
				{
					_WindSpeed = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(WindSpeed)));
				}
			}
		}

		public void CopyPlainToCyclic(HansPlc.structWeatherStation target)
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

		public void CopyPlainToCyclic(HansPlc.IstructWeatherStation target)
		{
			this.CopyPlainToCyclic((HansPlc.structWeatherStation)target);
		}

		public void CopyPlainToShadow(HansPlc.structWeatherStation target)
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

		public void CopyPlainToShadow(HansPlc.IShadowstructWeatherStation target)
		{
			this.CopyPlainToShadow((HansPlc.structWeatherStation)target);
		}

		public void CopyCyclicToPlain(HansPlc.structWeatherStation source)
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

		public void CopyCyclicToPlain(HansPlc.IstructWeatherStation source)
		{
			this.CopyCyclicToPlain((HansPlc.structWeatherStation)source);
		}

		public void CopyShadowToPlain(HansPlc.structWeatherStation source)
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

		public void CopyShadowToPlain(HansPlc.IShadowstructWeatherStation source)
		{
			this.CopyShadowToPlain((HansPlc.structWeatherStation)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainstructWeatherStation()
		{
		}
	}
}