using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace HansPlc
{
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
			Verl.LazyOnlineToShadow();
			Kriva.LazyOnlineToShadow();
			PlcCommentOnCurrentWeather.Shadow = PlcCommentOnCurrentWeather.LastValue;
		}

		public void LazyShadowToOnline()
		{
			NorthPole.LazyShadowToOnline();
			Verl.LazyShadowToOnline();
			Kriva.LazyShadowToOnline();
			PlcCommentOnCurrentWeather.Cyclic = PlcCommentOnCurrentWeather.Shadow;
		}

		public PlainfbWorldWeatherWatch CreatePlainerType()
		{
			var cloned = new PlainfbWorldWeatherWatch();
			cloned.NorthPole = NorthPole.CreatePlainerType();
			cloned.Verl = Verl.CreatePlainerType();
			cloned.Kriva = Kriva.CreatePlainerType();
			return cloned;
		}

		protected PlainfbWorldWeatherWatch CreatePlainerType(PlainfbWorldWeatherWatch cloned)
		{
			cloned.NorthPole = NorthPole.CreatePlainerType();
			cloned.Verl = Verl.CreatePlainerType();
			cloned.Kriva = Kriva.CreatePlainerType();
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
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_NorthPole = new structWeatherStation(this, "<#North pole station#>", "NorthPole");
			_NorthPole.AttributeName = "<#North pole station#>";
			_Verl = new structWeatherStation(this, "<#Verl, Germany#>", "Verl");
			_Verl.AttributeName = "<#Verl, Germany#>";
			_Kriva = new structWeatherStation(this, "<#Kriva, Slovakia#>", "Kriva");
			_Kriva.AttributeName = "<#Kriva, Slovakia#>";
			_PlcCommentOnCurrentWeather = @Connector.Online.Adapter.CreateSTRING(this, "<#What plc says#>", "PlcCommentOnCurrentWeather");
			PlcCommentOnCurrentWeather.AttributeName = "<#What plc says#>";
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public fbWorldWeatherWatch()
		{
			PexPreConstructorParameterless();
			_NorthPole = new structWeatherStation();
			_NorthPole.AttributeName = "<#North pole station#>";
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
	public partial class PlainfbWorldWeatherWatch : Vortex.Connector.IPlain
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
				_NorthPole = value;
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
				_Verl = value;
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
				_Kriva = value;
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
				_PlcCommentOnCurrentWeather = value;
			}
		}

		public void CopyPlainToCyclic(HansPlc.fbWorldWeatherWatch target)
		{
			NorthPole.CopyPlainToCyclic(target.NorthPole);
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
			Verl.CopyShadowToPlain(source.Verl);
			Kriva.CopyShadowToPlain(source.Kriva);
			PlcCommentOnCurrentWeather = source.PlcCommentOnCurrentWeather.Shadow;
		}

		public void CopyShadowToPlain(HansPlc.IShadowfbWorldWeatherWatch source)
		{
			this.CopyShadowToPlain((HansPlc.fbWorldWeatherWatch)source);
		}

		public PlainfbWorldWeatherWatch()
		{
			_NorthPole = new PlainstructWeatherStation();
			_Verl = new PlainstructWeatherStation();
			_Kriva = new PlainstructWeatherStation();
		}
	}
}