using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace HansPlc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "fbDrive", "HansPlc", TypeComplexityEnum.Complex)]
	public partial class fbDrive : Vortex.Connector.IVortexObject, IfbDrive, IShadowfbDrive, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerLReal _Position;
		public Vortex.Connector.ValueTypes.OnlinerLReal Position
		{
			get
			{
				return _Position;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineLReal IfbDrive.Position
		{
			get
			{
				return Position;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowLReal IShadowfbDrive.Position
		{
			get
			{
				return Position;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerLReal _Speed;
		public Vortex.Connector.ValueTypes.OnlinerLReal Speed
		{
			get
			{
				return _Speed;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineLReal IfbDrive.Speed
		{
			get
			{
				return Speed;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowLReal IShadowfbDrive.Speed
		{
			get
			{
				return Speed;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal _Acc;
		public Vortex.Connector.ValueTypes.OnlinerReal Acc
		{
			get
			{
				return _Acc;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IfbDrive.Acc
		{
			get
			{
				return Acc;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowfbDrive.Acc
		{
			get
			{
				return Acc;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal _Dcc;
		public Vortex.Connector.ValueTypes.OnlinerReal Dcc
		{
			get
			{
				return _Dcc;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IfbDrive.Dcc
		{
			get
			{
				return Dcc;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowfbDrive.Dcc
		{
			get
			{
				return Dcc;
			}
		}

		public void LazyOnlineToShadow()
		{
			Position.Shadow = Position.LastValue;
			Speed.Shadow = Speed.LastValue;
			Acc.Shadow = Acc.LastValue;
			Dcc.Shadow = Dcc.LastValue;
		}

		public void LazyShadowToOnline()
		{
			Position.Cyclic = Position.Shadow;
			Speed.Cyclic = Speed.Shadow;
			Acc.Cyclic = Acc.Shadow;
			Dcc.Cyclic = Dcc.Shadow;
		}

		public PlainfbDrive CreatePlainerType()
		{
			var cloned = new PlainfbDrive();
			return cloned;
		}

		protected PlainfbDrive CreatePlainerType(PlainfbDrive cloned)
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

		public void FlushPlainToOnline(HansPlc.PlainfbDrive source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(HansPlc.PlainfbDrive source)
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

		public void FlushOnlineToPlain(HansPlc.PlainfbDrive source)
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

		public fbDrive(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			_Position = @Connector.Online.Adapter.CreateLREAL(this, "Position", "Position");
			Position.AttributeName = "Position";
			Position.AttributeUnits = "nm";
			_Speed = @Connector.Online.Adapter.CreateLREAL(this, "Speed", "Speed");
			Speed.AttributeName = "Speed";
			Speed.AttributeUnits = "mm/s";
			_Acc = @Connector.Online.Adapter.CreateREAL(this, "Acceleration", "Acc");
			Acc.AttributeName = "Acceleration";
			Acc.AttributeUnits = "mm/s^2";
			_Dcc = @Connector.Online.Adapter.CreateREAL(this, "Deceleration", "Dcc");
			Dcc.AttributeName = "Deceleration";
			Dcc.AttributeUnits = "mm/s^2";
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public fbDrive()
		{
			PexPreConstructorParameterless();
			_Position = Vortex.Connector.IConnectorFactory.CreateLREAL();
			Position.AttributeName = "Position";
			Position.AttributeUnits = "nm";
			_Speed = Vortex.Connector.IConnectorFactory.CreateLREAL();
			Speed.AttributeName = "Speed";
			Speed.AttributeUnits = "mm/s";
			_Acc = Vortex.Connector.IConnectorFactory.CreateREAL();
			Acc.AttributeName = "Acceleration";
			Acc.AttributeUnits = "mm/s^2";
			_Dcc = Vortex.Connector.IConnectorFactory.CreateREAL();
			Dcc.AttributeName = "Deceleration";
			Dcc.AttributeUnits = "mm/s^2";
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcfbDrive
		{
			public object Position;
			public object Speed;
			public object Acc;
			public object Dcc;
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcfbDrive()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IfbDrive : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineLReal Position
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineLReal Speed
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal Acc
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal Dcc
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		HansPlc.PlainfbDrive CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(HansPlc.PlainfbDrive source);
		void FlushOnlineToPlain(HansPlc.PlainfbDrive source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowfbDrive : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowLReal Position
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowLReal Speed
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal Acc
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal Dcc
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		HansPlc.PlainfbDrive CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(HansPlc.PlainfbDrive source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainfbDrive : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		System.Double _Position;
		public System.Double Position
		{
			get
			{
				return _Position;
			}

			set
			{
				if (_Position != value)
				{
					_Position = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Position)));
				}
			}
		}

		System.Double _Speed;
		public System.Double Speed
		{
			get
			{
				return _Speed;
			}

			set
			{
				if (_Speed != value)
				{
					_Speed = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Speed)));
				}
			}
		}

		System.Single _Acc;
		public System.Single Acc
		{
			get
			{
				return _Acc;
			}

			set
			{
				if (_Acc != value)
				{
					_Acc = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Acc)));
				}
			}
		}

		System.Single _Dcc;
		public System.Single Dcc
		{
			get
			{
				return _Dcc;
			}

			set
			{
				if (_Dcc != value)
				{
					_Dcc = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Dcc)));
				}
			}
		}

		public void CopyPlainToCyclic(HansPlc.fbDrive target)
		{
			target.Position.Cyclic = Position;
			target.Speed.Cyclic = Speed;
			target.Acc.Cyclic = Acc;
			target.Dcc.Cyclic = Dcc;
		}

		public void CopyPlainToCyclic(HansPlc.IfbDrive target)
		{
			this.CopyPlainToCyclic((HansPlc.fbDrive)target);
		}

		public void CopyPlainToShadow(HansPlc.fbDrive target)
		{
			target.Position.Shadow = Position;
			target.Speed.Shadow = Speed;
			target.Acc.Shadow = Acc;
			target.Dcc.Shadow = Dcc;
		}

		public void CopyPlainToShadow(HansPlc.IShadowfbDrive target)
		{
			this.CopyPlainToShadow((HansPlc.fbDrive)target);
		}

		public void CopyCyclicToPlain(HansPlc.fbDrive source)
		{
			Position = source.Position.LastValue;
			Speed = source.Speed.LastValue;
			Acc = source.Acc.LastValue;
			Dcc = source.Dcc.LastValue;
		}

		public void CopyCyclicToPlain(HansPlc.IfbDrive source)
		{
			this.CopyCyclicToPlain((HansPlc.fbDrive)source);
		}

		public void CopyShadowToPlain(HansPlc.fbDrive source)
		{
			Position = source.Position.Shadow;
			Speed = source.Speed.Shadow;
			Acc = source.Acc.Shadow;
			Dcc = source.Dcc.Shadow;
		}

		public void CopyShadowToPlain(HansPlc.IShadowfbDrive source)
		{
			this.CopyShadowToPlain((HansPlc.fbDrive)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainfbDrive()
		{
		}
	}
}