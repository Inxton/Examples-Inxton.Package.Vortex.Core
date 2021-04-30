using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace HansPlc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "prgSimple", "HansPlc", TypeComplexityEnum.Complex)]
	public partial class prgSimple : Vortex.Connector.IVortexObject, IprgSimple, IShadowprgSimple, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerULInt __counter;
		public Vortex.Connector.ValueTypes.OnlinerULInt _counter
		{
			get
			{
				return __counter;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineULInt IprgSimple._counter
		{
			get
			{
				return _counter;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowULInt IShadowprgSimple._counter
		{
			get
			{
				return _counter;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool __counterActive;
		public Vortex.Connector.ValueTypes.OnlinerBool _counterActive
		{
			get
			{
				return __counterActive;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IprgSimple._counterActive
		{
			get
			{
				return _counterActive;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowprgSimple._counterActive
		{
			get
			{
				return _counterActive;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerBool __reset;
		public Vortex.Connector.ValueTypes.OnlinerBool _reset
		{
			get
			{
				return __reset;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IprgSimple._reset
		{
			get
			{
				return _reset;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowprgSimple._reset
		{
			get
			{
				return _reset;
			}
		}

		public void LazyOnlineToShadow()
		{
			_counter.Shadow = _counter.LastValue;
			_counterActive.Shadow = _counterActive.LastValue;
			_reset.Shadow = _reset.LastValue;
		}

		public void LazyShadowToOnline()
		{
			_counter.Cyclic = _counter.Shadow;
			_counterActive.Cyclic = _counterActive.Shadow;
			_reset.Cyclic = _reset.Shadow;
		}

		public PlainprgSimple CreatePlainerType()
		{
			var cloned = new PlainprgSimple();
			return cloned;
		}

		protected PlainprgSimple CreatePlainerType(PlainprgSimple cloned)
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

		public void FlushPlainToOnline(HansPlc.PlainprgSimple source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(HansPlc.PlainprgSimple source)
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

		public void FlushOnlineToPlain(HansPlc.PlainprgSimple source)
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

		public prgSimple(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			__counter = @Connector.Online.Adapter.CreateULINT(this, "", "_counter");
			__counterActive = @Connector.Online.Adapter.CreateBOOL(this, "", "_counterActive");
			__reset = @Connector.Online.Adapter.CreateBOOL(this, "", "_reset");
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public prgSimple()
		{
			PexPreConstructorParameterless();
			__counter = Vortex.Connector.IConnectorFactory.CreateULINT();
			__counterActive = Vortex.Connector.IConnectorFactory.CreateBOOL();
			__reset = Vortex.Connector.IConnectorFactory.CreateBOOL();
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcprgSimple
		{
			public object _counter;
			public object _counterActive;
			public object _reset;
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcprgSimple()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IprgSimple : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineULInt _counter
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool _counterActive
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool _reset
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		HansPlc.PlainprgSimple CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(HansPlc.PlainprgSimple source);
		void FlushOnlineToPlain(HansPlc.PlainprgSimple source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowprgSimple : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowULInt _counter
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool _counterActive
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool _reset
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		HansPlc.PlainprgSimple CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(HansPlc.PlainprgSimple source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainprgSimple : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		System.UInt64 __counter;
		public System.UInt64 _counter
		{
			get
			{
				return __counter;
			}

			set
			{
				if (__counter != value)
				{
					__counter = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_counter)));
				}
			}
		}

		System.Boolean __counterActive;
		public System.Boolean _counterActive
		{
			get
			{
				return __counterActive;
			}

			set
			{
				if (__counterActive != value)
				{
					__counterActive = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_counterActive)));
				}
			}
		}

		System.Boolean __reset;
		public System.Boolean _reset
		{
			get
			{
				return __reset;
			}

			set
			{
				if (__reset != value)
				{
					__reset = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_reset)));
				}
			}
		}

		public void CopyPlainToCyclic(HansPlc.prgSimple target)
		{
			target._counter.Cyclic = _counter;
			target._counterActive.Cyclic = _counterActive;
			target._reset.Cyclic = _reset;
		}

		public void CopyPlainToCyclic(HansPlc.IprgSimple target)
		{
			this.CopyPlainToCyclic((HansPlc.prgSimple)target);
		}

		public void CopyPlainToShadow(HansPlc.prgSimple target)
		{
			target._counter.Shadow = _counter;
			target._counterActive.Shadow = _counterActive;
			target._reset.Shadow = _reset;
		}

		public void CopyPlainToShadow(HansPlc.IShadowprgSimple target)
		{
			this.CopyPlainToShadow((HansPlc.prgSimple)target);
		}

		public void CopyCyclicToPlain(HansPlc.prgSimple source)
		{
			_counter = source._counter.LastValue;
			_counterActive = source._counterActive.LastValue;
			_reset = source._reset.LastValue;
		}

		public void CopyCyclicToPlain(HansPlc.IprgSimple source)
		{
			this.CopyCyclicToPlain((HansPlc.prgSimple)source);
		}

		public void CopyShadowToPlain(HansPlc.prgSimple source)
		{
			_counter = source._counter.Shadow;
			_counterActive = source._counterActive.Shadow;
			_reset = source._reset.Shadow;
		}

		public void CopyShadowToPlain(HansPlc.IShadowprgSimple source)
		{
			this.CopyShadowToPlain((HansPlc.prgSimple)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainprgSimple()
		{
		}
	}
}