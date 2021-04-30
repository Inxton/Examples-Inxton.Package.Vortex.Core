using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace HansPlc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "stComplex", "HansPlc", TypeComplexityEnum.Complex)]
	public partial class stComplex : Vortex.Connector.IVortexObject, IstComplex, IShadowstComplex, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		Vortex.Connector.ValueTypes.OnlinerBool _BOOL_val;
		public Vortex.Connector.ValueTypes.OnlinerBool BOOL_val
		{
			get
			{
				return _BOOL_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineBool IstComplex.BOOL_val
		{
			get
			{
				return BOOL_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowBool IShadowstComplex.BOOL_val
		{
			get
			{
				return BOOL_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerByte _BYTE_val;
		public Vortex.Connector.ValueTypes.OnlinerByte BYTE_val
		{
			get
			{
				return _BYTE_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineByte IstComplex.BYTE_val
		{
			get
			{
				return BYTE_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowByte IShadowstComplex.BYTE_val
		{
			get
			{
				return BYTE_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerWord _WORD_val;
		public Vortex.Connector.ValueTypes.OnlinerWord WORD_val
		{
			get
			{
				return _WORD_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineWord IstComplex.WORD_val
		{
			get
			{
				return WORD_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowWord IShadowstComplex.WORD_val
		{
			get
			{
				return WORD_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDWord _DWORD_val;
		public Vortex.Connector.ValueTypes.OnlinerDWord DWORD_val
		{
			get
			{
				return _DWORD_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDWord IstComplex.DWORD_val
		{
			get
			{
				return DWORD_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDWord IShadowstComplex.DWORD_val
		{
			get
			{
				return DWORD_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerLWord _LWORD_val;
		public Vortex.Connector.ValueTypes.OnlinerLWord LWORD_val
		{
			get
			{
				return _LWORD_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineLWord IstComplex.LWORD_val
		{
			get
			{
				return LWORD_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowLWord IShadowstComplex.LWORD_val
		{
			get
			{
				return LWORD_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerSInt _SINT_val;
		public Vortex.Connector.ValueTypes.OnlinerSInt SINT_val
		{
			get
			{
				return _SINT_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineSInt IstComplex.SINT_val
		{
			get
			{
				return SINT_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowSInt IShadowstComplex.SINT_val
		{
			get
			{
				return SINT_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUSInt _USINT_val;
		public Vortex.Connector.ValueTypes.OnlinerUSInt USINT_val
		{
			get
			{
				return _USINT_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUSInt IstComplex.USINT_val
		{
			get
			{
				return USINT_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUSInt IShadowstComplex.USINT_val
		{
			get
			{
				return USINT_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerInt _INT_val;
		public Vortex.Connector.ValueTypes.OnlinerInt INT_val
		{
			get
			{
				return _INT_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt IstComplex.INT_val
		{
			get
			{
				return INT_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt IShadowstComplex.INT_val
		{
			get
			{
				return INT_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUInt _UINT_val;
		public Vortex.Connector.ValueTypes.OnlinerUInt UINT_val
		{
			get
			{
				return _UINT_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt IstComplex.UINT_val
		{
			get
			{
				return UINT_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt IShadowstComplex.UINT_val
		{
			get
			{
				return UINT_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDInt _DINT_val;
		public Vortex.Connector.ValueTypes.OnlinerDInt DINT_val
		{
			get
			{
				return _DINT_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDInt IstComplex.DINT_val
		{
			get
			{
				return DINT_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDInt IShadowstComplex.DINT_val
		{
			get
			{
				return DINT_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerUDInt _UDINT_val;
		public Vortex.Connector.ValueTypes.OnlinerUDInt UDINT_val
		{
			get
			{
				return _UDINT_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt IstComplex.UDINT_val
		{
			get
			{
				return UDINT_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt IShadowstComplex.UDINT_val
		{
			get
			{
				return UDINT_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerLInt _LINT_val;
		public Vortex.Connector.ValueTypes.OnlinerLInt LINT_val
		{
			get
			{
				return _LINT_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineLInt IstComplex.LINT_val
		{
			get
			{
				return LINT_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowLInt IShadowstComplex.LINT_val
		{
			get
			{
				return LINT_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerULInt _ULINT_val;
		public Vortex.Connector.ValueTypes.OnlinerULInt ULINT_val
		{
			get
			{
				return _ULINT_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineULInt IstComplex.ULINT_val
		{
			get
			{
				return ULINT_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowULInt IShadowstComplex.ULINT_val
		{
			get
			{
				return ULINT_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerReal _REAL_val;
		public Vortex.Connector.ValueTypes.OnlinerReal REAL_val
		{
			get
			{
				return _REAL_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal IstComplex.REAL_val
		{
			get
			{
				return REAL_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal IShadowstComplex.REAL_val
		{
			get
			{
				return REAL_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerLReal _LREAL_val;
		public Vortex.Connector.ValueTypes.OnlinerLReal LREAL_val
		{
			get
			{
				return _LREAL_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineLReal IstComplex.LREAL_val
		{
			get
			{
				return LREAL_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowLReal IShadowstComplex.LREAL_val
		{
			get
			{
				return LREAL_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerString _STRING_val;
		public Vortex.Connector.ValueTypes.OnlinerString STRING_val
		{
			get
			{
				return _STRING_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString IstComplex.STRING_val
		{
			get
			{
				return STRING_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString IShadowstComplex.STRING_val
		{
			get
			{
				return STRING_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerWString _WSTRING_val;
		public Vortex.Connector.ValueTypes.OnlinerWString WSTRING_val
		{
			get
			{
				return _WSTRING_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineWString IstComplex.WSTRING_val
		{
			get
			{
				return WSTRING_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowWString IShadowstComplex.WSTRING_val
		{
			get
			{
				return WSTRING_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerTime _TIME_val;
		public Vortex.Connector.ValueTypes.OnlinerTime TIME_val
		{
			get
			{
				return _TIME_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineTime IstComplex.TIME_val
		{
			get
			{
				return TIME_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTime IShadowstComplex.TIME_val
		{
			get
			{
				return TIME_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerTimeOfDay _TIME_OF_DAY_val;
		public Vortex.Connector.ValueTypes.OnlinerTimeOfDay TIME_OF_DAY_val
		{
			get
			{
				return _TIME_OF_DAY_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineTimeOfDay IstComplex.TIME_OF_DAY_val
		{
			get
			{
				return TIME_OF_DAY_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTimeOfDay IShadowstComplex.TIME_OF_DAY_val
		{
			get
			{
				return TIME_OF_DAY_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDate _DATE_val;
		public Vortex.Connector.ValueTypes.OnlinerDate DATE_val
		{
			get
			{
				return _DATE_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDate IstComplex.DATE_val
		{
			get
			{
				return DATE_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDate IShadowstComplex.DATE_val
		{
			get
			{
				return DATE_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDateTime _DATE_AND_TIME_val;
		public Vortex.Connector.ValueTypes.OnlinerDateTime DATE_AND_TIME_val
		{
			get
			{
				return _DATE_AND_TIME_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDateTime IstComplex.DATE_AND_TIME_val
		{
			get
			{
				return DATE_AND_TIME_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDateTime IShadowstComplex.DATE_AND_TIME_val
		{
			get
			{
				return DATE_AND_TIME_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerTimeOfDay _TOD_val;
		public Vortex.Connector.ValueTypes.OnlinerTimeOfDay TOD_val
		{
			get
			{
				return _TOD_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineTimeOfDay IstComplex.TOD_val
		{
			get
			{
				return TOD_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTimeOfDay IShadowstComplex.TOD_val
		{
			get
			{
				return TOD_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerDateTime _DT_val;
		public Vortex.Connector.ValueTypes.OnlinerDateTime DT_val
		{
			get
			{
				return _DT_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDateTime IstComplex.DT_val
		{
			get
			{
				return DT_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDateTime IShadowstComplex.DT_val
		{
			get
			{
				return DT_val;
			}
		}

		Vortex.Connector.ValueTypes.OnlinerLTime _LTIME_val;
		public Vortex.Connector.ValueTypes.OnlinerLTime LTIME_val
		{
			get
			{
				return _LTIME_val;
			}
		}

		Vortex.Connector.ValueTypes.Online.IOnlineLTime IstComplex.LTIME_val
		{
			get
			{
				return LTIME_val;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowLTime IShadowstComplex.LTIME_val
		{
			get
			{
				return LTIME_val;
			}
		}

		public Vortex.Connector.ValueTypes.OnlinerInt[,, ] ValueTypeArray
		{
			get;
			set;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt[,, ] IstComplex.ValueTypeArray
		{
			get
			{
				return ValueTypeArray;
			}

			set
			{
				ValueTypeArray = (Vortex.Connector.ValueTypes.OnlinerInt[,, ])value;
			}
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt[,, ] IShadowstComplex.ValueTypeArray
		{
			get
			{
				return ValueTypeArray;
			}
		}

		public void LazyOnlineToShadow()
		{
			BOOL_val.Shadow = BOOL_val.LastValue;
			BYTE_val.Shadow = BYTE_val.LastValue;
			WORD_val.Shadow = WORD_val.LastValue;
			DWORD_val.Shadow = DWORD_val.LastValue;
			LWORD_val.Shadow = LWORD_val.LastValue;
			SINT_val.Shadow = SINT_val.LastValue;
			USINT_val.Shadow = USINT_val.LastValue;
			INT_val.Shadow = INT_val.LastValue;
			UINT_val.Shadow = UINT_val.LastValue;
			DINT_val.Shadow = DINT_val.LastValue;
			UDINT_val.Shadow = UDINT_val.LastValue;
			LINT_val.Shadow = LINT_val.LastValue;
			ULINT_val.Shadow = ULINT_val.LastValue;
			REAL_val.Shadow = REAL_val.LastValue;
			LREAL_val.Shadow = LREAL_val.LastValue;
			STRING_val.Shadow = STRING_val.LastValue;
			WSTRING_val.Shadow = WSTRING_val.LastValue;
			TIME_val.Shadow = TIME_val.LastValue;
			TIME_OF_DAY_val.Shadow = TIME_OF_DAY_val.LastValue;
			DATE_val.Shadow = DATE_val.LastValue;
			DATE_AND_TIME_val.Shadow = DATE_AND_TIME_val.LastValue;
			TOD_val.Shadow = TOD_val.LastValue;
			DT_val.Shadow = DT_val.LastValue;
			LTIME_val.Shadow = LTIME_val.LastValue;
			Vortex.Connector.BuilderHelpers.Arrays.CopyCyclicToShadowPrimitive<Vortex.Connector.ValueTypes.OnlinerInt>(ValueTypeArray);
		}

		public void LazyShadowToOnline()
		{
			BOOL_val.Cyclic = BOOL_val.Shadow;
			BYTE_val.Cyclic = BYTE_val.Shadow;
			WORD_val.Cyclic = WORD_val.Shadow;
			DWORD_val.Cyclic = DWORD_val.Shadow;
			LWORD_val.Cyclic = LWORD_val.Shadow;
			SINT_val.Cyclic = SINT_val.Shadow;
			USINT_val.Cyclic = USINT_val.Shadow;
			INT_val.Cyclic = INT_val.Shadow;
			UINT_val.Cyclic = UINT_val.Shadow;
			DINT_val.Cyclic = DINT_val.Shadow;
			UDINT_val.Cyclic = UDINT_val.Shadow;
			LINT_val.Cyclic = LINT_val.Shadow;
			ULINT_val.Cyclic = ULINT_val.Shadow;
			REAL_val.Cyclic = REAL_val.Shadow;
			LREAL_val.Cyclic = LREAL_val.Shadow;
			STRING_val.Cyclic = STRING_val.Shadow;
			WSTRING_val.Cyclic = WSTRING_val.Shadow;
			TIME_val.Cyclic = TIME_val.Shadow;
			TIME_OF_DAY_val.Cyclic = TIME_OF_DAY_val.Shadow;
			DATE_val.Cyclic = DATE_val.Shadow;
			DATE_AND_TIME_val.Cyclic = DATE_AND_TIME_val.Shadow;
			TOD_val.Cyclic = TOD_val.Shadow;
			DT_val.Cyclic = DT_val.Shadow;
			LTIME_val.Cyclic = LTIME_val.Shadow;
			Vortex.Connector.BuilderHelpers.Arrays.CopyShadowToCyclicPrimitive<Vortex.Connector.ValueTypes.OnlinerInt>(ValueTypeArray);
		}

		public PlainstComplex CreatePlainerType()
		{
			var cloned = new PlainstComplex();
			cloned.ValueTypeArray = new System.Int16[6, 4, 3];
			return cloned;
		}

		protected PlainstComplex CreatePlainerType(PlainstComplex cloned)
		{
			cloned.ValueTypeArray = new System.Int16[6, 4, 3];
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

		public void FlushPlainToOnline(HansPlc.PlainstComplex source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(HansPlc.PlainstComplex source)
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

		public void FlushOnlineToPlain(HansPlc.PlainstComplex source)
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

		public stComplex(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			_BOOL_val = @Connector.Online.Adapter.CreateBOOL(this, "", "BOOL_val");
			_BYTE_val = @Connector.Online.Adapter.CreateBYTE(this, "", "BYTE_val");
			_WORD_val = @Connector.Online.Adapter.CreateWORD(this, "", "WORD_val");
			_DWORD_val = @Connector.Online.Adapter.CreateDWORD(this, "", "DWORD_val");
			_LWORD_val = @Connector.Online.Adapter.CreateLWORD(this, "", "LWORD_val");
			_SINT_val = @Connector.Online.Adapter.CreateSINT(this, "", "SINT_val");
			_USINT_val = @Connector.Online.Adapter.CreateUSINT(this, "", "USINT_val");
			_INT_val = @Connector.Online.Adapter.CreateINT(this, "", "INT_val");
			_UINT_val = @Connector.Online.Adapter.CreateUINT(this, "", "UINT_val");
			_DINT_val = @Connector.Online.Adapter.CreateDINT(this, "", "DINT_val");
			_UDINT_val = @Connector.Online.Adapter.CreateUDINT(this, "", "UDINT_val");
			_LINT_val = @Connector.Online.Adapter.CreateLINT(this, "", "LINT_val");
			_ULINT_val = @Connector.Online.Adapter.CreateULINT(this, "", "ULINT_val");
			_REAL_val = @Connector.Online.Adapter.CreateREAL(this, "", "REAL_val");
			_LREAL_val = @Connector.Online.Adapter.CreateLREAL(this, "", "LREAL_val");
			_STRING_val = @Connector.Online.Adapter.CreateSTRING(this, "", "STRING_val");
			_WSTRING_val = @Connector.Online.Adapter.CreateWSTRING(this, "", "WSTRING_val");
			_TIME_val = @Connector.Online.Adapter.CreateTIME(this, "", "TIME_val");
			_TIME_OF_DAY_val = @Connector.Online.Adapter.CreateTIME_OF_DAY(this, "", "TIME_OF_DAY_val");
			_DATE_val = @Connector.Online.Adapter.CreateDATE(this, "", "DATE_val");
			_DATE_AND_TIME_val = @Connector.Online.Adapter.CreateDATE_TIME(this, "", "DATE_AND_TIME_val");
			_TOD_val = @Connector.Online.Adapter.CreateTIME_OF_DAY(this, "", "TOD_val");
			_DT_val = @Connector.Online.Adapter.CreateDATE_TIME(this, "", "DT_val");
			_LTIME_val = @Connector.Online.Adapter.CreateLTIME(this, "", "LTIME_val");
			ValueTypeArray = new Vortex.Connector.ValueTypes.OnlinerInt[6, 4, 3];
			Vortex.Connector.BuilderHelpers.Arrays.InstantiateArray(ValueTypeArray, this, "", "ValueTypeArray", (p, rt, st) => @Connector.Online.Adapter.CreateINT(p, rt, st));
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public stComplex()
		{
			PexPreConstructorParameterless();
			_BOOL_val = Vortex.Connector.IConnectorFactory.CreateBOOL();
			_BYTE_val = Vortex.Connector.IConnectorFactory.CreateBYTE();
			_WORD_val = Vortex.Connector.IConnectorFactory.CreateWORD();
			_DWORD_val = Vortex.Connector.IConnectorFactory.CreateDWORD();
			_LWORD_val = Vortex.Connector.IConnectorFactory.CreateLWORD();
			_SINT_val = Vortex.Connector.IConnectorFactory.CreateSINT();
			_USINT_val = Vortex.Connector.IConnectorFactory.CreateUSINT();
			_INT_val = Vortex.Connector.IConnectorFactory.CreateINT();
			_UINT_val = Vortex.Connector.IConnectorFactory.CreateUINT();
			_DINT_val = Vortex.Connector.IConnectorFactory.CreateDINT();
			_UDINT_val = Vortex.Connector.IConnectorFactory.CreateUDINT();
			_LINT_val = Vortex.Connector.IConnectorFactory.CreateLINT();
			_ULINT_val = Vortex.Connector.IConnectorFactory.CreateULINT();
			_REAL_val = Vortex.Connector.IConnectorFactory.CreateREAL();
			_LREAL_val = Vortex.Connector.IConnectorFactory.CreateLREAL();
			_STRING_val = Vortex.Connector.IConnectorFactory.CreateSTRING();
			_WSTRING_val = Vortex.Connector.IConnectorFactory.CreateWSTRING();
			_TIME_val = Vortex.Connector.IConnectorFactory.CreateTIME();
			_TIME_OF_DAY_val = Vortex.Connector.IConnectorFactory.CreateTIME_OF_DAY();
			_DATE_val = Vortex.Connector.IConnectorFactory.CreateDATE();
			_DATE_AND_TIME_val = Vortex.Connector.IConnectorFactory.CreateDATE_TIME();
			_TOD_val = Vortex.Connector.IConnectorFactory.CreateTIME_OF_DAY();
			_DT_val = Vortex.Connector.IConnectorFactory.CreateDATE_TIME();
			_LTIME_val = Vortex.Connector.IConnectorFactory.CreateLTIME();
			ValueTypeArray = new Vortex.Connector.ValueTypes.OnlinerInt[6, 4, 3];
			Vortex.Connector.BuilderHelpers.Arrays.InstantiateArray(ValueTypeArray, () => Vortex.Connector.IConnectorFactory.CreateINT());
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcstComplex
		{
			public object BOOL_val;
			public object BYTE_val;
			public object WORD_val;
			public object DWORD_val;
			public object LWORD_val;
			public object SINT_val;
			public object USINT_val;
			public object INT_val;
			public object UINT_val;
			public object DINT_val;
			public object UDINT_val;
			public object LINT_val;
			public object ULINT_val;
			public object REAL_val;
			public object LREAL_val;
			public object STRING_val;
			public object WSTRING_val;
			public object TIME_val;
			public object TIME_OF_DAY_val;
			public object DATE_val;
			public object DATE_AND_TIME_val;
			public object TOD_val;
			public object DT_val;
			public object LTIME_val;
			public object ValueTypeArray;
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcstComplex()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IstComplex : Vortex.Connector.IVortexOnlineObject
	{
		Vortex.Connector.ValueTypes.Online.IOnlineBool BOOL_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineByte BYTE_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineWord WORD_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDWord DWORD_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineLWord LWORD_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineSInt SINT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUSInt USINT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt INT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUInt UINT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDInt DINT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineUDInt UDINT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineLInt LINT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineULInt ULINT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineReal REAL_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineLReal LREAL_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineString STRING_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineWString WSTRING_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineTime TIME_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineTimeOfDay TIME_OF_DAY_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDate DATE_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDateTime DATE_AND_TIME_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineTimeOfDay TOD_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineDateTime DT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineLTime LTIME_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Online.IOnlineInt[,, ] ValueTypeArray
		{
			get;
			set;
		}

		System.String AttributeName
		{
			get;
		}

		HansPlc.PlainstComplex CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(HansPlc.PlainstComplex source);
		void FlushOnlineToPlain(HansPlc.PlainstComplex source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowstComplex : Vortex.Connector.IVortexShadowObject
	{
		Vortex.Connector.ValueTypes.Shadows.IShadowBool BOOL_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowByte BYTE_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowWord WORD_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDWord DWORD_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowLWord LWORD_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowSInt SINT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUSInt USINT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt INT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUInt UINT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDInt DINT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowUDInt UDINT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowLInt LINT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowULInt ULINT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowReal REAL_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowLReal LREAL_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowString STRING_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowWString WSTRING_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTime TIME_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTimeOfDay TIME_OF_DAY_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDate DATE_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDateTime DATE_AND_TIME_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowTimeOfDay TOD_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowDateTime DT_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowLTime LTIME_val
		{
			get;
		}

		Vortex.Connector.ValueTypes.Shadows.IShadowInt[,, ] ValueTypeArray
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		HansPlc.PlainstComplex CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(HansPlc.PlainstComplex source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainstComplex : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		System.Boolean _BOOL_val;
		public System.Boolean BOOL_val
		{
			get
			{
				return _BOOL_val;
			}

			set
			{
				if (_BOOL_val != value)
				{
					_BOOL_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(BOOL_val)));
				}
			}
		}

		System.Byte _BYTE_val;
		public System.Byte BYTE_val
		{
			get
			{
				return _BYTE_val;
			}

			set
			{
				if (_BYTE_val != value)
				{
					_BYTE_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(BYTE_val)));
				}
			}
		}

		System.UInt16 _WORD_val;
		public System.UInt16 WORD_val
		{
			get
			{
				return _WORD_val;
			}

			set
			{
				if (_WORD_val != value)
				{
					_WORD_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(WORD_val)));
				}
			}
		}

		System.UInt32 _DWORD_val;
		public System.UInt32 DWORD_val
		{
			get
			{
				return _DWORD_val;
			}

			set
			{
				if (_DWORD_val != value)
				{
					_DWORD_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(DWORD_val)));
				}
			}
		}

		System.UInt64 _LWORD_val;
		public System.UInt64 LWORD_val
		{
			get
			{
				return _LWORD_val;
			}

			set
			{
				if (_LWORD_val != value)
				{
					_LWORD_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(LWORD_val)));
				}
			}
		}

		System.SByte _SINT_val;
		public System.SByte SINT_val
		{
			get
			{
				return _SINT_val;
			}

			set
			{
				if (_SINT_val != value)
				{
					_SINT_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(SINT_val)));
				}
			}
		}

		System.Byte _USINT_val;
		public System.Byte USINT_val
		{
			get
			{
				return _USINT_val;
			}

			set
			{
				if (_USINT_val != value)
				{
					_USINT_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(USINT_val)));
				}
			}
		}

		System.Int16 _INT_val;
		public System.Int16 INT_val
		{
			get
			{
				return _INT_val;
			}

			set
			{
				if (_INT_val != value)
				{
					_INT_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(INT_val)));
				}
			}
		}

		System.UInt16 _UINT_val;
		public System.UInt16 UINT_val
		{
			get
			{
				return _UINT_val;
			}

			set
			{
				if (_UINT_val != value)
				{
					_UINT_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(UINT_val)));
				}
			}
		}

		System.Int32 _DINT_val;
		public System.Int32 DINT_val
		{
			get
			{
				return _DINT_val;
			}

			set
			{
				if (_DINT_val != value)
				{
					_DINT_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(DINT_val)));
				}
			}
		}

		System.UInt32 _UDINT_val;
		public System.UInt32 UDINT_val
		{
			get
			{
				return _UDINT_val;
			}

			set
			{
				if (_UDINT_val != value)
				{
					_UDINT_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(UDINT_val)));
				}
			}
		}

		System.Int64 _LINT_val;
		public System.Int64 LINT_val
		{
			get
			{
				return _LINT_val;
			}

			set
			{
				if (_LINT_val != value)
				{
					_LINT_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(LINT_val)));
				}
			}
		}

		System.UInt64 _ULINT_val;
		public System.UInt64 ULINT_val
		{
			get
			{
				return _ULINT_val;
			}

			set
			{
				if (_ULINT_val != value)
				{
					_ULINT_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(ULINT_val)));
				}
			}
		}

		System.Single _REAL_val;
		public System.Single REAL_val
		{
			get
			{
				return _REAL_val;
			}

			set
			{
				if (_REAL_val != value)
				{
					_REAL_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(REAL_val)));
				}
			}
		}

		System.Double _LREAL_val;
		public System.Double LREAL_val
		{
			get
			{
				return _LREAL_val;
			}

			set
			{
				if (_LREAL_val != value)
				{
					_LREAL_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(LREAL_val)));
				}
			}
		}

		System.String _STRING_val;
		public System.String STRING_val
		{
			get
			{
				return _STRING_val;
			}

			set
			{
				if (_STRING_val != value)
				{
					_STRING_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(STRING_val)));
				}
			}
		}

		System.String _WSTRING_val;
		public System.String WSTRING_val
		{
			get
			{
				return _WSTRING_val;
			}

			set
			{
				if (_WSTRING_val != value)
				{
					_WSTRING_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(WSTRING_val)));
				}
			}
		}

		System.TimeSpan _TIME_val;
		public System.TimeSpan TIME_val
		{
			get
			{
				return _TIME_val;
			}

			set
			{
				if (_TIME_val != value)
				{
					_TIME_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(TIME_val)));
				}
			}
		}

		System.TimeSpan _TIME_OF_DAY_val;
		public System.TimeSpan TIME_OF_DAY_val
		{
			get
			{
				return _TIME_OF_DAY_val;
			}

			set
			{
				if (_TIME_OF_DAY_val != value)
				{
					_TIME_OF_DAY_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(TIME_OF_DAY_val)));
				}
			}
		}

		System.DateTime _DATE_val;
		public System.DateTime DATE_val
		{
			get
			{
				return _DATE_val;
			}

			set
			{
				if (_DATE_val != value)
				{
					_DATE_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(DATE_val)));
				}
			}
		}

		System.DateTime _DATE_AND_TIME_val;
		public System.DateTime DATE_AND_TIME_val
		{
			get
			{
				return _DATE_AND_TIME_val;
			}

			set
			{
				if (_DATE_AND_TIME_val != value)
				{
					_DATE_AND_TIME_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(DATE_AND_TIME_val)));
				}
			}
		}

		System.TimeSpan _TOD_val;
		public System.TimeSpan TOD_val
		{
			get
			{
				return _TOD_val;
			}

			set
			{
				if (_TOD_val != value)
				{
					_TOD_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(TOD_val)));
				}
			}
		}

		System.DateTime _DT_val;
		public System.DateTime DT_val
		{
			get
			{
				return _DT_val;
			}

			set
			{
				if (_DT_val != value)
				{
					_DT_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(DT_val)));
				}
			}
		}

		System.TimeSpan _LTIME_val;
		public System.TimeSpan LTIME_val
		{
			get
			{
				return _LTIME_val;
			}

			set
			{
				if (_LTIME_val != value)
				{
					_LTIME_val = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(LTIME_val)));
				}
			}
		}

		public System.Int16[,, ] ValueTypeArray
		{
			get;
			set;
		}

		public void CopyPlainToCyclic(HansPlc.stComplex target)
		{
			target.BOOL_val.Cyclic = BOOL_val;
			target.BYTE_val.Cyclic = BYTE_val;
			target.WORD_val.Cyclic = WORD_val;
			target.DWORD_val.Cyclic = DWORD_val;
			target.LWORD_val.Cyclic = LWORD_val;
			target.SINT_val.Cyclic = SINT_val;
			target.USINT_val.Cyclic = USINT_val;
			target.INT_val.Cyclic = INT_val;
			target.UINT_val.Cyclic = UINT_val;
			target.DINT_val.Cyclic = DINT_val;
			target.UDINT_val.Cyclic = UDINT_val;
			target.LINT_val.Cyclic = LINT_val;
			target.ULINT_val.Cyclic = ULINT_val;
			target.REAL_val.Cyclic = REAL_val;
			target.LREAL_val.Cyclic = LREAL_val;
			target.STRING_val.Cyclic = STRING_val;
			target.WSTRING_val.Cyclic = WSTRING_val;
			target.TIME_val.Cyclic = TIME_val;
			target.TIME_OF_DAY_val.Cyclic = TIME_OF_DAY_val;
			target.DATE_val.Cyclic = DATE_val;
			target.DATE_AND_TIME_val.Cyclic = DATE_AND_TIME_val;
			target.TOD_val.Cyclic = TOD_val;
			target.DT_val.Cyclic = DT_val;
			target.LTIME_val.Cyclic = LTIME_val;
			Vortex.Connector.BuilderHelpers.Arrays.CopyPlainToOnline<System.Int16, Vortex.Connector.ValueTypes.OnlinerInt>(ValueTypeArray, target.ValueTypeArray);
		}

		public void CopyPlainToCyclic(HansPlc.IstComplex target)
		{
			this.CopyPlainToCyclic((HansPlc.stComplex)target);
		}

		public void CopyPlainToShadow(HansPlc.stComplex target)
		{
			target.BOOL_val.Shadow = BOOL_val;
			target.BYTE_val.Shadow = BYTE_val;
			target.WORD_val.Shadow = WORD_val;
			target.DWORD_val.Shadow = DWORD_val;
			target.LWORD_val.Shadow = LWORD_val;
			target.SINT_val.Shadow = SINT_val;
			target.USINT_val.Shadow = USINT_val;
			target.INT_val.Shadow = INT_val;
			target.UINT_val.Shadow = UINT_val;
			target.DINT_val.Shadow = DINT_val;
			target.UDINT_val.Shadow = UDINT_val;
			target.LINT_val.Shadow = LINT_val;
			target.ULINT_val.Shadow = ULINT_val;
			target.REAL_val.Shadow = REAL_val;
			target.LREAL_val.Shadow = LREAL_val;
			target.STRING_val.Shadow = STRING_val;
			target.WSTRING_val.Shadow = WSTRING_val;
			target.TIME_val.Shadow = TIME_val;
			target.TIME_OF_DAY_val.Shadow = TIME_OF_DAY_val;
			target.DATE_val.Shadow = DATE_val;
			target.DATE_AND_TIME_val.Shadow = DATE_AND_TIME_val;
			target.TOD_val.Shadow = TOD_val;
			target.DT_val.Shadow = DT_val;
			target.LTIME_val.Shadow = LTIME_val;
			Vortex.Connector.BuilderHelpers.Arrays.CopyPlainToShadow<System.Int16, Vortex.Connector.ValueTypes.OnlinerInt>(ValueTypeArray, target.ValueTypeArray);
		}

		public void CopyPlainToShadow(HansPlc.IShadowstComplex target)
		{
			this.CopyPlainToShadow((HansPlc.stComplex)target);
		}

		public void CopyCyclicToPlain(HansPlc.stComplex source)
		{
			BOOL_val = source.BOOL_val.LastValue;
			BYTE_val = source.BYTE_val.LastValue;
			WORD_val = source.WORD_val.LastValue;
			DWORD_val = source.DWORD_val.LastValue;
			LWORD_val = source.LWORD_val.LastValue;
			SINT_val = source.SINT_val.LastValue;
			USINT_val = source.USINT_val.LastValue;
			INT_val = source.INT_val.LastValue;
			UINT_val = source.UINT_val.LastValue;
			DINT_val = source.DINT_val.LastValue;
			UDINT_val = source.UDINT_val.LastValue;
			LINT_val = source.LINT_val.LastValue;
			ULINT_val = source.ULINT_val.LastValue;
			REAL_val = source.REAL_val.LastValue;
			LREAL_val = source.LREAL_val.LastValue;
			STRING_val = source.STRING_val.LastValue;
			WSTRING_val = source.WSTRING_val.LastValue;
			TIME_val = source.TIME_val.LastValue;
			TIME_OF_DAY_val = source.TIME_OF_DAY_val.LastValue;
			DATE_val = source.DATE_val.LastValue;
			DATE_AND_TIME_val = source.DATE_AND_TIME_val.LastValue;
			TOD_val = source.TOD_val.LastValue;
			DT_val = source.DT_val.LastValue;
			LTIME_val = source.LTIME_val.LastValue;
			Vortex.Connector.BuilderHelpers.Arrays.CopyOnlineToPlain<Vortex.Connector.ValueTypes.OnlinerInt, System.Int16>(source.ValueTypeArray, ValueTypeArray);
		}

		public void CopyCyclicToPlain(HansPlc.IstComplex source)
		{
			this.CopyCyclicToPlain((HansPlc.stComplex)source);
		}

		public void CopyShadowToPlain(HansPlc.stComplex source)
		{
			BOOL_val = source.BOOL_val.Shadow;
			BYTE_val = source.BYTE_val.Shadow;
			WORD_val = source.WORD_val.Shadow;
			DWORD_val = source.DWORD_val.Shadow;
			LWORD_val = source.LWORD_val.Shadow;
			SINT_val = source.SINT_val.Shadow;
			USINT_val = source.USINT_val.Shadow;
			INT_val = source.INT_val.Shadow;
			UINT_val = source.UINT_val.Shadow;
			DINT_val = source.DINT_val.Shadow;
			UDINT_val = source.UDINT_val.Shadow;
			LINT_val = source.LINT_val.Shadow;
			ULINT_val = source.ULINT_val.Shadow;
			REAL_val = source.REAL_val.Shadow;
			LREAL_val = source.LREAL_val.Shadow;
			STRING_val = source.STRING_val.Shadow;
			WSTRING_val = source.WSTRING_val.Shadow;
			TIME_val = source.TIME_val.Shadow;
			TIME_OF_DAY_val = source.TIME_OF_DAY_val.Shadow;
			DATE_val = source.DATE_val.Shadow;
			DATE_AND_TIME_val = source.DATE_AND_TIME_val.Shadow;
			TOD_val = source.TOD_val.Shadow;
			DT_val = source.DT_val.Shadow;
			LTIME_val = source.LTIME_val.Shadow;
			Vortex.Connector.BuilderHelpers.Arrays.CopyShadowToPlain<Vortex.Connector.ValueTypes.OnlinerInt, System.Int16>(source.ValueTypeArray, ValueTypeArray);
		}

		public void CopyShadowToPlain(HansPlc.IShadowstComplex source)
		{
			this.CopyShadowToPlain((HansPlc.stComplex)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainstComplex()
		{
			ValueTypeArray = new System.Int16[6, 4, 3];
		}
	}
}