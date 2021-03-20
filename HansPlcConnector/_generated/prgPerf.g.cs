using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace HansPlc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "prgPerf", "HansPlc", TypeComplexityEnum.Complex)]
	public partial class prgPerf : Vortex.Connector.IVortexObject, IprgPerf, IShadowprgPerf, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		stHugeArrayOfComplex _hugeArrayOfComplex;
		public stHugeArrayOfComplex hugeArrayOfComplex
		{
			get
			{
				return _hugeArrayOfComplex;
			}
		}

		IstHugeArrayOfComplex IprgPerf.hugeArrayOfComplex
		{
			get
			{
				return hugeArrayOfComplex;
			}
		}

		IShadowstHugeArrayOfComplex IShadowprgPerf.hugeArrayOfComplex
		{
			get
			{
				return hugeArrayOfComplex;
			}
		}

		stHugeArrayOfPrimitive _hugeArrayOfPrimitive;
		public stHugeArrayOfPrimitive hugeArrayOfPrimitive
		{
			get
			{
				return _hugeArrayOfPrimitive;
			}
		}

		IstHugeArrayOfPrimitive IprgPerf.hugeArrayOfPrimitive
		{
			get
			{
				return hugeArrayOfPrimitive;
			}
		}

		IShadowstHugeArrayOfPrimitive IShadowprgPerf.hugeArrayOfPrimitive
		{
			get
			{
				return hugeArrayOfPrimitive;
			}
		}

		stHugeStructureOfComplex _hugeStructureOfComplex;
		public stHugeStructureOfComplex hugeStructureOfComplex
		{
			get
			{
				return _hugeStructureOfComplex;
			}
		}

		IstHugeStructureOfComplex IprgPerf.hugeStructureOfComplex
		{
			get
			{
				return hugeStructureOfComplex;
			}
		}

		IShadowstHugeStructureOfComplex IShadowprgPerf.hugeStructureOfComplex
		{
			get
			{
				return hugeStructureOfComplex;
			}
		}

		stHugeStructureOfPrimitive _hugeStructureOfPrimitive;
		public stHugeStructureOfPrimitive hugeStructureOfPrimitive
		{
			get
			{
				return _hugeStructureOfPrimitive;
			}
		}

		IstHugeStructureOfPrimitive IprgPerf.hugeStructureOfPrimitive
		{
			get
			{
				return hugeStructureOfPrimitive;
			}
		}

		IShadowstHugeStructureOfPrimitive IShadowprgPerf.hugeStructureOfPrimitive
		{
			get
			{
				return hugeStructureOfPrimitive;
			}
		}

		public void LazyOnlineToShadow()
		{
			hugeArrayOfComplex.LazyOnlineToShadow();
			hugeArrayOfPrimitive.LazyOnlineToShadow();
			hugeStructureOfComplex.LazyOnlineToShadow();
			hugeStructureOfPrimitive.LazyOnlineToShadow();
		}

		public void LazyShadowToOnline()
		{
			hugeArrayOfComplex.LazyShadowToOnline();
			hugeArrayOfPrimitive.LazyShadowToOnline();
			hugeStructureOfComplex.LazyShadowToOnline();
			hugeStructureOfPrimitive.LazyShadowToOnline();
		}

		public PlainprgPerf CreatePlainerType()
		{
			var cloned = new PlainprgPerf();
			cloned.hugeArrayOfComplex = hugeArrayOfComplex.CreatePlainerType();
			cloned.hugeArrayOfPrimitive = hugeArrayOfPrimitive.CreatePlainerType();
			cloned.hugeStructureOfComplex = hugeStructureOfComplex.CreatePlainerType();
			cloned.hugeStructureOfPrimitive = hugeStructureOfPrimitive.CreatePlainerType();
			return cloned;
		}

		protected PlainprgPerf CreatePlainerType(PlainprgPerf cloned)
		{
			cloned.hugeArrayOfComplex = hugeArrayOfComplex.CreatePlainerType();
			cloned.hugeArrayOfPrimitive = hugeArrayOfPrimitive.CreatePlainerType();
			cloned.hugeStructureOfComplex = hugeStructureOfComplex.CreatePlainerType();
			cloned.hugeStructureOfPrimitive = hugeStructureOfPrimitive.CreatePlainerType();
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

		public void FlushPlainToOnline(HansPlc.PlainprgPerf source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(HansPlc.PlainprgPerf source)
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

		public void FlushOnlineToPlain(HansPlc.PlainprgPerf source)
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

		public prgPerf(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			_hugeArrayOfComplex = new stHugeArrayOfComplex(this, "", "hugeArrayOfComplex");
			_hugeArrayOfPrimitive = new stHugeArrayOfPrimitive(this, "", "hugeArrayOfPrimitive");
			_hugeStructureOfComplex = new stHugeStructureOfComplex(this, "", "hugeStructureOfComplex");
			_hugeStructureOfPrimitive = new stHugeStructureOfPrimitive(this, "", "hugeStructureOfPrimitive");
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public prgPerf()
		{
			PexPreConstructorParameterless();
			_hugeArrayOfComplex = new stHugeArrayOfComplex();
			_hugeArrayOfPrimitive = new stHugeArrayOfPrimitive();
			_hugeStructureOfComplex = new stHugeStructureOfComplex();
			_hugeStructureOfPrimitive = new stHugeStructureOfPrimitive();
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcprgPerf
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcprgPerf()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IprgPerf : Vortex.Connector.IVortexOnlineObject
	{
		IstHugeArrayOfComplex hugeArrayOfComplex
		{
			get;
		}

		IstHugeArrayOfPrimitive hugeArrayOfPrimitive
		{
			get;
		}

		IstHugeStructureOfComplex hugeStructureOfComplex
		{
			get;
		}

		IstHugeStructureOfPrimitive hugeStructureOfPrimitive
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		HansPlc.PlainprgPerf CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(HansPlc.PlainprgPerf source);
		void FlushOnlineToPlain(HansPlc.PlainprgPerf source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowprgPerf : Vortex.Connector.IVortexShadowObject
	{
		IShadowstHugeArrayOfComplex hugeArrayOfComplex
		{
			get;
		}

		IShadowstHugeArrayOfPrimitive hugeArrayOfPrimitive
		{
			get;
		}

		IShadowstHugeStructureOfComplex hugeStructureOfComplex
		{
			get;
		}

		IShadowstHugeStructureOfPrimitive hugeStructureOfPrimitive
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		HansPlc.PlainprgPerf CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(HansPlc.PlainprgPerf source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainprgPerf : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		PlainstHugeArrayOfComplex _hugeArrayOfComplex;
		public PlainstHugeArrayOfComplex hugeArrayOfComplex
		{
			get
			{
				return _hugeArrayOfComplex;
			}

			set
			{
				if (_hugeArrayOfComplex != value)
				{
					_hugeArrayOfComplex = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(hugeArrayOfComplex)));
				}
			}
		}

		PlainstHugeArrayOfPrimitive _hugeArrayOfPrimitive;
		public PlainstHugeArrayOfPrimitive hugeArrayOfPrimitive
		{
			get
			{
				return _hugeArrayOfPrimitive;
			}

			set
			{
				if (_hugeArrayOfPrimitive != value)
				{
					_hugeArrayOfPrimitive = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(hugeArrayOfPrimitive)));
				}
			}
		}

		PlainstHugeStructureOfComplex _hugeStructureOfComplex;
		public PlainstHugeStructureOfComplex hugeStructureOfComplex
		{
			get
			{
				return _hugeStructureOfComplex;
			}

			set
			{
				if (_hugeStructureOfComplex != value)
				{
					_hugeStructureOfComplex = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(hugeStructureOfComplex)));
				}
			}
		}

		PlainstHugeStructureOfPrimitive _hugeStructureOfPrimitive;
		public PlainstHugeStructureOfPrimitive hugeStructureOfPrimitive
		{
			get
			{
				return _hugeStructureOfPrimitive;
			}

			set
			{
				if (_hugeStructureOfPrimitive != value)
				{
					_hugeStructureOfPrimitive = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(hugeStructureOfPrimitive)));
				}
			}
		}

		public void CopyPlainToCyclic(HansPlc.prgPerf target)
		{
			hugeArrayOfComplex.CopyPlainToCyclic(target.hugeArrayOfComplex);
			hugeArrayOfPrimitive.CopyPlainToCyclic(target.hugeArrayOfPrimitive);
			hugeStructureOfComplex.CopyPlainToCyclic(target.hugeStructureOfComplex);
			hugeStructureOfPrimitive.CopyPlainToCyclic(target.hugeStructureOfPrimitive);
		}

		public void CopyPlainToCyclic(HansPlc.IprgPerf target)
		{
			this.CopyPlainToCyclic((HansPlc.prgPerf)target);
		}

		public void CopyPlainToShadow(HansPlc.prgPerf target)
		{
			hugeArrayOfComplex.CopyPlainToShadow(target.hugeArrayOfComplex);
			hugeArrayOfPrimitive.CopyPlainToShadow(target.hugeArrayOfPrimitive);
			hugeStructureOfComplex.CopyPlainToShadow(target.hugeStructureOfComplex);
			hugeStructureOfPrimitive.CopyPlainToShadow(target.hugeStructureOfPrimitive);
		}

		public void CopyPlainToShadow(HansPlc.IShadowprgPerf target)
		{
			this.CopyPlainToShadow((HansPlc.prgPerf)target);
		}

		public void CopyCyclicToPlain(HansPlc.prgPerf source)
		{
			hugeArrayOfComplex.CopyCyclicToPlain(source.hugeArrayOfComplex);
			hugeArrayOfPrimitive.CopyCyclicToPlain(source.hugeArrayOfPrimitive);
			hugeStructureOfComplex.CopyCyclicToPlain(source.hugeStructureOfComplex);
			hugeStructureOfPrimitive.CopyCyclicToPlain(source.hugeStructureOfPrimitive);
		}

		public void CopyCyclicToPlain(HansPlc.IprgPerf source)
		{
			this.CopyCyclicToPlain((HansPlc.prgPerf)source);
		}

		public void CopyShadowToPlain(HansPlc.prgPerf source)
		{
			hugeArrayOfComplex.CopyShadowToPlain(source.hugeArrayOfComplex);
			hugeArrayOfPrimitive.CopyShadowToPlain(source.hugeArrayOfPrimitive);
			hugeStructureOfComplex.CopyShadowToPlain(source.hugeStructureOfComplex);
			hugeStructureOfPrimitive.CopyShadowToPlain(source.hugeStructureOfPrimitive);
		}

		public void CopyShadowToPlain(HansPlc.IShadowprgPerf source)
		{
			this.CopyShadowToPlain((HansPlc.prgPerf)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainprgPerf()
		{
			_hugeArrayOfComplex = new PlainstHugeArrayOfComplex();
			_hugeArrayOfPrimitive = new PlainstHugeArrayOfPrimitive();
			_hugeStructureOfComplex = new PlainstHugeStructureOfComplex();
			_hugeStructureOfPrimitive = new PlainstHugeStructureOfPrimitive();
		}
	}
}