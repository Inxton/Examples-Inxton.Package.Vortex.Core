using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace HansPlc
{
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "prgAddedProperties", "HansPlc", TypeComplexityEnum.Complex)]
	public partial class prgAddedProperties : Vortex.Connector.IVortexObject, IprgAddedProperties, IShadowprgAddedProperties, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		fbDrive _fbDriveX;
		public fbDrive fbDriveX
		{
			get
			{
				return _fbDriveX;
			}
		}

		IfbDrive IprgAddedProperties.fbDriveX
		{
			get
			{
				return fbDriveX;
			}
		}

		IShadowfbDrive IShadowprgAddedProperties.fbDriveX
		{
			get
			{
				return fbDriveX;
			}
		}

		fbDrive _fbDriveY;
		public fbDrive fbDriveY
		{
			get
			{
				return _fbDriveY;
			}
		}

		IfbDrive IprgAddedProperties.fbDriveY
		{
			get
			{
				return fbDriveY;
			}
		}

		IShadowfbDrive IShadowprgAddedProperties.fbDriveY
		{
			get
			{
				return fbDriveY;
			}
		}

		fbDrive _fbDriveZ;
		public fbDrive fbDriveZ
		{
			get
			{
				return _fbDriveZ;
			}
		}

		IfbDrive IprgAddedProperties.fbDriveZ
		{
			get
			{
				return fbDriveZ;
			}
		}

		IShadowfbDrive IShadowprgAddedProperties.fbDriveZ
		{
			get
			{
				return fbDriveZ;
			}
		}

		public void LazyOnlineToShadow()
		{
			fbDriveX.LazyOnlineToShadow();
			fbDriveY.LazyOnlineToShadow();
			fbDriveZ.LazyOnlineToShadow();
		}

		public void LazyShadowToOnline()
		{
			fbDriveX.LazyShadowToOnline();
			fbDriveY.LazyShadowToOnline();
			fbDriveZ.LazyShadowToOnline();
		}

		public PlainprgAddedProperties CreatePlainerType()
		{
			var cloned = new PlainprgAddedProperties();
			cloned.fbDriveX = fbDriveX.CreatePlainerType();
			cloned.fbDriveY = fbDriveY.CreatePlainerType();
			cloned.fbDriveZ = fbDriveZ.CreatePlainerType();
			return cloned;
		}

		protected PlainprgAddedProperties CreatePlainerType(PlainprgAddedProperties cloned)
		{
			cloned.fbDriveX = fbDriveX.CreatePlainerType();
			cloned.fbDriveY = fbDriveY.CreatePlainerType();
			cloned.fbDriveZ = fbDriveZ.CreatePlainerType();
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

		public void FlushPlainToOnline(HansPlc.PlainprgAddedProperties source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(HansPlc.PlainprgAddedProperties source)
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

		public void FlushOnlineToPlain(HansPlc.PlainprgAddedProperties source)
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

		public prgAddedProperties(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
		{
			this.@SymbolTail = symbolTail;
			this.@Connector = parent.GetConnector();
			this.@ValueTags = new System.Collections.Generic.List<Vortex.Connector.IValueTag>();
			this.@Children = new System.Collections.Generic.List<Vortex.Connector.IVortexObject>();
			this.@Parent = parent;
			_humanReadable = Vortex.Connector.IConnector.CreateSymbol(parent.HumanReadable, readableTail);
			PexPreConstructor(parent, readableTail, symbolTail);
			Symbol = Vortex.Connector.IConnector.CreateSymbol(parent.Symbol, symbolTail);
			_fbDriveX = new fbDrive(this, "X", "fbDriveX");
			_fbDriveX.AttributeName = "X";
			_fbDriveY = new fbDrive(this, "Y", "fbDriveY");
			_fbDriveY.AttributeName = "Y";
			_fbDriveZ = new fbDrive(this, "Z", "fbDriveZ");
			_fbDriveZ.AttributeName = "Z";
			AttributeName = "";
			PexConstructor(parent, readableTail, symbolTail);
			parent.AddChild(this);
		}

		public prgAddedProperties()
		{
			PexPreConstructorParameterless();
			_fbDriveX = new fbDrive();
			_fbDriveX.AttributeName = "X";
			_fbDriveY = new fbDrive();
			_fbDriveY.AttributeName = "Y";
			_fbDriveZ = new fbDrive();
			_fbDriveZ.AttributeName = "Z";
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcprgAddedProperties
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcprgAddedProperties()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IprgAddedProperties : Vortex.Connector.IVortexOnlineObject
	{
		IfbDrive fbDriveX
		{
			get;
		}

		IfbDrive fbDriveY
		{
			get;
		}

		IfbDrive fbDriveZ
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		HansPlc.PlainprgAddedProperties CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(HansPlc.PlainprgAddedProperties source);
		void FlushOnlineToPlain(HansPlc.PlainprgAddedProperties source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowprgAddedProperties : Vortex.Connector.IVortexShadowObject
	{
		IShadowfbDrive fbDriveX
		{
			get;
		}

		IShadowfbDrive fbDriveY
		{
			get;
		}

		IShadowfbDrive fbDriveZ
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		HansPlc.PlainprgAddedProperties CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(HansPlc.PlainprgAddedProperties source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainprgAddedProperties : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		PlainfbDrive _fbDriveX;
		public PlainfbDrive fbDriveX
		{
			get
			{
				return _fbDriveX;
			}

			set
			{
				if (_fbDriveX != value)
				{
					_fbDriveX = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(fbDriveX)));
				}
			}
		}

		PlainfbDrive _fbDriveY;
		public PlainfbDrive fbDriveY
		{
			get
			{
				return _fbDriveY;
			}

			set
			{
				if (_fbDriveY != value)
				{
					_fbDriveY = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(fbDriveY)));
				}
			}
		}

		PlainfbDrive _fbDriveZ;
		public PlainfbDrive fbDriveZ
		{
			get
			{
				return _fbDriveZ;
			}

			set
			{
				if (_fbDriveZ != value)
				{
					_fbDriveZ = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(fbDriveZ)));
				}
			}
		}

		public void CopyPlainToCyclic(HansPlc.prgAddedProperties target)
		{
			fbDriveX.CopyPlainToCyclic(target.fbDriveX);
			fbDriveY.CopyPlainToCyclic(target.fbDriveY);
			fbDriveZ.CopyPlainToCyclic(target.fbDriveZ);
		}

		public void CopyPlainToCyclic(HansPlc.IprgAddedProperties target)
		{
			this.CopyPlainToCyclic((HansPlc.prgAddedProperties)target);
		}

		public void CopyPlainToShadow(HansPlc.prgAddedProperties target)
		{
			fbDriveX.CopyPlainToShadow(target.fbDriveX);
			fbDriveY.CopyPlainToShadow(target.fbDriveY);
			fbDriveZ.CopyPlainToShadow(target.fbDriveZ);
		}

		public void CopyPlainToShadow(HansPlc.IShadowprgAddedProperties target)
		{
			this.CopyPlainToShadow((HansPlc.prgAddedProperties)target);
		}

		public void CopyCyclicToPlain(HansPlc.prgAddedProperties source)
		{
			fbDriveX.CopyCyclicToPlain(source.fbDriveX);
			fbDriveY.CopyCyclicToPlain(source.fbDriveY);
			fbDriveZ.CopyCyclicToPlain(source.fbDriveZ);
		}

		public void CopyCyclicToPlain(HansPlc.IprgAddedProperties source)
		{
			this.CopyCyclicToPlain((HansPlc.prgAddedProperties)source);
		}

		public void CopyShadowToPlain(HansPlc.prgAddedProperties source)
		{
			fbDriveX.CopyShadowToPlain(source.fbDriveX);
			fbDriveY.CopyShadowToPlain(source.fbDriveY);
			fbDriveZ.CopyShadowToPlain(source.fbDriveZ);
		}

		public void CopyShadowToPlain(HansPlc.IShadowprgAddedProperties source)
		{
			this.CopyShadowToPlain((HansPlc.prgAddedProperties)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainprgAddedProperties()
		{
			_fbDriveX = new PlainfbDrive();
			_fbDriveY = new PlainfbDrive();
			_fbDriveZ = new PlainfbDrive();
		}
	}
}