using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace HansPlc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "stHugeArrayOfPrimitive", "HansPlc", TypeComplexityEnum.Complex)]
	public partial class stHugeArrayOfPrimitive : Vortex.Connector.IVortexObject, IstHugeArrayOfPrimitive, IShadowstHugeArrayOfPrimitive, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		public Vortex.Connector.ValueTypes.OnlinerByte[] arr_of_primitive
		{
			get;
			set;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineByte[] IstHugeArrayOfPrimitive.arr_of_primitive
		{
			get
			{
				return arr_of_primitive;
			}

			set
			{
				arr_of_primitive = (Vortex.Connector.ValueTypes.OnlinerByte[])value;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowByte[] IShadowstHugeArrayOfPrimitive.arr_of_primitive
		{
			get
			{
				return arr_of_primitive;
			}
		}

		public void LazyOnlineToShadow()
		{
			Vortex.Connector.BuilderHelpers.Arrays.CopyCyclicToShadowPrimitive<Vortex.Connector.ValueTypes.OnlinerByte>(arr_of_primitive);
		}

		public void LazyShadowToOnline()
		{
			Vortex.Connector.BuilderHelpers.Arrays.CopyShadowToCyclicPrimitive<Vortex.Connector.ValueTypes.OnlinerByte>(arr_of_primitive);
		}

		public PlainstHugeArrayOfPrimitive CreatePlainerType()
		{
			var cloned = new PlainstHugeArrayOfPrimitive();
			cloned.arr_of_primitive = new System.Byte[1024];
			return cloned;
		}

		protected PlainstHugeArrayOfPrimitive CreatePlainerType(PlainstHugeArrayOfPrimitive cloned)
		{
			cloned.arr_of_primitive = new System.Byte[1024];
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

		public void FlushPlainToOnline(HansPlc.PlainstHugeArrayOfPrimitive source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(HansPlc.PlainstHugeArrayOfPrimitive source)
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

		public void FlushOnlineToPlain(HansPlc.PlainstHugeArrayOfPrimitive source)
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

		public stHugeArrayOfPrimitive(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			arr_of_primitive = new Vortex.Connector.ValueTypes.OnlinerByte[1024];
			Vortex.Connector.BuilderHelpers.Arrays.InstantiateArray(arr_of_primitive, this, "", "arr_of_primitive", (p, rt, st) => @Connector.Online.Adapter.CreateBYTE(p, rt, st));
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public stHugeArrayOfPrimitive()
		{
			PexPreConstructorParameterless();
			arr_of_primitive = new Vortex.Connector.ValueTypes.OnlinerByte[1024];
			Vortex.Connector.BuilderHelpers.Arrays.InstantiateArray(arr_of_primitive, () => Vortex.Connector.IConnectorFactory.CreateBYTE());
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcstHugeArrayOfPrimitive
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcstHugeArrayOfPrimitive()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IstHugeArrayOfPrimitive : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineByte[] arr_of_primitive
		{
			get;
			set;
		}

		System.String AttributeName
		{
			get;
		}

		HansPlc.PlainstHugeArrayOfPrimitive CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(HansPlc.PlainstHugeArrayOfPrimitive source);
		void FlushOnlineToPlain(HansPlc.PlainstHugeArrayOfPrimitive source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowstHugeArrayOfPrimitive : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowByte[] arr_of_primitive
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		HansPlc.PlainstHugeArrayOfPrimitive CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(HansPlc.PlainstHugeArrayOfPrimitive source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainstHugeArrayOfPrimitive : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		public System.Byte[] arr_of_primitive
		{
			get;
			set;
		}

		public void CopyPlainToCyclic(HansPlc.stHugeArrayOfPrimitive target)
		{
			Vortex.Connector.BuilderHelpers.Arrays.CopyPlainToOnline<System.Byte, Vortex.Connector.ValueTypes.OnlinerByte>(arr_of_primitive, target.arr_of_primitive);
		}

		public void CopyPlainToCyclic(HansPlc.IstHugeArrayOfPrimitive target)
		{
			this.CopyPlainToCyclic((HansPlc.stHugeArrayOfPrimitive)target);
		}

		public void CopyPlainToShadow(HansPlc.stHugeArrayOfPrimitive target)
		{
			Vortex.Connector.BuilderHelpers.Arrays.CopyPlainToShadow<System.Byte, Vortex.Connector.ValueTypes.OnlinerByte>(arr_of_primitive, target.arr_of_primitive);
		}

		public void CopyPlainToShadow(HansPlc.IShadowstHugeArrayOfPrimitive target)
		{
			this.CopyPlainToShadow((HansPlc.stHugeArrayOfPrimitive)target);
		}

		public void CopyCyclicToPlain(HansPlc.stHugeArrayOfPrimitive source)
		{
			Vortex.Connector.BuilderHelpers.Arrays.CopyOnlineToPlain<Vortex.Connector.ValueTypes.OnlinerByte, System.Byte>(source.arr_of_primitive, arr_of_primitive);
		}

		public void CopyCyclicToPlain(HansPlc.IstHugeArrayOfPrimitive source)
		{
			this.CopyCyclicToPlain((HansPlc.stHugeArrayOfPrimitive)source);
		}

		public void CopyShadowToPlain(HansPlc.stHugeArrayOfPrimitive source)
		{
			Vortex.Connector.BuilderHelpers.Arrays.CopyShadowToPlain<Vortex.Connector.ValueTypes.OnlinerByte, System.Byte>(source.arr_of_primitive, arr_of_primitive);
		}

		public void CopyShadowToPlain(HansPlc.IShadowstHugeArrayOfPrimitive source)
		{
			this.CopyShadowToPlain((HansPlc.stHugeArrayOfPrimitive)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainstHugeArrayOfPrimitive()
		{
			arr_of_primitive = new System.Byte[1024];
		}
	}
}