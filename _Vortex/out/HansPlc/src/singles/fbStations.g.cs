using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace HansPlc
{
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "fbStations", "HansPlc", TypeComplexityEnum.Complex)]
	public partial class fbStations : Vortex.Connector.IVortexObject, IfbStations, IShadowfbStations, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		structWeatherNow _NorthPole;
		public structWeatherNow NorthPole
		{
			get
			{
				return _NorthPole;
			}
		}

		IstructWeatherNow IfbStations.NorthPole
		{
			get
			{
				return NorthPole;
			}
		}

		IShadowstructWeatherNow IShadowfbStations.NorthPole
		{
			get
			{
				return NorthPole;
			}
		}

		structWeatherNow _SouthPole;
		public structWeatherNow SouthPole
		{
			get
			{
				return _SouthPole;
			}
		}

		IstructWeatherNow IfbStations.SouthPole
		{
			get
			{
				return SouthPole;
			}
		}

		IShadowstructWeatherNow IShadowfbStations.SouthPole
		{
			get
			{
				return SouthPole;
			}
		}

		structWeatherNow _Verl;
		public structWeatherNow Verl
		{
			get
			{
				return _Verl;
			}
		}

		IstructWeatherNow IfbStations.Verl
		{
			get
			{
				return Verl;
			}
		}

		IShadowstructWeatherNow IShadowfbStations.Verl
		{
			get
			{
				return Verl;
			}
		}

		structWeatherNow _Kriva;
		public structWeatherNow Kriva
		{
			get
			{
				return _Kriva;
			}
		}

		IstructWeatherNow IfbStations.Kriva
		{
			get
			{
				return Kriva;
			}
		}

		IShadowstructWeatherNow IShadowfbStations.Kriva
		{
			get
			{
				return Kriva;
			}
		}

		public void LazyOnlineToShadow()
		{
			NorthPole.LazyOnlineToShadow();
			SouthPole.LazyOnlineToShadow();
			Verl.LazyOnlineToShadow();
			Kriva.LazyOnlineToShadow();
		}

		public void LazyShadowToOnline()
		{
			NorthPole.LazyShadowToOnline();
			SouthPole.LazyShadowToOnline();
			Verl.LazyShadowToOnline();
			Kriva.LazyShadowToOnline();
		}

		public PlainfbStations CreatePlainerType()
		{
			var cloned = new PlainfbStations();
			cloned.NorthPole = NorthPole.CreatePlainerType();
			cloned.SouthPole = SouthPole.CreatePlainerType();
			cloned.Verl = Verl.CreatePlainerType();
			cloned.Kriva = Kriva.CreatePlainerType();
			return cloned;
		}

		protected PlainfbStations CreatePlainerType(PlainfbStations cloned)
		{
			cloned.NorthPole = NorthPole.CreatePlainerType();
			cloned.SouthPole = SouthPole.CreatePlainerType();
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

		public void FlushPlainToOnline(HansPlc.PlainfbStations source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(HansPlc.PlainfbStations source)
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

		public void FlushOnlineToPlain(HansPlc.PlainfbStations source)
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

		public fbStations(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_NorthPole = new structWeatherNow(this, "<#North pole station#>", "NorthPole");
			_NorthPole.AttributeName = "<#North pole station#>";
			_SouthPole = new structWeatherNow(this, "<#South pole station#>", "SouthPole");
			_SouthPole.AttributeName = "<#South pole station#>";
			_Verl = new structWeatherNow(this, "<#Verl, Germany#>", "Verl");
			_Verl.AttributeName = "<#Verl, Germany#>";
			_Kriva = new structWeatherNow(this, "<#Kriva, Slovakia#>", "Kriva");
			_Kriva.AttributeName = "<#Kriva, Slovakia#>";
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public fbStations()
		{
			PexPreConstructorParameterless();
			_NorthPole = new structWeatherNow();
			_NorthPole.AttributeName = "<#North pole station#>";
			_SouthPole = new structWeatherNow();
			_SouthPole.AttributeName = "<#South pole station#>";
			_Verl = new structWeatherNow();
			_Verl.AttributeName = "<#Verl, Germany#>";
			_Kriva = new structWeatherNow();
			_Kriva.AttributeName = "<#Kriva, Slovakia#>";
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcfbStations
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcfbStations()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IfbStations : Vortex.Connector.IVortexOnlineObject
	{
		IstructWeatherNow NorthPole
		{
			get;
		}

		IstructWeatherNow SouthPole
		{
			get;
		}

		IstructWeatherNow Verl
		{
			get;
		}

		IstructWeatherNow Kriva
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		HansPlc.PlainfbStations CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(HansPlc.PlainfbStations source);
		void FlushOnlineToPlain(HansPlc.PlainfbStations source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowfbStations : Vortex.Connector.IVortexShadowObject
	{
		IShadowstructWeatherNow NorthPole
		{
			get;
		}

		IShadowstructWeatherNow SouthPole
		{
			get;
		}

		IShadowstructWeatherNow Verl
		{
			get;
		}

		IShadowstructWeatherNow Kriva
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		HansPlc.PlainfbStations CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(HansPlc.PlainfbStations source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainfbStations : Vortex.Connector.IPlain
	{
		PlainstructWeatherNow _NorthPole;
		public PlainstructWeatherNow NorthPole
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

		PlainstructWeatherNow _SouthPole;
		public PlainstructWeatherNow SouthPole
		{
			get
			{
				return _SouthPole;
			}

			set
			{
				_SouthPole = value;
			}
		}

		PlainstructWeatherNow _Verl;
		public PlainstructWeatherNow Verl
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

		PlainstructWeatherNow _Kriva;
		public PlainstructWeatherNow Kriva
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

		public void CopyPlainToCyclic(HansPlc.fbStations target)
		{
			NorthPole.CopyPlainToCyclic(target.NorthPole);
			SouthPole.CopyPlainToCyclic(target.SouthPole);
			Verl.CopyPlainToCyclic(target.Verl);
			Kriva.CopyPlainToCyclic(target.Kriva);
		}

		public void CopyPlainToCyclic(HansPlc.IfbStations target)
		{
			this.CopyPlainToCyclic((HansPlc.fbStations)target);
		}

		public void CopyPlainToShadow(HansPlc.fbStations target)
		{
			NorthPole.CopyPlainToShadow(target.NorthPole);
			SouthPole.CopyPlainToShadow(target.SouthPole);
			Verl.CopyPlainToShadow(target.Verl);
			Kriva.CopyPlainToShadow(target.Kriva);
		}

		public void CopyPlainToShadow(HansPlc.IShadowfbStations target)
		{
			this.CopyPlainToShadow((HansPlc.fbStations)target);
		}

		public void CopyCyclicToPlain(HansPlc.fbStations source)
		{
			NorthPole.CopyCyclicToPlain(source.NorthPole);
			SouthPole.CopyCyclicToPlain(source.SouthPole);
			Verl.CopyCyclicToPlain(source.Verl);
			Kriva.CopyCyclicToPlain(source.Kriva);
		}

		public void CopyCyclicToPlain(HansPlc.IfbStations source)
		{
			this.CopyCyclicToPlain((HansPlc.fbStations)source);
		}

		public void CopyShadowToPlain(HansPlc.fbStations source)
		{
			NorthPole.CopyShadowToPlain(source.NorthPole);
			SouthPole.CopyShadowToPlain(source.SouthPole);
			Verl.CopyShadowToPlain(source.Verl);
			Kriva.CopyShadowToPlain(source.Kriva);
		}

		public void CopyShadowToPlain(HansPlc.IShadowfbStations source)
		{
			this.CopyShadowToPlain((HansPlc.fbStations)source);
		}

		public PlainfbStations()
		{
			_NorthPole = new PlainstructWeatherNow();
			_SouthPole = new PlainstructWeatherNow();
			_Verl = new PlainstructWeatherNow();
			_Kriva = new PlainstructWeatherNow();
		}
	}
}