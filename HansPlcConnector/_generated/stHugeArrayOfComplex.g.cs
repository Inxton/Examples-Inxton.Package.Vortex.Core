using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace HansPlc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "stHugeArrayOfComplex", "HansPlc", TypeComplexityEnum.Complex)]
	public partial class stHugeArrayOfComplex : Vortex.Connector.IVortexObject, IstHugeArrayOfComplex, IShadowstHugeArrayOfComplex, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		public stComplex[] arr_of_complex
		{
			get;
			set;
		}

		IstComplex[] IstHugeArrayOfComplex.arr_of_complex
		{
			get
			{
				return arr_of_complex;
			}

			set
			{
				arr_of_complex = (stComplex[])value;
			}
		}

		IShadowstComplex[] IShadowstHugeArrayOfComplex.arr_of_complex
		{
			get
			{
				return arr_of_complex;
			}
		}

		public void LazyOnlineToShadow()
		{
			Vortex.Connector.BuilderHelpers.Arrays.CopyCyclicToShadowComplex<stComplex>(arr_of_complex);
		}

		public void LazyShadowToOnline()
		{
			Vortex.Connector.BuilderHelpers.Arrays.CopyShadowToCyclicComplex<stComplex>(arr_of_complex);
		}

		public PlainstHugeArrayOfComplex CreatePlainerType()
		{
			var cloned = new PlainstHugeArrayOfComplex();
			cloned.arr_of_complex = new PlainstComplex[1000];
			Vortex.Connector.BuilderHelpers.Arrays.CreatePlainerType<PlainstComplex>(cloned.arr_of_complex);
			return cloned;
		}

		protected PlainstHugeArrayOfComplex CreatePlainerType(PlainstHugeArrayOfComplex cloned)
		{
			cloned.arr_of_complex = new PlainstComplex[1000];
			Vortex.Connector.BuilderHelpers.Arrays.CreatePlainerType<PlainstComplex>(cloned.arr_of_complex);
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

		public void FlushPlainToOnline(HansPlc.PlainstHugeArrayOfComplex source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(HansPlc.PlainstHugeArrayOfComplex source)
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

		public void FlushOnlineToPlain(HansPlc.PlainstHugeArrayOfComplex source)
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

		public stHugeArrayOfComplex(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			arr_of_complex = new stComplex[1000];
			Vortex.Connector.BuilderHelpers.Arrays.InstantiateArray(arr_of_complex, this, "", "arr_of_complex", (p, rt, st) => new stComplex(p, rt, st));
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public stHugeArrayOfComplex()
		{
			PexPreConstructorParameterless();
			arr_of_complex = new stComplex[1000];
			Vortex.Connector.BuilderHelpers.Arrays.InstantiateArray(arr_of_complex, () => new stComplex());
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcstHugeArrayOfComplex
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcstHugeArrayOfComplex()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IstHugeArrayOfComplex : Vortex.Connector.IVortexOnlineObject
	{
		IstComplex[] arr_of_complex
		{
			get;
			set;
		}

		System.String AttributeName
		{
			get;
		}

		HansPlc.PlainstHugeArrayOfComplex CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(HansPlc.PlainstHugeArrayOfComplex source);
		void FlushOnlineToPlain(HansPlc.PlainstHugeArrayOfComplex source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowstHugeArrayOfComplex : Vortex.Connector.IVortexShadowObject
	{
		IShadowstComplex[] arr_of_complex
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		HansPlc.PlainstHugeArrayOfComplex CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(HansPlc.PlainstHugeArrayOfComplex source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainstHugeArrayOfComplex : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		public PlainstComplex[] arr_of_complex
		{
			get;
			set;
		}

		public void CopyPlainToCyclic(HansPlc.stHugeArrayOfComplex target)
		{
			Vortex.Connector.BuilderHelpers.Arrays.CopyPlainToOnline<PlainstComplex, stComplex>(arr_of_complex, target.arr_of_complex);
		}

		public void CopyPlainToCyclic(HansPlc.IstHugeArrayOfComplex target)
		{
			this.CopyPlainToCyclic((HansPlc.stHugeArrayOfComplex)target);
		}

		public void CopyPlainToShadow(HansPlc.stHugeArrayOfComplex target)
		{
			Vortex.Connector.BuilderHelpers.Arrays.CopyPlainToShadow<PlainstComplex, stComplex>(arr_of_complex, target.arr_of_complex);
		}

		public void CopyPlainToShadow(HansPlc.IShadowstHugeArrayOfComplex target)
		{
			this.CopyPlainToShadow((HansPlc.stHugeArrayOfComplex)target);
		}

		public void CopyCyclicToPlain(HansPlc.stHugeArrayOfComplex source)
		{
			Vortex.Connector.BuilderHelpers.Arrays.CopyOnlineToPlain<stComplex, PlainstComplex>(source.arr_of_complex, arr_of_complex);
		}

		public void CopyCyclicToPlain(HansPlc.IstHugeArrayOfComplex source)
		{
			this.CopyCyclicToPlain((HansPlc.stHugeArrayOfComplex)source);
		}

		public void CopyShadowToPlain(HansPlc.stHugeArrayOfComplex source)
		{
			Vortex.Connector.BuilderHelpers.Arrays.CopyShadowToPlain<stComplex, PlainstComplex>(source.arr_of_complex, arr_of_complex);
		}

		public void CopyShadowToPlain(HansPlc.IShadowstHugeArrayOfComplex source)
		{
			this.CopyShadowToPlain((HansPlc.stHugeArrayOfComplex)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainstHugeArrayOfComplex()
		{
			arr_of_complex = new PlainstComplex[1000];
			Vortex.Connector.BuilderHelpers.Arrays.InstantiatePlainerType<PlainstComplex>(arr_of_complex);
		}
	}
}