using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace HansPlc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "fbWorldWeatherWatch", "HansPlc", TypeComplexityEnum.Complex)]
	public partial class fbWorldWeatherWatch : Vortex.Connector.IVortexObject, IfbWorldWeatherWatch, IShadowfbWorldWeatherWatch, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		structWeatherStation _NorthPole;
		public structWeatherStation NorthPole
		{
			get
			{
				return _NorthPole;
			}
		}

		IstructWeatherStation IfbWorldWeatherWatch.NorthPole
		{
			get
			{
				return NorthPole;
			}
		}

		IShadowstructWeatherStation IShadowfbWorldWeatherWatch.NorthPole
		{
			get
			{
				return NorthPole;
			}
		}

		structWeatherStation _SouthPole;
		public structWeatherStation SouthPole
		{
			get
			{
				return _SouthPole;
			}
		}

		IstructWeatherStation IfbWorldWeatherWatch.SouthPole
		{
			get
			{
				return SouthPole;
			}
		}

		IShadowstructWeatherStation IShadowfbWorldWeatherWatch.SouthPole
		{
			get
			{
				return SouthPole;
			}
		}

		structWeatherStation _Verl;
		public structWeatherStation Verl
		{
			get
			{
				return _Verl;
			}
		}

		IstructWeatherStation IfbWorldWeatherWatch.Verl
		{
			get
			{
				return Verl;
			}
		}

		IShadowstructWeatherStation IShadowfbWorldWeatherWatch.Verl
		{
			get
			{
				return Verl;
			}
		}

		structWeatherStation _Kriva;
		public structWeatherStation Kriva
		{
			get
			{
				return _Kriva;
			}
		}

		IstructWeatherStation IfbWorldWeatherWatch.Kriva
		{
			get
			{
				return Kriva;
			}
		}

		IShadowstructWeatherStation IShadowfbWorldWeatherWatch.Kriva
		{
			get
			{
				return Kriva;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _PlcCommentOnCurrentWeather;
		public Vortex.Connector.ValueTypes.OnlinerString PlcCommentOnCurrentWeather
		{
			get
			{
				return _PlcCommentOnCurrentWeather;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IfbWorldWeatherWatch.PlcCommentOnCurrentWeather
		{
			get
			{
				return PlcCommentOnCurrentWeather;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowfbWorldWeatherWatch.PlcCommentOnCurrentWeather
		{
			get
			{
				return PlcCommentOnCurrentWeather;
			}
		}

		public void LazyOnlineToShadow()
		{
			NorthPole.LazyOnlineToShadow();
			SouthPole.LazyOnlineToShadow();
			Verl.LazyOnlineToShadow();
			Kriva.LazyOnlineToShadow();
			PlcCommentOnCurrentWeather.Shadow = PlcCommentOnCurrentWeather.LastValue;
		}

		public void LazyShadowToOnline()
		{
			NorthPole.LazyShadowToOnline();
			SouthPole.LazyShadowToOnline();
			Verl.LazyShadowToOnline();
			Kriva.LazyShadowToOnline();
			PlcCommentOnCurrentWeather.Cyclic = PlcCommentOnCurrentWeather.Shadow;
		}

		public PlainfbWorldWeatherWatch CreatePlainerType()
		{
			var cloned = new PlainfbWorldWeatherWatch();
			cloned.NorthPole = NorthPole.CreatePlainerType();
			cloned.SouthPole = SouthPole.CreatePlainerType();
			cloned.Verl = Verl.CreatePlainerType();
			cloned.Kriva = Kriva.CreatePlainerType();
			return cloned;
		}

		protected PlainfbWorldWeatherWatch CreatePlainerType(PlainfbWorldWeatherWatch cloned)
		{
			cloned.NorthPole = NorthPole.CreatePlainerType();
			cloned.SouthPole = SouthPole.CreatePlainerType();
			cloned.Verl = Verl.CreatePlainerType();
			cloned.Kriva = Kriva.CreatePlainerType();
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

		public void FlushPlainToOnline(HansPlc.PlainfbWorldWeatherWatch source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(HansPlc.PlainfbWorldWeatherWatch source)
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

		public void FlushOnlineToPlain(HansPlc.PlainfbWorldWeatherWatch source)
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

		public fbWorldWeatherWatch(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			_NorthPole = new structWeatherStation(this, "<#North pole station#>", "NorthPole");
			_NorthPole.AttributeName = "<#North pole station#>";
			_SouthPole = new structWeatherStation(this, "<#South pole station#>", "SouthPole");
			_SouthPole.AttributeName = "<#South pole station#>";
			_Verl = new structWeatherStation(this, "<#Verl, Germany#>", "Verl");
			_Verl.AttributeName = "<#Verl, Germany#>";
			_Kriva = new structWeatherStation(this, "<#Kriva, Slovakia#>", "Kriva");
			_Kriva.AttributeName = "<#Kriva, Slovakia#>";
			_PlcCommentOnCurrentWeather = @Connector.Online.Adapter.CreateSTRING(this, "<#What plc says#>", "PlcCommentOnCurrentWeather");
			PlcCommentOnCurrentWeather.AttributeName = "<#What plc says#>";
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public fbWorldWeatherWatch()
		{
			PexPreConstructorParameterless();
			_NorthPole = new structWeatherStation();
			_NorthPole.AttributeName = "<#North pole station#>";
			_SouthPole = new structWeatherStation();
			_SouthPole.AttributeName = "<#South pole station#>";
			_Verl = new structWeatherStation();
			_Verl.AttributeName = "<#Verl, Germany#>";
			_Kriva = new structWeatherStation();
			_Kriva.AttributeName = "<#Kriva, Slovakia#>";
			_PlcCommentOnCurrentWeather = Vortex.Connector.IConnectorFactory.CreateSTRING();
			PlcCommentOnCurrentWeather.AttributeName = "<#What plc says#>";
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcfbWorldWeatherWatch
		{
			public PlainstructWeatherStation NorthPole;
			public PlainstructWeatherStation SouthPole;
			public PlainstructWeatherStation Verl;
			public PlainstructWeatherStation Kriva;
			public object PlcCommentOnCurrentWeather;
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcfbWorldWeatherWatch()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IfbWorldWeatherWatch : Vortex.Connector.IVortexOnlineObject
	{
		IstructWeatherStation NorthPole
		{
			get;
		}

		IstructWeatherStation SouthPole
		{
			get;
		}

		IstructWeatherStation Verl
		{
			get;
		}

		IstructWeatherStation Kriva
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString PlcCommentOnCurrentWeather
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		HansPlc.PlainfbWorldWeatherWatch CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(HansPlc.PlainfbWorldWeatherWatch source);
		void FlushOnlineToPlain(HansPlc.PlainfbWorldWeatherWatch source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowfbWorldWeatherWatch : Vortex.Connector.IVortexShadowObject
	{
		IShadowstructWeatherStation NorthPole
		{
			get;
		}

		IShadowstructWeatherStation SouthPole
		{
			get;
		}

		IShadowstructWeatherStation Verl
		{
			get;
		}

		IShadowstructWeatherStation Kriva
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString PlcCommentOnCurrentWeather
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		HansPlc.PlainfbWorldWeatherWatch CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(HansPlc.PlainfbWorldWeatherWatch source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainfbWorldWeatherWatch : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		PlainstructWeatherStation _NorthPole;
		public PlainstructWeatherStation NorthPole
		{
			get
			{
				return _NorthPole;
			}

			set
			{
				if (_NorthPole != value)
				{
					_NorthPole = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(NorthPole)));
				}
			}
		}

		PlainstructWeatherStation _SouthPole;
		public PlainstructWeatherStation SouthPole
		{
			get
			{
				return _SouthPole;
			}

			set
			{
				if (_SouthPole != value)
				{
					_SouthPole = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(SouthPole)));
				}
			}
		}

		PlainstructWeatherStation _Verl;
		public PlainstructWeatherStation Verl
		{
			get
			{
				return _Verl;
			}

			set
			{
				if (_Verl != value)
				{
					_Verl = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Verl)));
				}
			}
		}

		PlainstructWeatherStation _Kriva;
		public PlainstructWeatherStation Kriva
		{
			get
			{
				return _Kriva;
			}

			set
			{
				if (_Kriva != value)
				{
					_Kriva = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Kriva)));
				}
			}
		}

		System.String _PlcCommentOnCurrentWeather;
		public System.String PlcCommentOnCurrentWeather
		{
			get
			{
				return _PlcCommentOnCurrentWeather;
			}

			set
			{
				if (_PlcCommentOnCurrentWeather != value)
				{
					_PlcCommentOnCurrentWeather = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(PlcCommentOnCurrentWeather)));
				}
			}
		}

		public void CopyPlainToCyclic(HansPlc.fbWorldWeatherWatch target)
		{
			NorthPole.CopyPlainToCyclic(target.NorthPole);
			SouthPole.CopyPlainToCyclic(target.SouthPole);
			Verl.CopyPlainToCyclic(target.Verl);
			Kriva.CopyPlainToCyclic(target.Kriva);
			target.PlcCommentOnCurrentWeather.Cyclic = PlcCommentOnCurrentWeather;
		}

		public void CopyPlainToCyclic(HansPlc.IfbWorldWeatherWatch target)
		{
			this.CopyPlainToCyclic((HansPlc.fbWorldWeatherWatch)target);
		}

		public void CopyPlainToShadow(HansPlc.fbWorldWeatherWatch target)
		{
			NorthPole.CopyPlainToShadow(target.NorthPole);
			SouthPole.CopyPlainToShadow(target.SouthPole);
			Verl.CopyPlainToShadow(target.Verl);
			Kriva.CopyPlainToShadow(target.Kriva);
			target.PlcCommentOnCurrentWeather.Shadow = PlcCommentOnCurrentWeather;
		}

		public void CopyPlainToShadow(HansPlc.IShadowfbWorldWeatherWatch target)
		{
			this.CopyPlainToShadow((HansPlc.fbWorldWeatherWatch)target);
		}

		public void CopyCyclicToPlain(HansPlc.fbWorldWeatherWatch source)
		{
			NorthPole.CopyCyclicToPlain(source.NorthPole);
			SouthPole.CopyCyclicToPlain(source.SouthPole);
			Verl.CopyCyclicToPlain(source.Verl);
			Kriva.CopyCyclicToPlain(source.Kriva);
			PlcCommentOnCurrentWeather = source.PlcCommentOnCurrentWeather.LastValue;
		}

		public void CopyCyclicToPlain(HansPlc.IfbWorldWeatherWatch source)
		{
			this.CopyCyclicToPlain((HansPlc.fbWorldWeatherWatch)source);
		}

		public void CopyShadowToPlain(HansPlc.fbWorldWeatherWatch source)
		{
			NorthPole.CopyShadowToPlain(source.NorthPole);
			SouthPole.CopyShadowToPlain(source.SouthPole);
			Verl.CopyShadowToPlain(source.Verl);
			Kriva.CopyShadowToPlain(source.Kriva);
			PlcCommentOnCurrentWeather = source.PlcCommentOnCurrentWeather.Shadow;
		}

		public void CopyShadowToPlain(HansPlc.IShadowfbWorldWeatherWatch source)
		{
			this.CopyShadowToPlain((HansPlc.fbWorldWeatherWatch)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainfbWorldWeatherWatch()
		{
			_NorthPole = new PlainstructWeatherStation();
			_SouthPole = new PlainstructWeatherStation();
			_Verl = new PlainstructWeatherStation();
			_Kriva = new PlainstructWeatherStation();
		}
	}
}