using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace HansPlc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "fbFluentString", "HansPlc", TypeComplexityEnum.Complex)]
	public partial class fbFluentString : Vortex.Connector.IVortexObject, IfbFluentString, IShadowfbFluentString, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerString __resultString;
		public Vortex.Connector.ValueTypes.OnlinerString _resultString
		{
			get
			{
				return __resultString;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IfbFluentString._resultString
		{
			get
			{
				return _resultString;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowfbFluentString._resultString
		{
			get
			{
				return _resultString;
			}
		}

		public void LazyOnlineToShadow()
		{
			_resultString.Shadow = _resultString.LastValue;
		}

		public void LazyShadowToOnline()
		{
			_resultString.Cyclic = _resultString.Shadow;
		}

		public PlainfbFluentString CreatePlainerType()
		{
			var cloned = new PlainfbFluentString();
			return cloned;
		}

		protected PlainfbFluentString CreatePlainerType(PlainfbFluentString cloned)
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

		public void FlushPlainToOnline(HansPlc.PlainfbFluentString source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(HansPlc.PlainfbFluentString source)
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

		public void FlushOnlineToPlain(HansPlc.PlainfbFluentString source)
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

		public fbFluentString(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			__resultString = @Connector.Online.Adapter.CreateSTRING(this, "", "_resultString");
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public fbFluentString()
		{
			PexPreConstructorParameterless();
			__resultString = Vortex.Connector.IConnectorFactory.CreateSTRING();
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcfbFluentString
		{
			public object _resultString;
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcfbFluentString()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IfbFluentString : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineString _resultString
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		HansPlc.PlainfbFluentString CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(HansPlc.PlainfbFluentString source);
		void FlushOnlineToPlain(HansPlc.PlainfbFluentString source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowfbFluentString : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowString _resultString
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		HansPlc.PlainfbFluentString CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(HansPlc.PlainfbFluentString source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainfbFluentString : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		System.String __resultString;
		public System.String _resultString
		{
			get
			{
				return __resultString;
			}

			set
			{
				if (__resultString != value)
				{
					__resultString = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_resultString)));
				}
			}
		}

		public void CopyPlainToCyclic(HansPlc.fbFluentString target)
		{
			target._resultString.Cyclic = _resultString;
		}

		public void CopyPlainToCyclic(HansPlc.IfbFluentString target)
		{
			this.CopyPlainToCyclic((HansPlc.fbFluentString)target);
		}

		public void CopyPlainToShadow(HansPlc.fbFluentString target)
		{
			target._resultString.Shadow = _resultString;
		}

		public void CopyPlainToShadow(HansPlc.IShadowfbFluentString target)
		{
			this.CopyPlainToShadow((HansPlc.fbFluentString)target);
		}

		public void CopyCyclicToPlain(HansPlc.fbFluentString source)
		{
			_resultString = source._resultString.LastValue;
		}

		public void CopyCyclicToPlain(HansPlc.IfbFluentString source)
		{
			this.CopyCyclicToPlain((HansPlc.fbFluentString)source);
		}

		public void CopyShadowToPlain(HansPlc.fbFluentString source)
		{
			_resultString = source._resultString.Shadow;
		}

		public void CopyShadowToPlain(HansPlc.IShadowfbFluentString source)
		{
			this.CopyShadowToPlain((HansPlc.fbFluentString)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainfbFluentString()
		{
		}
	}
}