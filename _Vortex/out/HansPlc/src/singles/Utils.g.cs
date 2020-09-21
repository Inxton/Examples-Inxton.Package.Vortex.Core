using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace HansPlc
{
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "Utils", "HansPlc", TypeComplexityEnum.Complex)]
	public partial class Utils : Vortex.Connector.IVortexObject, IUtils, IShadowUtils, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		fbFluentString _FluentString;
		public fbFluentString FluentString
		{
			get
			{
				return _FluentString;
			}
		}

		IfbFluentString IUtils.FluentString
		{
			get
			{
				return FluentString;
			}
		}

		IShadowfbFluentString IShadowUtils.FluentString
		{
			get
			{
				return FluentString;
			}
		}

		public void LazyOnlineToShadow()
		{
			FluentString.LazyOnlineToShadow();
		}

		public void LazyShadowToOnline()
		{
			FluentString.LazyShadowToOnline();
		}

		public PlainUtils CreatePlainerType()
		{
			var cloned = new PlainUtils();
			cloned.FluentString = FluentString.CreatePlainerType();
			return cloned;
		}

		protected PlainUtils CreatePlainerType(PlainUtils cloned)
		{
			cloned.FluentString = FluentString.CreatePlainerType();
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

		public void FlushPlainToOnline(HansPlc.PlainUtils source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(HansPlc.PlainUtils source)
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

		public void FlushOnlineToPlain(HansPlc.PlainUtils source)
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

		public Utils(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_FluentString = new fbFluentString(this, "", "FluentString");
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public Utils()
		{
			PexPreConstructorParameterless();
			_FluentString = new fbFluentString();
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcUtils
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcUtils()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IUtils : Vortex.Connector.IVortexOnlineObject
	{
		IfbFluentString FluentString
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		HansPlc.PlainUtils CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(HansPlc.PlainUtils source);
		void FlushOnlineToPlain(HansPlc.PlainUtils source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowUtils : Vortex.Connector.IVortexShadowObject
	{
		IShadowfbFluentString FluentString
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		HansPlc.PlainUtils CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(HansPlc.PlainUtils source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainUtils : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		PlainfbFluentString _FluentString;
		public PlainfbFluentString FluentString
		{
			get
			{
				return _FluentString;
			}

			set
			{
				if (_FluentString != value)
				{
					_FluentString = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(FluentString)));
				}
			}
		}

		public void CopyPlainToCyclic(HansPlc.Utils target)
		{
			FluentString.CopyPlainToCyclic(target.FluentString);
		}

		public void CopyPlainToCyclic(HansPlc.IUtils target)
		{
			this.CopyPlainToCyclic((HansPlc.Utils)target);
		}

		public void CopyPlainToShadow(HansPlc.Utils target)
		{
			FluentString.CopyPlainToShadow(target.FluentString);
		}

		public void CopyPlainToShadow(HansPlc.IShadowUtils target)
		{
			this.CopyPlainToShadow((HansPlc.Utils)target);
		}

		public void CopyCyclicToPlain(HansPlc.Utils source)
		{
			FluentString.CopyCyclicToPlain(source.FluentString);
		}

		public void CopyCyclicToPlain(HansPlc.IUtils source)
		{
			this.CopyCyclicToPlain((HansPlc.Utils)source);
		}

		public void CopyShadowToPlain(HansPlc.Utils source)
		{
			FluentString.CopyShadowToPlain(source.FluentString);
		}

		public void CopyShadowToPlain(HansPlc.IShadowUtils source)
		{
			this.CopyShadowToPlain((HansPlc.Utils)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainUtils()
		{
			_FluentString = new PlainfbFluentString();
		}
	}
}