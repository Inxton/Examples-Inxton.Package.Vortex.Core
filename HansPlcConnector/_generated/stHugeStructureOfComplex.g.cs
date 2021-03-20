using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;

namespace HansPlc
{
#pragma warning disable SA1402, CS1591, CS0108, CS0067
	[Vortex.Connector.Attributes.TypeMetaDescriptorAttribute("{attribute addProperty Name \"\" }", "stHugeStructureOfComplex", "HansPlc", TypeComplexityEnum.Complex)]
	public partial class stHugeStructureOfComplex : Vortex.Connector.IVortexObject, IstHugeStructureOfComplex, IShadowstHugeStructureOfComplex, Vortex.Connector.IVortexOnlineObject, Vortex.Connector.IVortexShadowObject
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
		stComplex __1;
		public stComplex _1
		{
			get
			{
				return __1;
			}
		}

		IstComplex IstHugeStructureOfComplex._1
		{
			get
			{
				return _1;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._1
		{
			get
			{
				return _1;
			}
		}

		stComplex __2;
		public stComplex _2
		{
			get
			{
				return __2;
			}
		}

		IstComplex IstHugeStructureOfComplex._2
		{
			get
			{
				return _2;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._2
		{
			get
			{
				return _2;
			}
		}

		stComplex __3;
		public stComplex _3
		{
			get
			{
				return __3;
			}
		}

		IstComplex IstHugeStructureOfComplex._3
		{
			get
			{
				return _3;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._3
		{
			get
			{
				return _3;
			}
		}

		stComplex __4;
		public stComplex _4
		{
			get
			{
				return __4;
			}
		}

		IstComplex IstHugeStructureOfComplex._4
		{
			get
			{
				return _4;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._4
		{
			get
			{
				return _4;
			}
		}

		stComplex __5;
		public stComplex _5
		{
			get
			{
				return __5;
			}
		}

		IstComplex IstHugeStructureOfComplex._5
		{
			get
			{
				return _5;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._5
		{
			get
			{
				return _5;
			}
		}

		stComplex __6;
		public stComplex _6
		{
			get
			{
				return __6;
			}
		}

		IstComplex IstHugeStructureOfComplex._6
		{
			get
			{
				return _6;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._6
		{
			get
			{
				return _6;
			}
		}

		stComplex __7;
		public stComplex _7
		{
			get
			{
				return __7;
			}
		}

		IstComplex IstHugeStructureOfComplex._7
		{
			get
			{
				return _7;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._7
		{
			get
			{
				return _7;
			}
		}

		stComplex __8;
		public stComplex _8
		{
			get
			{
				return __8;
			}
		}

		IstComplex IstHugeStructureOfComplex._8
		{
			get
			{
				return _8;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._8
		{
			get
			{
				return _8;
			}
		}

		stComplex __9;
		public stComplex _9
		{
			get
			{
				return __9;
			}
		}

		IstComplex IstHugeStructureOfComplex._9
		{
			get
			{
				return _9;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._9
		{
			get
			{
				return _9;
			}
		}

		stComplex __10;
		public stComplex _10
		{
			get
			{
				return __10;
			}
		}

		IstComplex IstHugeStructureOfComplex._10
		{
			get
			{
				return _10;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._10
		{
			get
			{
				return _10;
			}
		}

		stComplex __11;
		public stComplex _11
		{
			get
			{
				return __11;
			}
		}

		IstComplex IstHugeStructureOfComplex._11
		{
			get
			{
				return _11;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._11
		{
			get
			{
				return _11;
			}
		}

		stComplex __12;
		public stComplex _12
		{
			get
			{
				return __12;
			}
		}

		IstComplex IstHugeStructureOfComplex._12
		{
			get
			{
				return _12;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._12
		{
			get
			{
				return _12;
			}
		}

		stComplex __13;
		public stComplex _13
		{
			get
			{
				return __13;
			}
		}

		IstComplex IstHugeStructureOfComplex._13
		{
			get
			{
				return _13;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._13
		{
			get
			{
				return _13;
			}
		}

		stComplex __14;
		public stComplex _14
		{
			get
			{
				return __14;
			}
		}

		IstComplex IstHugeStructureOfComplex._14
		{
			get
			{
				return _14;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._14
		{
			get
			{
				return _14;
			}
		}

		stComplex __15;
		public stComplex _15
		{
			get
			{
				return __15;
			}
		}

		IstComplex IstHugeStructureOfComplex._15
		{
			get
			{
				return _15;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._15
		{
			get
			{
				return _15;
			}
		}

		stComplex __16;
		public stComplex _16
		{
			get
			{
				return __16;
			}
		}

		IstComplex IstHugeStructureOfComplex._16
		{
			get
			{
				return _16;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._16
		{
			get
			{
				return _16;
			}
		}

		stComplex __17;
		public stComplex _17
		{
			get
			{
				return __17;
			}
		}

		IstComplex IstHugeStructureOfComplex._17
		{
			get
			{
				return _17;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._17
		{
			get
			{
				return _17;
			}
		}

		stComplex __18;
		public stComplex _18
		{
			get
			{
				return __18;
			}
		}

		IstComplex IstHugeStructureOfComplex._18
		{
			get
			{
				return _18;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._18
		{
			get
			{
				return _18;
			}
		}

		stComplex __19;
		public stComplex _19
		{
			get
			{
				return __19;
			}
		}

		IstComplex IstHugeStructureOfComplex._19
		{
			get
			{
				return _19;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._19
		{
			get
			{
				return _19;
			}
		}

		stComplex __20;
		public stComplex _20
		{
			get
			{
				return __20;
			}
		}

		IstComplex IstHugeStructureOfComplex._20
		{
			get
			{
				return _20;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._20
		{
			get
			{
				return _20;
			}
		}

		stComplex __21;
		public stComplex _21
		{
			get
			{
				return __21;
			}
		}

		IstComplex IstHugeStructureOfComplex._21
		{
			get
			{
				return _21;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._21
		{
			get
			{
				return _21;
			}
		}

		stComplex __22;
		public stComplex _22
		{
			get
			{
				return __22;
			}
		}

		IstComplex IstHugeStructureOfComplex._22
		{
			get
			{
				return _22;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._22
		{
			get
			{
				return _22;
			}
		}

		stComplex __23;
		public stComplex _23
		{
			get
			{
				return __23;
			}
		}

		IstComplex IstHugeStructureOfComplex._23
		{
			get
			{
				return _23;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._23
		{
			get
			{
				return _23;
			}
		}

		stComplex __24;
		public stComplex _24
		{
			get
			{
				return __24;
			}
		}

		IstComplex IstHugeStructureOfComplex._24
		{
			get
			{
				return _24;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._24
		{
			get
			{
				return _24;
			}
		}

		stComplex __25;
		public stComplex _25
		{
			get
			{
				return __25;
			}
		}

		IstComplex IstHugeStructureOfComplex._25
		{
			get
			{
				return _25;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._25
		{
			get
			{
				return _25;
			}
		}

		stComplex __26;
		public stComplex _26
		{
			get
			{
				return __26;
			}
		}

		IstComplex IstHugeStructureOfComplex._26
		{
			get
			{
				return _26;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._26
		{
			get
			{
				return _26;
			}
		}

		stComplex __27;
		public stComplex _27
		{
			get
			{
				return __27;
			}
		}

		IstComplex IstHugeStructureOfComplex._27
		{
			get
			{
				return _27;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._27
		{
			get
			{
				return _27;
			}
		}

		stComplex __28;
		public stComplex _28
		{
			get
			{
				return __28;
			}
		}

		IstComplex IstHugeStructureOfComplex._28
		{
			get
			{
				return _28;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._28
		{
			get
			{
				return _28;
			}
		}

		stComplex __29;
		public stComplex _29
		{
			get
			{
				return __29;
			}
		}

		IstComplex IstHugeStructureOfComplex._29
		{
			get
			{
				return _29;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._29
		{
			get
			{
				return _29;
			}
		}

		stComplex __30;
		public stComplex _30
		{
			get
			{
				return __30;
			}
		}

		IstComplex IstHugeStructureOfComplex._30
		{
			get
			{
				return _30;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._30
		{
			get
			{
				return _30;
			}
		}

		stComplex __31;
		public stComplex _31
		{
			get
			{
				return __31;
			}
		}

		IstComplex IstHugeStructureOfComplex._31
		{
			get
			{
				return _31;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._31
		{
			get
			{
				return _31;
			}
		}

		stComplex __32;
		public stComplex _32
		{
			get
			{
				return __32;
			}
		}

		IstComplex IstHugeStructureOfComplex._32
		{
			get
			{
				return _32;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._32
		{
			get
			{
				return _32;
			}
		}

		stComplex __33;
		public stComplex _33
		{
			get
			{
				return __33;
			}
		}

		IstComplex IstHugeStructureOfComplex._33
		{
			get
			{
				return _33;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._33
		{
			get
			{
				return _33;
			}
		}

		stComplex __34;
		public stComplex _34
		{
			get
			{
				return __34;
			}
		}

		IstComplex IstHugeStructureOfComplex._34
		{
			get
			{
				return _34;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._34
		{
			get
			{
				return _34;
			}
		}

		stComplex __35;
		public stComplex _35
		{
			get
			{
				return __35;
			}
		}

		IstComplex IstHugeStructureOfComplex._35
		{
			get
			{
				return _35;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._35
		{
			get
			{
				return _35;
			}
		}

		stComplex __36;
		public stComplex _36
		{
			get
			{
				return __36;
			}
		}

		IstComplex IstHugeStructureOfComplex._36
		{
			get
			{
				return _36;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._36
		{
			get
			{
				return _36;
			}
		}

		stComplex __37;
		public stComplex _37
		{
			get
			{
				return __37;
			}
		}

		IstComplex IstHugeStructureOfComplex._37
		{
			get
			{
				return _37;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._37
		{
			get
			{
				return _37;
			}
		}

		stComplex __38;
		public stComplex _38
		{
			get
			{
				return __38;
			}
		}

		IstComplex IstHugeStructureOfComplex._38
		{
			get
			{
				return _38;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._38
		{
			get
			{
				return _38;
			}
		}

		stComplex __39;
		public stComplex _39
		{
			get
			{
				return __39;
			}
		}

		IstComplex IstHugeStructureOfComplex._39
		{
			get
			{
				return _39;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._39
		{
			get
			{
				return _39;
			}
		}

		stComplex __40;
		public stComplex _40
		{
			get
			{
				return __40;
			}
		}

		IstComplex IstHugeStructureOfComplex._40
		{
			get
			{
				return _40;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._40
		{
			get
			{
				return _40;
			}
		}

		stComplex __41;
		public stComplex _41
		{
			get
			{
				return __41;
			}
		}

		IstComplex IstHugeStructureOfComplex._41
		{
			get
			{
				return _41;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._41
		{
			get
			{
				return _41;
			}
		}

		stComplex __42;
		public stComplex _42
		{
			get
			{
				return __42;
			}
		}

		IstComplex IstHugeStructureOfComplex._42
		{
			get
			{
				return _42;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._42
		{
			get
			{
				return _42;
			}
		}

		stComplex __43;
		public stComplex _43
		{
			get
			{
				return __43;
			}
		}

		IstComplex IstHugeStructureOfComplex._43
		{
			get
			{
				return _43;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._43
		{
			get
			{
				return _43;
			}
		}

		stComplex __44;
		public stComplex _44
		{
			get
			{
				return __44;
			}
		}

		IstComplex IstHugeStructureOfComplex._44
		{
			get
			{
				return _44;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._44
		{
			get
			{
				return _44;
			}
		}

		stComplex __45;
		public stComplex _45
		{
			get
			{
				return __45;
			}
		}

		IstComplex IstHugeStructureOfComplex._45
		{
			get
			{
				return _45;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._45
		{
			get
			{
				return _45;
			}
		}

		stComplex __46;
		public stComplex _46
		{
			get
			{
				return __46;
			}
		}

		IstComplex IstHugeStructureOfComplex._46
		{
			get
			{
				return _46;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._46
		{
			get
			{
				return _46;
			}
		}

		stComplex __47;
		public stComplex _47
		{
			get
			{
				return __47;
			}
		}

		IstComplex IstHugeStructureOfComplex._47
		{
			get
			{
				return _47;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._47
		{
			get
			{
				return _47;
			}
		}

		stComplex __48;
		public stComplex _48
		{
			get
			{
				return __48;
			}
		}

		IstComplex IstHugeStructureOfComplex._48
		{
			get
			{
				return _48;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._48
		{
			get
			{
				return _48;
			}
		}

		stComplex __49;
		public stComplex _49
		{
			get
			{
				return __49;
			}
		}

		IstComplex IstHugeStructureOfComplex._49
		{
			get
			{
				return _49;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._49
		{
			get
			{
				return _49;
			}
		}

		stComplex __50;
		public stComplex _50
		{
			get
			{
				return __50;
			}
		}

		IstComplex IstHugeStructureOfComplex._50
		{
			get
			{
				return _50;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._50
		{
			get
			{
				return _50;
			}
		}

		stComplex __51;
		public stComplex _51
		{
			get
			{
				return __51;
			}
		}

		IstComplex IstHugeStructureOfComplex._51
		{
			get
			{
				return _51;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._51
		{
			get
			{
				return _51;
			}
		}

		stComplex __52;
		public stComplex _52
		{
			get
			{
				return __52;
			}
		}

		IstComplex IstHugeStructureOfComplex._52
		{
			get
			{
				return _52;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._52
		{
			get
			{
				return _52;
			}
		}

		stComplex __53;
		public stComplex _53
		{
			get
			{
				return __53;
			}
		}

		IstComplex IstHugeStructureOfComplex._53
		{
			get
			{
				return _53;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._53
		{
			get
			{
				return _53;
			}
		}

		stComplex __54;
		public stComplex _54
		{
			get
			{
				return __54;
			}
		}

		IstComplex IstHugeStructureOfComplex._54
		{
			get
			{
				return _54;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._54
		{
			get
			{
				return _54;
			}
		}

		stComplex __55;
		public stComplex _55
		{
			get
			{
				return __55;
			}
		}

		IstComplex IstHugeStructureOfComplex._55
		{
			get
			{
				return _55;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._55
		{
			get
			{
				return _55;
			}
		}

		stComplex __56;
		public stComplex _56
		{
			get
			{
				return __56;
			}
		}

		IstComplex IstHugeStructureOfComplex._56
		{
			get
			{
				return _56;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._56
		{
			get
			{
				return _56;
			}
		}

		stComplex __57;
		public stComplex _57
		{
			get
			{
				return __57;
			}
		}

		IstComplex IstHugeStructureOfComplex._57
		{
			get
			{
				return _57;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._57
		{
			get
			{
				return _57;
			}
		}

		stComplex __58;
		public stComplex _58
		{
			get
			{
				return __58;
			}
		}

		IstComplex IstHugeStructureOfComplex._58
		{
			get
			{
				return _58;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._58
		{
			get
			{
				return _58;
			}
		}

		stComplex __59;
		public stComplex _59
		{
			get
			{
				return __59;
			}
		}

		IstComplex IstHugeStructureOfComplex._59
		{
			get
			{
				return _59;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._59
		{
			get
			{
				return _59;
			}
		}

		stComplex __60;
		public stComplex _60
		{
			get
			{
				return __60;
			}
		}

		IstComplex IstHugeStructureOfComplex._60
		{
			get
			{
				return _60;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._60
		{
			get
			{
				return _60;
			}
		}

		stComplex __61;
		public stComplex _61
		{
			get
			{
				return __61;
			}
		}

		IstComplex IstHugeStructureOfComplex._61
		{
			get
			{
				return _61;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._61
		{
			get
			{
				return _61;
			}
		}

		stComplex __62;
		public stComplex _62
		{
			get
			{
				return __62;
			}
		}

		IstComplex IstHugeStructureOfComplex._62
		{
			get
			{
				return _62;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._62
		{
			get
			{
				return _62;
			}
		}

		stComplex __63;
		public stComplex _63
		{
			get
			{
				return __63;
			}
		}

		IstComplex IstHugeStructureOfComplex._63
		{
			get
			{
				return _63;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._63
		{
			get
			{
				return _63;
			}
		}

		stComplex __64;
		public stComplex _64
		{
			get
			{
				return __64;
			}
		}

		IstComplex IstHugeStructureOfComplex._64
		{
			get
			{
				return _64;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._64
		{
			get
			{
				return _64;
			}
		}

		stComplex __65;
		public stComplex _65
		{
			get
			{
				return __65;
			}
		}

		IstComplex IstHugeStructureOfComplex._65
		{
			get
			{
				return _65;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._65
		{
			get
			{
				return _65;
			}
		}

		stComplex __66;
		public stComplex _66
		{
			get
			{
				return __66;
			}
		}

		IstComplex IstHugeStructureOfComplex._66
		{
			get
			{
				return _66;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._66
		{
			get
			{
				return _66;
			}
		}

		stComplex __67;
		public stComplex _67
		{
			get
			{
				return __67;
			}
		}

		IstComplex IstHugeStructureOfComplex._67
		{
			get
			{
				return _67;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._67
		{
			get
			{
				return _67;
			}
		}

		stComplex __68;
		public stComplex _68
		{
			get
			{
				return __68;
			}
		}

		IstComplex IstHugeStructureOfComplex._68
		{
			get
			{
				return _68;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._68
		{
			get
			{
				return _68;
			}
		}

		stComplex __69;
		public stComplex _69
		{
			get
			{
				return __69;
			}
		}

		IstComplex IstHugeStructureOfComplex._69
		{
			get
			{
				return _69;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._69
		{
			get
			{
				return _69;
			}
		}

		stComplex __70;
		public stComplex _70
		{
			get
			{
				return __70;
			}
		}

		IstComplex IstHugeStructureOfComplex._70
		{
			get
			{
				return _70;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._70
		{
			get
			{
				return _70;
			}
		}

		stComplex __71;
		public stComplex _71
		{
			get
			{
				return __71;
			}
		}

		IstComplex IstHugeStructureOfComplex._71
		{
			get
			{
				return _71;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._71
		{
			get
			{
				return _71;
			}
		}

		stComplex __72;
		public stComplex _72
		{
			get
			{
				return __72;
			}
		}

		IstComplex IstHugeStructureOfComplex._72
		{
			get
			{
				return _72;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._72
		{
			get
			{
				return _72;
			}
		}

		stComplex __73;
		public stComplex _73
		{
			get
			{
				return __73;
			}
		}

		IstComplex IstHugeStructureOfComplex._73
		{
			get
			{
				return _73;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._73
		{
			get
			{
				return _73;
			}
		}

		stComplex __74;
		public stComplex _74
		{
			get
			{
				return __74;
			}
		}

		IstComplex IstHugeStructureOfComplex._74
		{
			get
			{
				return _74;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._74
		{
			get
			{
				return _74;
			}
		}

		stComplex __75;
		public stComplex _75
		{
			get
			{
				return __75;
			}
		}

		IstComplex IstHugeStructureOfComplex._75
		{
			get
			{
				return _75;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._75
		{
			get
			{
				return _75;
			}
		}

		stComplex __76;
		public stComplex _76
		{
			get
			{
				return __76;
			}
		}

		IstComplex IstHugeStructureOfComplex._76
		{
			get
			{
				return _76;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._76
		{
			get
			{
				return _76;
			}
		}

		stComplex __77;
		public stComplex _77
		{
			get
			{
				return __77;
			}
		}

		IstComplex IstHugeStructureOfComplex._77
		{
			get
			{
				return _77;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._77
		{
			get
			{
				return _77;
			}
		}

		stComplex __78;
		public stComplex _78
		{
			get
			{
				return __78;
			}
		}

		IstComplex IstHugeStructureOfComplex._78
		{
			get
			{
				return _78;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._78
		{
			get
			{
				return _78;
			}
		}

		stComplex __79;
		public stComplex _79
		{
			get
			{
				return __79;
			}
		}

		IstComplex IstHugeStructureOfComplex._79
		{
			get
			{
				return _79;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._79
		{
			get
			{
				return _79;
			}
		}

		stComplex __80;
		public stComplex _80
		{
			get
			{
				return __80;
			}
		}

		IstComplex IstHugeStructureOfComplex._80
		{
			get
			{
				return _80;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._80
		{
			get
			{
				return _80;
			}
		}

		stComplex __81;
		public stComplex _81
		{
			get
			{
				return __81;
			}
		}

		IstComplex IstHugeStructureOfComplex._81
		{
			get
			{
				return _81;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._81
		{
			get
			{
				return _81;
			}
		}

		stComplex __82;
		public stComplex _82
		{
			get
			{
				return __82;
			}
		}

		IstComplex IstHugeStructureOfComplex._82
		{
			get
			{
				return _82;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._82
		{
			get
			{
				return _82;
			}
		}

		stComplex __83;
		public stComplex _83
		{
			get
			{
				return __83;
			}
		}

		IstComplex IstHugeStructureOfComplex._83
		{
			get
			{
				return _83;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._83
		{
			get
			{
				return _83;
			}
		}

		stComplex __84;
		public stComplex _84
		{
			get
			{
				return __84;
			}
		}

		IstComplex IstHugeStructureOfComplex._84
		{
			get
			{
				return _84;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._84
		{
			get
			{
				return _84;
			}
		}

		stComplex __85;
		public stComplex _85
		{
			get
			{
				return __85;
			}
		}

		IstComplex IstHugeStructureOfComplex._85
		{
			get
			{
				return _85;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._85
		{
			get
			{
				return _85;
			}
		}

		stComplex __86;
		public stComplex _86
		{
			get
			{
				return __86;
			}
		}

		IstComplex IstHugeStructureOfComplex._86
		{
			get
			{
				return _86;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._86
		{
			get
			{
				return _86;
			}
		}

		stComplex __87;
		public stComplex _87
		{
			get
			{
				return __87;
			}
		}

		IstComplex IstHugeStructureOfComplex._87
		{
			get
			{
				return _87;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._87
		{
			get
			{
				return _87;
			}
		}

		stComplex __88;
		public stComplex _88
		{
			get
			{
				return __88;
			}
		}

		IstComplex IstHugeStructureOfComplex._88
		{
			get
			{
				return _88;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._88
		{
			get
			{
				return _88;
			}
		}

		stComplex __89;
		public stComplex _89
		{
			get
			{
				return __89;
			}
		}

		IstComplex IstHugeStructureOfComplex._89
		{
			get
			{
				return _89;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._89
		{
			get
			{
				return _89;
			}
		}

		stComplex __90;
		public stComplex _90
		{
			get
			{
				return __90;
			}
		}

		IstComplex IstHugeStructureOfComplex._90
		{
			get
			{
				return _90;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._90
		{
			get
			{
				return _90;
			}
		}

		stComplex __91;
		public stComplex _91
		{
			get
			{
				return __91;
			}
		}

		IstComplex IstHugeStructureOfComplex._91
		{
			get
			{
				return _91;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._91
		{
			get
			{
				return _91;
			}
		}

		stComplex __92;
		public stComplex _92
		{
			get
			{
				return __92;
			}
		}

		IstComplex IstHugeStructureOfComplex._92
		{
			get
			{
				return _92;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._92
		{
			get
			{
				return _92;
			}
		}

		stComplex __93;
		public stComplex _93
		{
			get
			{
				return __93;
			}
		}

		IstComplex IstHugeStructureOfComplex._93
		{
			get
			{
				return _93;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._93
		{
			get
			{
				return _93;
			}
		}

		stComplex __94;
		public stComplex _94
		{
			get
			{
				return __94;
			}
		}

		IstComplex IstHugeStructureOfComplex._94
		{
			get
			{
				return _94;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._94
		{
			get
			{
				return _94;
			}
		}

		stComplex __95;
		public stComplex _95
		{
			get
			{
				return __95;
			}
		}

		IstComplex IstHugeStructureOfComplex._95
		{
			get
			{
				return _95;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._95
		{
			get
			{
				return _95;
			}
		}

		stComplex __96;
		public stComplex _96
		{
			get
			{
				return __96;
			}
		}

		IstComplex IstHugeStructureOfComplex._96
		{
			get
			{
				return _96;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._96
		{
			get
			{
				return _96;
			}
		}

		stComplex __97;
		public stComplex _97
		{
			get
			{
				return __97;
			}
		}

		IstComplex IstHugeStructureOfComplex._97
		{
			get
			{
				return _97;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._97
		{
			get
			{
				return _97;
			}
		}

		stComplex __98;
		public stComplex _98
		{
			get
			{
				return __98;
			}
		}

		IstComplex IstHugeStructureOfComplex._98
		{
			get
			{
				return _98;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._98
		{
			get
			{
				return _98;
			}
		}

		stComplex __99;
		public stComplex _99
		{
			get
			{
				return __99;
			}
		}

		IstComplex IstHugeStructureOfComplex._99
		{
			get
			{
				return _99;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._99
		{
			get
			{
				return _99;
			}
		}

		stComplex __100;
		public stComplex _100
		{
			get
			{
				return __100;
			}
		}

		IstComplex IstHugeStructureOfComplex._100
		{
			get
			{
				return _100;
			}
		}

		IShadowstComplex IShadowstHugeStructureOfComplex._100
		{
			get
			{
				return _100;
			}
		}

		public void LazyOnlineToShadow()
		{
			_1.LazyOnlineToShadow();
			_2.LazyOnlineToShadow();
			_3.LazyOnlineToShadow();
			_4.LazyOnlineToShadow();
			_5.LazyOnlineToShadow();
			_6.LazyOnlineToShadow();
			_7.LazyOnlineToShadow();
			_8.LazyOnlineToShadow();
			_9.LazyOnlineToShadow();
			_10.LazyOnlineToShadow();
			_11.LazyOnlineToShadow();
			_12.LazyOnlineToShadow();
			_13.LazyOnlineToShadow();
			_14.LazyOnlineToShadow();
			_15.LazyOnlineToShadow();
			_16.LazyOnlineToShadow();
			_17.LazyOnlineToShadow();
			_18.LazyOnlineToShadow();
			_19.LazyOnlineToShadow();
			_20.LazyOnlineToShadow();
			_21.LazyOnlineToShadow();
			_22.LazyOnlineToShadow();
			_23.LazyOnlineToShadow();
			_24.LazyOnlineToShadow();
			_25.LazyOnlineToShadow();
			_26.LazyOnlineToShadow();
			_27.LazyOnlineToShadow();
			_28.LazyOnlineToShadow();
			_29.LazyOnlineToShadow();
			_30.LazyOnlineToShadow();
			_31.LazyOnlineToShadow();
			_32.LazyOnlineToShadow();
			_33.LazyOnlineToShadow();
			_34.LazyOnlineToShadow();
			_35.LazyOnlineToShadow();
			_36.LazyOnlineToShadow();
			_37.LazyOnlineToShadow();
			_38.LazyOnlineToShadow();
			_39.LazyOnlineToShadow();
			_40.LazyOnlineToShadow();
			_41.LazyOnlineToShadow();
			_42.LazyOnlineToShadow();
			_43.LazyOnlineToShadow();
			_44.LazyOnlineToShadow();
			_45.LazyOnlineToShadow();
			_46.LazyOnlineToShadow();
			_47.LazyOnlineToShadow();
			_48.LazyOnlineToShadow();
			_49.LazyOnlineToShadow();
			_50.LazyOnlineToShadow();
			_51.LazyOnlineToShadow();
			_52.LazyOnlineToShadow();
			_53.LazyOnlineToShadow();
			_54.LazyOnlineToShadow();
			_55.LazyOnlineToShadow();
			_56.LazyOnlineToShadow();
			_57.LazyOnlineToShadow();
			_58.LazyOnlineToShadow();
			_59.LazyOnlineToShadow();
			_60.LazyOnlineToShadow();
			_61.LazyOnlineToShadow();
			_62.LazyOnlineToShadow();
			_63.LazyOnlineToShadow();
			_64.LazyOnlineToShadow();
			_65.LazyOnlineToShadow();
			_66.LazyOnlineToShadow();
			_67.LazyOnlineToShadow();
			_68.LazyOnlineToShadow();
			_69.LazyOnlineToShadow();
			_70.LazyOnlineToShadow();
			_71.LazyOnlineToShadow();
			_72.LazyOnlineToShadow();
			_73.LazyOnlineToShadow();
			_74.LazyOnlineToShadow();
			_75.LazyOnlineToShadow();
			_76.LazyOnlineToShadow();
			_77.LazyOnlineToShadow();
			_78.LazyOnlineToShadow();
			_79.LazyOnlineToShadow();
			_80.LazyOnlineToShadow();
			_81.LazyOnlineToShadow();
			_82.LazyOnlineToShadow();
			_83.LazyOnlineToShadow();
			_84.LazyOnlineToShadow();
			_85.LazyOnlineToShadow();
			_86.LazyOnlineToShadow();
			_87.LazyOnlineToShadow();
			_88.LazyOnlineToShadow();
			_89.LazyOnlineToShadow();
			_90.LazyOnlineToShadow();
			_91.LazyOnlineToShadow();
			_92.LazyOnlineToShadow();
			_93.LazyOnlineToShadow();
			_94.LazyOnlineToShadow();
			_95.LazyOnlineToShadow();
			_96.LazyOnlineToShadow();
			_97.LazyOnlineToShadow();
			_98.LazyOnlineToShadow();
			_99.LazyOnlineToShadow();
			_100.LazyOnlineToShadow();
		}

		public void LazyShadowToOnline()
		{
			_1.LazyShadowToOnline();
			_2.LazyShadowToOnline();
			_3.LazyShadowToOnline();
			_4.LazyShadowToOnline();
			_5.LazyShadowToOnline();
			_6.LazyShadowToOnline();
			_7.LazyShadowToOnline();
			_8.LazyShadowToOnline();
			_9.LazyShadowToOnline();
			_10.LazyShadowToOnline();
			_11.LazyShadowToOnline();
			_12.LazyShadowToOnline();
			_13.LazyShadowToOnline();
			_14.LazyShadowToOnline();
			_15.LazyShadowToOnline();
			_16.LazyShadowToOnline();
			_17.LazyShadowToOnline();
			_18.LazyShadowToOnline();
			_19.LazyShadowToOnline();
			_20.LazyShadowToOnline();
			_21.LazyShadowToOnline();
			_22.LazyShadowToOnline();
			_23.LazyShadowToOnline();
			_24.LazyShadowToOnline();
			_25.LazyShadowToOnline();
			_26.LazyShadowToOnline();
			_27.LazyShadowToOnline();
			_28.LazyShadowToOnline();
			_29.LazyShadowToOnline();
			_30.LazyShadowToOnline();
			_31.LazyShadowToOnline();
			_32.LazyShadowToOnline();
			_33.LazyShadowToOnline();
			_34.LazyShadowToOnline();
			_35.LazyShadowToOnline();
			_36.LazyShadowToOnline();
			_37.LazyShadowToOnline();
			_38.LazyShadowToOnline();
			_39.LazyShadowToOnline();
			_40.LazyShadowToOnline();
			_41.LazyShadowToOnline();
			_42.LazyShadowToOnline();
			_43.LazyShadowToOnline();
			_44.LazyShadowToOnline();
			_45.LazyShadowToOnline();
			_46.LazyShadowToOnline();
			_47.LazyShadowToOnline();
			_48.LazyShadowToOnline();
			_49.LazyShadowToOnline();
			_50.LazyShadowToOnline();
			_51.LazyShadowToOnline();
			_52.LazyShadowToOnline();
			_53.LazyShadowToOnline();
			_54.LazyShadowToOnline();
			_55.LazyShadowToOnline();
			_56.LazyShadowToOnline();
			_57.LazyShadowToOnline();
			_58.LazyShadowToOnline();
			_59.LazyShadowToOnline();
			_60.LazyShadowToOnline();
			_61.LazyShadowToOnline();
			_62.LazyShadowToOnline();
			_63.LazyShadowToOnline();
			_64.LazyShadowToOnline();
			_65.LazyShadowToOnline();
			_66.LazyShadowToOnline();
			_67.LazyShadowToOnline();
			_68.LazyShadowToOnline();
			_69.LazyShadowToOnline();
			_70.LazyShadowToOnline();
			_71.LazyShadowToOnline();
			_72.LazyShadowToOnline();
			_73.LazyShadowToOnline();
			_74.LazyShadowToOnline();
			_75.LazyShadowToOnline();
			_76.LazyShadowToOnline();
			_77.LazyShadowToOnline();
			_78.LazyShadowToOnline();
			_79.LazyShadowToOnline();
			_80.LazyShadowToOnline();
			_81.LazyShadowToOnline();
			_82.LazyShadowToOnline();
			_83.LazyShadowToOnline();
			_84.LazyShadowToOnline();
			_85.LazyShadowToOnline();
			_86.LazyShadowToOnline();
			_87.LazyShadowToOnline();
			_88.LazyShadowToOnline();
			_89.LazyShadowToOnline();
			_90.LazyShadowToOnline();
			_91.LazyShadowToOnline();
			_92.LazyShadowToOnline();
			_93.LazyShadowToOnline();
			_94.LazyShadowToOnline();
			_95.LazyShadowToOnline();
			_96.LazyShadowToOnline();
			_97.LazyShadowToOnline();
			_98.LazyShadowToOnline();
			_99.LazyShadowToOnline();
			_100.LazyShadowToOnline();
		}

		public PlainstHugeStructureOfComplex CreatePlainerType()
		{
			var cloned = new PlainstHugeStructureOfComplex();
			cloned._1 = _1.CreatePlainerType();
			cloned._2 = _2.CreatePlainerType();
			cloned._3 = _3.CreatePlainerType();
			cloned._4 = _4.CreatePlainerType();
			cloned._5 = _5.CreatePlainerType();
			cloned._6 = _6.CreatePlainerType();
			cloned._7 = _7.CreatePlainerType();
			cloned._8 = _8.CreatePlainerType();
			cloned._9 = _9.CreatePlainerType();
			cloned._10 = _10.CreatePlainerType();
			cloned._11 = _11.CreatePlainerType();
			cloned._12 = _12.CreatePlainerType();
			cloned._13 = _13.CreatePlainerType();
			cloned._14 = _14.CreatePlainerType();
			cloned._15 = _15.CreatePlainerType();
			cloned._16 = _16.CreatePlainerType();
			cloned._17 = _17.CreatePlainerType();
			cloned._18 = _18.CreatePlainerType();
			cloned._19 = _19.CreatePlainerType();
			cloned._20 = _20.CreatePlainerType();
			cloned._21 = _21.CreatePlainerType();
			cloned._22 = _22.CreatePlainerType();
			cloned._23 = _23.CreatePlainerType();
			cloned._24 = _24.CreatePlainerType();
			cloned._25 = _25.CreatePlainerType();
			cloned._26 = _26.CreatePlainerType();
			cloned._27 = _27.CreatePlainerType();
			cloned._28 = _28.CreatePlainerType();
			cloned._29 = _29.CreatePlainerType();
			cloned._30 = _30.CreatePlainerType();
			cloned._31 = _31.CreatePlainerType();
			cloned._32 = _32.CreatePlainerType();
			cloned._33 = _33.CreatePlainerType();
			cloned._34 = _34.CreatePlainerType();
			cloned._35 = _35.CreatePlainerType();
			cloned._36 = _36.CreatePlainerType();
			cloned._37 = _37.CreatePlainerType();
			cloned._38 = _38.CreatePlainerType();
			cloned._39 = _39.CreatePlainerType();
			cloned._40 = _40.CreatePlainerType();
			cloned._41 = _41.CreatePlainerType();
			cloned._42 = _42.CreatePlainerType();
			cloned._43 = _43.CreatePlainerType();
			cloned._44 = _44.CreatePlainerType();
			cloned._45 = _45.CreatePlainerType();
			cloned._46 = _46.CreatePlainerType();
			cloned._47 = _47.CreatePlainerType();
			cloned._48 = _48.CreatePlainerType();
			cloned._49 = _49.CreatePlainerType();
			cloned._50 = _50.CreatePlainerType();
			cloned._51 = _51.CreatePlainerType();
			cloned._52 = _52.CreatePlainerType();
			cloned._53 = _53.CreatePlainerType();
			cloned._54 = _54.CreatePlainerType();
			cloned._55 = _55.CreatePlainerType();
			cloned._56 = _56.CreatePlainerType();
			cloned._57 = _57.CreatePlainerType();
			cloned._58 = _58.CreatePlainerType();
			cloned._59 = _59.CreatePlainerType();
			cloned._60 = _60.CreatePlainerType();
			cloned._61 = _61.CreatePlainerType();
			cloned._62 = _62.CreatePlainerType();
			cloned._63 = _63.CreatePlainerType();
			cloned._64 = _64.CreatePlainerType();
			cloned._65 = _65.CreatePlainerType();
			cloned._66 = _66.CreatePlainerType();
			cloned._67 = _67.CreatePlainerType();
			cloned._68 = _68.CreatePlainerType();
			cloned._69 = _69.CreatePlainerType();
			cloned._70 = _70.CreatePlainerType();
			cloned._71 = _71.CreatePlainerType();
			cloned._72 = _72.CreatePlainerType();
			cloned._73 = _73.CreatePlainerType();
			cloned._74 = _74.CreatePlainerType();
			cloned._75 = _75.CreatePlainerType();
			cloned._76 = _76.CreatePlainerType();
			cloned._77 = _77.CreatePlainerType();
			cloned._78 = _78.CreatePlainerType();
			cloned._79 = _79.CreatePlainerType();
			cloned._80 = _80.CreatePlainerType();
			cloned._81 = _81.CreatePlainerType();
			cloned._82 = _82.CreatePlainerType();
			cloned._83 = _83.CreatePlainerType();
			cloned._84 = _84.CreatePlainerType();
			cloned._85 = _85.CreatePlainerType();
			cloned._86 = _86.CreatePlainerType();
			cloned._87 = _87.CreatePlainerType();
			cloned._88 = _88.CreatePlainerType();
			cloned._89 = _89.CreatePlainerType();
			cloned._90 = _90.CreatePlainerType();
			cloned._91 = _91.CreatePlainerType();
			cloned._92 = _92.CreatePlainerType();
			cloned._93 = _93.CreatePlainerType();
			cloned._94 = _94.CreatePlainerType();
			cloned._95 = _95.CreatePlainerType();
			cloned._96 = _96.CreatePlainerType();
			cloned._97 = _97.CreatePlainerType();
			cloned._98 = _98.CreatePlainerType();
			cloned._99 = _99.CreatePlainerType();
			cloned._100 = _100.CreatePlainerType();
			return cloned;
		}

		protected PlainstHugeStructureOfComplex CreatePlainerType(PlainstHugeStructureOfComplex cloned)
		{
			cloned._1 = _1.CreatePlainerType();
			cloned._2 = _2.CreatePlainerType();
			cloned._3 = _3.CreatePlainerType();
			cloned._4 = _4.CreatePlainerType();
			cloned._5 = _5.CreatePlainerType();
			cloned._6 = _6.CreatePlainerType();
			cloned._7 = _7.CreatePlainerType();
			cloned._8 = _8.CreatePlainerType();
			cloned._9 = _9.CreatePlainerType();
			cloned._10 = _10.CreatePlainerType();
			cloned._11 = _11.CreatePlainerType();
			cloned._12 = _12.CreatePlainerType();
			cloned._13 = _13.CreatePlainerType();
			cloned._14 = _14.CreatePlainerType();
			cloned._15 = _15.CreatePlainerType();
			cloned._16 = _16.CreatePlainerType();
			cloned._17 = _17.CreatePlainerType();
			cloned._18 = _18.CreatePlainerType();
			cloned._19 = _19.CreatePlainerType();
			cloned._20 = _20.CreatePlainerType();
			cloned._21 = _21.CreatePlainerType();
			cloned._22 = _22.CreatePlainerType();
			cloned._23 = _23.CreatePlainerType();
			cloned._24 = _24.CreatePlainerType();
			cloned._25 = _25.CreatePlainerType();
			cloned._26 = _26.CreatePlainerType();
			cloned._27 = _27.CreatePlainerType();
			cloned._28 = _28.CreatePlainerType();
			cloned._29 = _29.CreatePlainerType();
			cloned._30 = _30.CreatePlainerType();
			cloned._31 = _31.CreatePlainerType();
			cloned._32 = _32.CreatePlainerType();
			cloned._33 = _33.CreatePlainerType();
			cloned._34 = _34.CreatePlainerType();
			cloned._35 = _35.CreatePlainerType();
			cloned._36 = _36.CreatePlainerType();
			cloned._37 = _37.CreatePlainerType();
			cloned._38 = _38.CreatePlainerType();
			cloned._39 = _39.CreatePlainerType();
			cloned._40 = _40.CreatePlainerType();
			cloned._41 = _41.CreatePlainerType();
			cloned._42 = _42.CreatePlainerType();
			cloned._43 = _43.CreatePlainerType();
			cloned._44 = _44.CreatePlainerType();
			cloned._45 = _45.CreatePlainerType();
			cloned._46 = _46.CreatePlainerType();
			cloned._47 = _47.CreatePlainerType();
			cloned._48 = _48.CreatePlainerType();
			cloned._49 = _49.CreatePlainerType();
			cloned._50 = _50.CreatePlainerType();
			cloned._51 = _51.CreatePlainerType();
			cloned._52 = _52.CreatePlainerType();
			cloned._53 = _53.CreatePlainerType();
			cloned._54 = _54.CreatePlainerType();
			cloned._55 = _55.CreatePlainerType();
			cloned._56 = _56.CreatePlainerType();
			cloned._57 = _57.CreatePlainerType();
			cloned._58 = _58.CreatePlainerType();
			cloned._59 = _59.CreatePlainerType();
			cloned._60 = _60.CreatePlainerType();
			cloned._61 = _61.CreatePlainerType();
			cloned._62 = _62.CreatePlainerType();
			cloned._63 = _63.CreatePlainerType();
			cloned._64 = _64.CreatePlainerType();
			cloned._65 = _65.CreatePlainerType();
			cloned._66 = _66.CreatePlainerType();
			cloned._67 = _67.CreatePlainerType();
			cloned._68 = _68.CreatePlainerType();
			cloned._69 = _69.CreatePlainerType();
			cloned._70 = _70.CreatePlainerType();
			cloned._71 = _71.CreatePlainerType();
			cloned._72 = _72.CreatePlainerType();
			cloned._73 = _73.CreatePlainerType();
			cloned._74 = _74.CreatePlainerType();
			cloned._75 = _75.CreatePlainerType();
			cloned._76 = _76.CreatePlainerType();
			cloned._77 = _77.CreatePlainerType();
			cloned._78 = _78.CreatePlainerType();
			cloned._79 = _79.CreatePlainerType();
			cloned._80 = _80.CreatePlainerType();
			cloned._81 = _81.CreatePlainerType();
			cloned._82 = _82.CreatePlainerType();
			cloned._83 = _83.CreatePlainerType();
			cloned._84 = _84.CreatePlainerType();
			cloned._85 = _85.CreatePlainerType();
			cloned._86 = _86.CreatePlainerType();
			cloned._87 = _87.CreatePlainerType();
			cloned._88 = _88.CreatePlainerType();
			cloned._89 = _89.CreatePlainerType();
			cloned._90 = _90.CreatePlainerType();
			cloned._91 = _91.CreatePlainerType();
			cloned._92 = _92.CreatePlainerType();
			cloned._93 = _93.CreatePlainerType();
			cloned._94 = _94.CreatePlainerType();
			cloned._95 = _95.CreatePlainerType();
			cloned._96 = _96.CreatePlainerType();
			cloned._97 = _97.CreatePlainerType();
			cloned._98 = _98.CreatePlainerType();
			cloned._99 = _99.CreatePlainerType();
			cloned._100 = _100.CreatePlainerType();
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

		public void FlushPlainToOnline(HansPlc.PlainstHugeStructureOfComplex source)
		{
			source.CopyPlainToCyclic(this);
			this.Write();
		}

		public void CopyPlainToShadow(HansPlc.PlainstHugeStructureOfComplex source)
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

		public void FlushOnlineToPlain(HansPlc.PlainstHugeStructureOfComplex source)
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

		public stHugeStructureOfComplex(Vortex.Connector.IVortexObject parent, string readableTail, string symbolTail)
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
			__1 = new stComplex(this, "", "_1");
			__2 = new stComplex(this, "", "_2");
			__3 = new stComplex(this, "", "_3");
			__4 = new stComplex(this, "", "_4");
			__5 = new stComplex(this, "", "_5");
			__6 = new stComplex(this, "", "_6");
			__7 = new stComplex(this, "", "_7");
			__8 = new stComplex(this, "", "_8");
			__9 = new stComplex(this, "", "_9");
			__10 = new stComplex(this, "", "_10");
			__11 = new stComplex(this, "", "_11");
			__12 = new stComplex(this, "", "_12");
			__13 = new stComplex(this, "", "_13");
			__14 = new stComplex(this, "", "_14");
			__15 = new stComplex(this, "", "_15");
			__16 = new stComplex(this, "", "_16");
			__17 = new stComplex(this, "", "_17");
			__18 = new stComplex(this, "", "_18");
			__19 = new stComplex(this, "", "_19");
			__20 = new stComplex(this, "", "_20");
			__21 = new stComplex(this, "", "_21");
			__22 = new stComplex(this, "", "_22");
			__23 = new stComplex(this, "", "_23");
			__24 = new stComplex(this, "", "_24");
			__25 = new stComplex(this, "", "_25");
			__26 = new stComplex(this, "", "_26");
			__27 = new stComplex(this, "", "_27");
			__28 = new stComplex(this, "", "_28");
			__29 = new stComplex(this, "", "_29");
			__30 = new stComplex(this, "", "_30");
			__31 = new stComplex(this, "", "_31");
			__32 = new stComplex(this, "", "_32");
			__33 = new stComplex(this, "", "_33");
			__34 = new stComplex(this, "", "_34");
			__35 = new stComplex(this, "", "_35");
			__36 = new stComplex(this, "", "_36");
			__37 = new stComplex(this, "", "_37");
			__38 = new stComplex(this, "", "_38");
			__39 = new stComplex(this, "", "_39");
			__40 = new stComplex(this, "", "_40");
			__41 = new stComplex(this, "", "_41");
			__42 = new stComplex(this, "", "_42");
			__43 = new stComplex(this, "", "_43");
			__44 = new stComplex(this, "", "_44");
			__45 = new stComplex(this, "", "_45");
			__46 = new stComplex(this, "", "_46");
			__47 = new stComplex(this, "", "_47");
			__48 = new stComplex(this, "", "_48");
			__49 = new stComplex(this, "", "_49");
			__50 = new stComplex(this, "", "_50");
			__51 = new stComplex(this, "", "_51");
			__52 = new stComplex(this, "", "_52");
			__53 = new stComplex(this, "", "_53");
			__54 = new stComplex(this, "", "_54");
			__55 = new stComplex(this, "", "_55");
			__56 = new stComplex(this, "", "_56");
			__57 = new stComplex(this, "", "_57");
			__58 = new stComplex(this, "", "_58");
			__59 = new stComplex(this, "", "_59");
			__60 = new stComplex(this, "", "_60");
			__61 = new stComplex(this, "", "_61");
			__62 = new stComplex(this, "", "_62");
			__63 = new stComplex(this, "", "_63");
			__64 = new stComplex(this, "", "_64");
			__65 = new stComplex(this, "", "_65");
			__66 = new stComplex(this, "", "_66");
			__67 = new stComplex(this, "", "_67");
			__68 = new stComplex(this, "", "_68");
			__69 = new stComplex(this, "", "_69");
			__70 = new stComplex(this, "", "_70");
			__71 = new stComplex(this, "", "_71");
			__72 = new stComplex(this, "", "_72");
			__73 = new stComplex(this, "", "_73");
			__74 = new stComplex(this, "", "_74");
			__75 = new stComplex(this, "", "_75");
			__76 = new stComplex(this, "", "_76");
			__77 = new stComplex(this, "", "_77");
			__78 = new stComplex(this, "", "_78");
			__79 = new stComplex(this, "", "_79");
			__80 = new stComplex(this, "", "_80");
			__81 = new stComplex(this, "", "_81");
			__82 = new stComplex(this, "", "_82");
			__83 = new stComplex(this, "", "_83");
			__84 = new stComplex(this, "", "_84");
			__85 = new stComplex(this, "", "_85");
			__86 = new stComplex(this, "", "_86");
			__87 = new stComplex(this, "", "_87");
			__88 = new stComplex(this, "", "_88");
			__89 = new stComplex(this, "", "_89");
			__90 = new stComplex(this, "", "_90");
			__91 = new stComplex(this, "", "_91");
			__92 = new stComplex(this, "", "_92");
			__93 = new stComplex(this, "", "_93");
			__94 = new stComplex(this, "", "_94");
			__95 = new stComplex(this, "", "_95");
			__96 = new stComplex(this, "", "_96");
			__97 = new stComplex(this, "", "_97");
			__98 = new stComplex(this, "", "_98");
			__99 = new stComplex(this, "", "_99");
			__100 = new stComplex(this, "", "_100");
			AttributeName = "";
			parent.AddChild(this);
			parent.AddKid(this);
			PexConstructor(parent, readableTail, symbolTail);
		}

		public stHugeStructureOfComplex()
		{
			PexPreConstructorParameterless();
			__1 = new stComplex();
			__2 = new stComplex();
			__3 = new stComplex();
			__4 = new stComplex();
			__5 = new stComplex();
			__6 = new stComplex();
			__7 = new stComplex();
			__8 = new stComplex();
			__9 = new stComplex();
			__10 = new stComplex();
			__11 = new stComplex();
			__12 = new stComplex();
			__13 = new stComplex();
			__14 = new stComplex();
			__15 = new stComplex();
			__16 = new stComplex();
			__17 = new stComplex();
			__18 = new stComplex();
			__19 = new stComplex();
			__20 = new stComplex();
			__21 = new stComplex();
			__22 = new stComplex();
			__23 = new stComplex();
			__24 = new stComplex();
			__25 = new stComplex();
			__26 = new stComplex();
			__27 = new stComplex();
			__28 = new stComplex();
			__29 = new stComplex();
			__30 = new stComplex();
			__31 = new stComplex();
			__32 = new stComplex();
			__33 = new stComplex();
			__34 = new stComplex();
			__35 = new stComplex();
			__36 = new stComplex();
			__37 = new stComplex();
			__38 = new stComplex();
			__39 = new stComplex();
			__40 = new stComplex();
			__41 = new stComplex();
			__42 = new stComplex();
			__43 = new stComplex();
			__44 = new stComplex();
			__45 = new stComplex();
			__46 = new stComplex();
			__47 = new stComplex();
			__48 = new stComplex();
			__49 = new stComplex();
			__50 = new stComplex();
			__51 = new stComplex();
			__52 = new stComplex();
			__53 = new stComplex();
			__54 = new stComplex();
			__55 = new stComplex();
			__56 = new stComplex();
			__57 = new stComplex();
			__58 = new stComplex();
			__59 = new stComplex();
			__60 = new stComplex();
			__61 = new stComplex();
			__62 = new stComplex();
			__63 = new stComplex();
			__64 = new stComplex();
			__65 = new stComplex();
			__66 = new stComplex();
			__67 = new stComplex();
			__68 = new stComplex();
			__69 = new stComplex();
			__70 = new stComplex();
			__71 = new stComplex();
			__72 = new stComplex();
			__73 = new stComplex();
			__74 = new stComplex();
			__75 = new stComplex();
			__76 = new stComplex();
			__77 = new stComplex();
			__78 = new stComplex();
			__79 = new stComplex();
			__80 = new stComplex();
			__81 = new stComplex();
			__82 = new stComplex();
			__83 = new stComplex();
			__84 = new stComplex();
			__85 = new stComplex();
			__86 = new stComplex();
			__87 = new stComplex();
			__88 = new stComplex();
			__89 = new stComplex();
			__90 = new stComplex();
			__91 = new stComplex();
			__92 = new stComplex();
			__93 = new stComplex();
			__94 = new stComplex();
			__95 = new stComplex();
			__96 = new stComplex();
			__97 = new stComplex();
			__98 = new stComplex();
			__99 = new stComplex();
			__100 = new stComplex();
			AttributeName = "";
			PexConstructorParameterless();
		}

		[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
		protected abstract class PlcstHugeStructureOfComplex
		{
			///<summary>Prevents creating instance of this class via public constructor</summary><exclude/>
			protected PlcstHugeStructureOfComplex()
			{
			}
		}
	}

	
            /// <summary>
            /// This is onliner interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IstHugeStructureOfComplex : Vortex.Connector.IVortexOnlineObject
	{
		IstComplex _1
		{
			get;
		}

		IstComplex _2
		{
			get;
		}

		IstComplex _3
		{
			get;
		}

		IstComplex _4
		{
			get;
		}

		IstComplex _5
		{
			get;
		}

		IstComplex _6
		{
			get;
		}

		IstComplex _7
		{
			get;
		}

		IstComplex _8
		{
			get;
		}

		IstComplex _9
		{
			get;
		}

		IstComplex _10
		{
			get;
		}

		IstComplex _11
		{
			get;
		}

		IstComplex _12
		{
			get;
		}

		IstComplex _13
		{
			get;
		}

		IstComplex _14
		{
			get;
		}

		IstComplex _15
		{
			get;
		}

		IstComplex _16
		{
			get;
		}

		IstComplex _17
		{
			get;
		}

		IstComplex _18
		{
			get;
		}

		IstComplex _19
		{
			get;
		}

		IstComplex _20
		{
			get;
		}

		IstComplex _21
		{
			get;
		}

		IstComplex _22
		{
			get;
		}

		IstComplex _23
		{
			get;
		}

		IstComplex _24
		{
			get;
		}

		IstComplex _25
		{
			get;
		}

		IstComplex _26
		{
			get;
		}

		IstComplex _27
		{
			get;
		}

		IstComplex _28
		{
			get;
		}

		IstComplex _29
		{
			get;
		}

		IstComplex _30
		{
			get;
		}

		IstComplex _31
		{
			get;
		}

		IstComplex _32
		{
			get;
		}

		IstComplex _33
		{
			get;
		}

		IstComplex _34
		{
			get;
		}

		IstComplex _35
		{
			get;
		}

		IstComplex _36
		{
			get;
		}

		IstComplex _37
		{
			get;
		}

		IstComplex _38
		{
			get;
		}

		IstComplex _39
		{
			get;
		}

		IstComplex _40
		{
			get;
		}

		IstComplex _41
		{
			get;
		}

		IstComplex _42
		{
			get;
		}

		IstComplex _43
		{
			get;
		}

		IstComplex _44
		{
			get;
		}

		IstComplex _45
		{
			get;
		}

		IstComplex _46
		{
			get;
		}

		IstComplex _47
		{
			get;
		}

		IstComplex _48
		{
			get;
		}

		IstComplex _49
		{
			get;
		}

		IstComplex _50
		{
			get;
		}

		IstComplex _51
		{
			get;
		}

		IstComplex _52
		{
			get;
		}

		IstComplex _53
		{
			get;
		}

		IstComplex _54
		{
			get;
		}

		IstComplex _55
		{
			get;
		}

		IstComplex _56
		{
			get;
		}

		IstComplex _57
		{
			get;
		}

		IstComplex _58
		{
			get;
		}

		IstComplex _59
		{
			get;
		}

		IstComplex _60
		{
			get;
		}

		IstComplex _61
		{
			get;
		}

		IstComplex _62
		{
			get;
		}

		IstComplex _63
		{
			get;
		}

		IstComplex _64
		{
			get;
		}

		IstComplex _65
		{
			get;
		}

		IstComplex _66
		{
			get;
		}

		IstComplex _67
		{
			get;
		}

		IstComplex _68
		{
			get;
		}

		IstComplex _69
		{
			get;
		}

		IstComplex _70
		{
			get;
		}

		IstComplex _71
		{
			get;
		}

		IstComplex _72
		{
			get;
		}

		IstComplex _73
		{
			get;
		}

		IstComplex _74
		{
			get;
		}

		IstComplex _75
		{
			get;
		}

		IstComplex _76
		{
			get;
		}

		IstComplex _77
		{
			get;
		}

		IstComplex _78
		{
			get;
		}

		IstComplex _79
		{
			get;
		}

		IstComplex _80
		{
			get;
		}

		IstComplex _81
		{
			get;
		}

		IstComplex _82
		{
			get;
		}

		IstComplex _83
		{
			get;
		}

		IstComplex _84
		{
			get;
		}

		IstComplex _85
		{
			get;
		}

		IstComplex _86
		{
			get;
		}

		IstComplex _87
		{
			get;
		}

		IstComplex _88
		{
			get;
		}

		IstComplex _89
		{
			get;
		}

		IstComplex _90
		{
			get;
		}

		IstComplex _91
		{
			get;
		}

		IstComplex _92
		{
			get;
		}

		IstComplex _93
		{
			get;
		}

		IstComplex _94
		{
			get;
		}

		IstComplex _95
		{
			get;
		}

		IstComplex _96
		{
			get;
		}

		IstComplex _97
		{
			get;
		}

		IstComplex _98
		{
			get;
		}

		IstComplex _99
		{
			get;
		}

		IstComplex _100
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		HansPlc.PlainstHugeStructureOfComplex CreatePlainerType();
		void FlushOnlineToShadow();
		void FlushPlainToOnline(HansPlc.PlainstHugeStructureOfComplex source);
		void FlushOnlineToPlain(HansPlc.PlainstHugeStructureOfComplex source);
	}

	
            /// <summary>
            /// This is shadow interface for its respective class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial interface IShadowstHugeStructureOfComplex : Vortex.Connector.IVortexShadowObject
	{
		IShadowstComplex _1
		{
			get;
		}

		IShadowstComplex _2
		{
			get;
		}

		IShadowstComplex _3
		{
			get;
		}

		IShadowstComplex _4
		{
			get;
		}

		IShadowstComplex _5
		{
			get;
		}

		IShadowstComplex _6
		{
			get;
		}

		IShadowstComplex _7
		{
			get;
		}

		IShadowstComplex _8
		{
			get;
		}

		IShadowstComplex _9
		{
			get;
		}

		IShadowstComplex _10
		{
			get;
		}

		IShadowstComplex _11
		{
			get;
		}

		IShadowstComplex _12
		{
			get;
		}

		IShadowstComplex _13
		{
			get;
		}

		IShadowstComplex _14
		{
			get;
		}

		IShadowstComplex _15
		{
			get;
		}

		IShadowstComplex _16
		{
			get;
		}

		IShadowstComplex _17
		{
			get;
		}

		IShadowstComplex _18
		{
			get;
		}

		IShadowstComplex _19
		{
			get;
		}

		IShadowstComplex _20
		{
			get;
		}

		IShadowstComplex _21
		{
			get;
		}

		IShadowstComplex _22
		{
			get;
		}

		IShadowstComplex _23
		{
			get;
		}

		IShadowstComplex _24
		{
			get;
		}

		IShadowstComplex _25
		{
			get;
		}

		IShadowstComplex _26
		{
			get;
		}

		IShadowstComplex _27
		{
			get;
		}

		IShadowstComplex _28
		{
			get;
		}

		IShadowstComplex _29
		{
			get;
		}

		IShadowstComplex _30
		{
			get;
		}

		IShadowstComplex _31
		{
			get;
		}

		IShadowstComplex _32
		{
			get;
		}

		IShadowstComplex _33
		{
			get;
		}

		IShadowstComplex _34
		{
			get;
		}

		IShadowstComplex _35
		{
			get;
		}

		IShadowstComplex _36
		{
			get;
		}

		IShadowstComplex _37
		{
			get;
		}

		IShadowstComplex _38
		{
			get;
		}

		IShadowstComplex _39
		{
			get;
		}

		IShadowstComplex _40
		{
			get;
		}

		IShadowstComplex _41
		{
			get;
		}

		IShadowstComplex _42
		{
			get;
		}

		IShadowstComplex _43
		{
			get;
		}

		IShadowstComplex _44
		{
			get;
		}

		IShadowstComplex _45
		{
			get;
		}

		IShadowstComplex _46
		{
			get;
		}

		IShadowstComplex _47
		{
			get;
		}

		IShadowstComplex _48
		{
			get;
		}

		IShadowstComplex _49
		{
			get;
		}

		IShadowstComplex _50
		{
			get;
		}

		IShadowstComplex _51
		{
			get;
		}

		IShadowstComplex _52
		{
			get;
		}

		IShadowstComplex _53
		{
			get;
		}

		IShadowstComplex _54
		{
			get;
		}

		IShadowstComplex _55
		{
			get;
		}

		IShadowstComplex _56
		{
			get;
		}

		IShadowstComplex _57
		{
			get;
		}

		IShadowstComplex _58
		{
			get;
		}

		IShadowstComplex _59
		{
			get;
		}

		IShadowstComplex _60
		{
			get;
		}

		IShadowstComplex _61
		{
			get;
		}

		IShadowstComplex _62
		{
			get;
		}

		IShadowstComplex _63
		{
			get;
		}

		IShadowstComplex _64
		{
			get;
		}

		IShadowstComplex _65
		{
			get;
		}

		IShadowstComplex _66
		{
			get;
		}

		IShadowstComplex _67
		{
			get;
		}

		IShadowstComplex _68
		{
			get;
		}

		IShadowstComplex _69
		{
			get;
		}

		IShadowstComplex _70
		{
			get;
		}

		IShadowstComplex _71
		{
			get;
		}

		IShadowstComplex _72
		{
			get;
		}

		IShadowstComplex _73
		{
			get;
		}

		IShadowstComplex _74
		{
			get;
		}

		IShadowstComplex _75
		{
			get;
		}

		IShadowstComplex _76
		{
			get;
		}

		IShadowstComplex _77
		{
			get;
		}

		IShadowstComplex _78
		{
			get;
		}

		IShadowstComplex _79
		{
			get;
		}

		IShadowstComplex _80
		{
			get;
		}

		IShadowstComplex _81
		{
			get;
		}

		IShadowstComplex _82
		{
			get;
		}

		IShadowstComplex _83
		{
			get;
		}

		IShadowstComplex _84
		{
			get;
		}

		IShadowstComplex _85
		{
			get;
		}

		IShadowstComplex _86
		{
			get;
		}

		IShadowstComplex _87
		{
			get;
		}

		IShadowstComplex _88
		{
			get;
		}

		IShadowstComplex _89
		{
			get;
		}

		IShadowstComplex _90
		{
			get;
		}

		IShadowstComplex _91
		{
			get;
		}

		IShadowstComplex _92
		{
			get;
		}

		IShadowstComplex _93
		{
			get;
		}

		IShadowstComplex _94
		{
			get;
		}

		IShadowstComplex _95
		{
			get;
		}

		IShadowstComplex _96
		{
			get;
		}

		IShadowstComplex _97
		{
			get;
		}

		IShadowstComplex _98
		{
			get;
		}

		IShadowstComplex _99
		{
			get;
		}

		IShadowstComplex _100
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		HansPlc.PlainstHugeStructureOfComplex CreatePlainerType();
		void FlushShadowToOnline();
		void CopyPlainToShadow(HansPlc.PlainstHugeStructureOfComplex source);
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainstHugeStructureOfComplex : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		PlainstComplex __1;
		public PlainstComplex _1
		{
			get
			{
				return __1;
			}

			set
			{
				if (__1 != value)
				{
					__1 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_1)));
				}
			}
		}

		PlainstComplex __2;
		public PlainstComplex _2
		{
			get
			{
				return __2;
			}

			set
			{
				if (__2 != value)
				{
					__2 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_2)));
				}
			}
		}

		PlainstComplex __3;
		public PlainstComplex _3
		{
			get
			{
				return __3;
			}

			set
			{
				if (__3 != value)
				{
					__3 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_3)));
				}
			}
		}

		PlainstComplex __4;
		public PlainstComplex _4
		{
			get
			{
				return __4;
			}

			set
			{
				if (__4 != value)
				{
					__4 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_4)));
				}
			}
		}

		PlainstComplex __5;
		public PlainstComplex _5
		{
			get
			{
				return __5;
			}

			set
			{
				if (__5 != value)
				{
					__5 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_5)));
				}
			}
		}

		PlainstComplex __6;
		public PlainstComplex _6
		{
			get
			{
				return __6;
			}

			set
			{
				if (__6 != value)
				{
					__6 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_6)));
				}
			}
		}

		PlainstComplex __7;
		public PlainstComplex _7
		{
			get
			{
				return __7;
			}

			set
			{
				if (__7 != value)
				{
					__7 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_7)));
				}
			}
		}

		PlainstComplex __8;
		public PlainstComplex _8
		{
			get
			{
				return __8;
			}

			set
			{
				if (__8 != value)
				{
					__8 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_8)));
				}
			}
		}

		PlainstComplex __9;
		public PlainstComplex _9
		{
			get
			{
				return __9;
			}

			set
			{
				if (__9 != value)
				{
					__9 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_9)));
				}
			}
		}

		PlainstComplex __10;
		public PlainstComplex _10
		{
			get
			{
				return __10;
			}

			set
			{
				if (__10 != value)
				{
					__10 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_10)));
				}
			}
		}

		PlainstComplex __11;
		public PlainstComplex _11
		{
			get
			{
				return __11;
			}

			set
			{
				if (__11 != value)
				{
					__11 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_11)));
				}
			}
		}

		PlainstComplex __12;
		public PlainstComplex _12
		{
			get
			{
				return __12;
			}

			set
			{
				if (__12 != value)
				{
					__12 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_12)));
				}
			}
		}

		PlainstComplex __13;
		public PlainstComplex _13
		{
			get
			{
				return __13;
			}

			set
			{
				if (__13 != value)
				{
					__13 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_13)));
				}
			}
		}

		PlainstComplex __14;
		public PlainstComplex _14
		{
			get
			{
				return __14;
			}

			set
			{
				if (__14 != value)
				{
					__14 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_14)));
				}
			}
		}

		PlainstComplex __15;
		public PlainstComplex _15
		{
			get
			{
				return __15;
			}

			set
			{
				if (__15 != value)
				{
					__15 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_15)));
				}
			}
		}

		PlainstComplex __16;
		public PlainstComplex _16
		{
			get
			{
				return __16;
			}

			set
			{
				if (__16 != value)
				{
					__16 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_16)));
				}
			}
		}

		PlainstComplex __17;
		public PlainstComplex _17
		{
			get
			{
				return __17;
			}

			set
			{
				if (__17 != value)
				{
					__17 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_17)));
				}
			}
		}

		PlainstComplex __18;
		public PlainstComplex _18
		{
			get
			{
				return __18;
			}

			set
			{
				if (__18 != value)
				{
					__18 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_18)));
				}
			}
		}

		PlainstComplex __19;
		public PlainstComplex _19
		{
			get
			{
				return __19;
			}

			set
			{
				if (__19 != value)
				{
					__19 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_19)));
				}
			}
		}

		PlainstComplex __20;
		public PlainstComplex _20
		{
			get
			{
				return __20;
			}

			set
			{
				if (__20 != value)
				{
					__20 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_20)));
				}
			}
		}

		PlainstComplex __21;
		public PlainstComplex _21
		{
			get
			{
				return __21;
			}

			set
			{
				if (__21 != value)
				{
					__21 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_21)));
				}
			}
		}

		PlainstComplex __22;
		public PlainstComplex _22
		{
			get
			{
				return __22;
			}

			set
			{
				if (__22 != value)
				{
					__22 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_22)));
				}
			}
		}

		PlainstComplex __23;
		public PlainstComplex _23
		{
			get
			{
				return __23;
			}

			set
			{
				if (__23 != value)
				{
					__23 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_23)));
				}
			}
		}

		PlainstComplex __24;
		public PlainstComplex _24
		{
			get
			{
				return __24;
			}

			set
			{
				if (__24 != value)
				{
					__24 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_24)));
				}
			}
		}

		PlainstComplex __25;
		public PlainstComplex _25
		{
			get
			{
				return __25;
			}

			set
			{
				if (__25 != value)
				{
					__25 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_25)));
				}
			}
		}

		PlainstComplex __26;
		public PlainstComplex _26
		{
			get
			{
				return __26;
			}

			set
			{
				if (__26 != value)
				{
					__26 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_26)));
				}
			}
		}

		PlainstComplex __27;
		public PlainstComplex _27
		{
			get
			{
				return __27;
			}

			set
			{
				if (__27 != value)
				{
					__27 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_27)));
				}
			}
		}

		PlainstComplex __28;
		public PlainstComplex _28
		{
			get
			{
				return __28;
			}

			set
			{
				if (__28 != value)
				{
					__28 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_28)));
				}
			}
		}

		PlainstComplex __29;
		public PlainstComplex _29
		{
			get
			{
				return __29;
			}

			set
			{
				if (__29 != value)
				{
					__29 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_29)));
				}
			}
		}

		PlainstComplex __30;
		public PlainstComplex _30
		{
			get
			{
				return __30;
			}

			set
			{
				if (__30 != value)
				{
					__30 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_30)));
				}
			}
		}

		PlainstComplex __31;
		public PlainstComplex _31
		{
			get
			{
				return __31;
			}

			set
			{
				if (__31 != value)
				{
					__31 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_31)));
				}
			}
		}

		PlainstComplex __32;
		public PlainstComplex _32
		{
			get
			{
				return __32;
			}

			set
			{
				if (__32 != value)
				{
					__32 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_32)));
				}
			}
		}

		PlainstComplex __33;
		public PlainstComplex _33
		{
			get
			{
				return __33;
			}

			set
			{
				if (__33 != value)
				{
					__33 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_33)));
				}
			}
		}

		PlainstComplex __34;
		public PlainstComplex _34
		{
			get
			{
				return __34;
			}

			set
			{
				if (__34 != value)
				{
					__34 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_34)));
				}
			}
		}

		PlainstComplex __35;
		public PlainstComplex _35
		{
			get
			{
				return __35;
			}

			set
			{
				if (__35 != value)
				{
					__35 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_35)));
				}
			}
		}

		PlainstComplex __36;
		public PlainstComplex _36
		{
			get
			{
				return __36;
			}

			set
			{
				if (__36 != value)
				{
					__36 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_36)));
				}
			}
		}

		PlainstComplex __37;
		public PlainstComplex _37
		{
			get
			{
				return __37;
			}

			set
			{
				if (__37 != value)
				{
					__37 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_37)));
				}
			}
		}

		PlainstComplex __38;
		public PlainstComplex _38
		{
			get
			{
				return __38;
			}

			set
			{
				if (__38 != value)
				{
					__38 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_38)));
				}
			}
		}

		PlainstComplex __39;
		public PlainstComplex _39
		{
			get
			{
				return __39;
			}

			set
			{
				if (__39 != value)
				{
					__39 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_39)));
				}
			}
		}

		PlainstComplex __40;
		public PlainstComplex _40
		{
			get
			{
				return __40;
			}

			set
			{
				if (__40 != value)
				{
					__40 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_40)));
				}
			}
		}

		PlainstComplex __41;
		public PlainstComplex _41
		{
			get
			{
				return __41;
			}

			set
			{
				if (__41 != value)
				{
					__41 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_41)));
				}
			}
		}

		PlainstComplex __42;
		public PlainstComplex _42
		{
			get
			{
				return __42;
			}

			set
			{
				if (__42 != value)
				{
					__42 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_42)));
				}
			}
		}

		PlainstComplex __43;
		public PlainstComplex _43
		{
			get
			{
				return __43;
			}

			set
			{
				if (__43 != value)
				{
					__43 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_43)));
				}
			}
		}

		PlainstComplex __44;
		public PlainstComplex _44
		{
			get
			{
				return __44;
			}

			set
			{
				if (__44 != value)
				{
					__44 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_44)));
				}
			}
		}

		PlainstComplex __45;
		public PlainstComplex _45
		{
			get
			{
				return __45;
			}

			set
			{
				if (__45 != value)
				{
					__45 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_45)));
				}
			}
		}

		PlainstComplex __46;
		public PlainstComplex _46
		{
			get
			{
				return __46;
			}

			set
			{
				if (__46 != value)
				{
					__46 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_46)));
				}
			}
		}

		PlainstComplex __47;
		public PlainstComplex _47
		{
			get
			{
				return __47;
			}

			set
			{
				if (__47 != value)
				{
					__47 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_47)));
				}
			}
		}

		PlainstComplex __48;
		public PlainstComplex _48
		{
			get
			{
				return __48;
			}

			set
			{
				if (__48 != value)
				{
					__48 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_48)));
				}
			}
		}

		PlainstComplex __49;
		public PlainstComplex _49
		{
			get
			{
				return __49;
			}

			set
			{
				if (__49 != value)
				{
					__49 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_49)));
				}
			}
		}

		PlainstComplex __50;
		public PlainstComplex _50
		{
			get
			{
				return __50;
			}

			set
			{
				if (__50 != value)
				{
					__50 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_50)));
				}
			}
		}

		PlainstComplex __51;
		public PlainstComplex _51
		{
			get
			{
				return __51;
			}

			set
			{
				if (__51 != value)
				{
					__51 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_51)));
				}
			}
		}

		PlainstComplex __52;
		public PlainstComplex _52
		{
			get
			{
				return __52;
			}

			set
			{
				if (__52 != value)
				{
					__52 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_52)));
				}
			}
		}

		PlainstComplex __53;
		public PlainstComplex _53
		{
			get
			{
				return __53;
			}

			set
			{
				if (__53 != value)
				{
					__53 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_53)));
				}
			}
		}

		PlainstComplex __54;
		public PlainstComplex _54
		{
			get
			{
				return __54;
			}

			set
			{
				if (__54 != value)
				{
					__54 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_54)));
				}
			}
		}

		PlainstComplex __55;
		public PlainstComplex _55
		{
			get
			{
				return __55;
			}

			set
			{
				if (__55 != value)
				{
					__55 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_55)));
				}
			}
		}

		PlainstComplex __56;
		public PlainstComplex _56
		{
			get
			{
				return __56;
			}

			set
			{
				if (__56 != value)
				{
					__56 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_56)));
				}
			}
		}

		PlainstComplex __57;
		public PlainstComplex _57
		{
			get
			{
				return __57;
			}

			set
			{
				if (__57 != value)
				{
					__57 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_57)));
				}
			}
		}

		PlainstComplex __58;
		public PlainstComplex _58
		{
			get
			{
				return __58;
			}

			set
			{
				if (__58 != value)
				{
					__58 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_58)));
				}
			}
		}

		PlainstComplex __59;
		public PlainstComplex _59
		{
			get
			{
				return __59;
			}

			set
			{
				if (__59 != value)
				{
					__59 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_59)));
				}
			}
		}

		PlainstComplex __60;
		public PlainstComplex _60
		{
			get
			{
				return __60;
			}

			set
			{
				if (__60 != value)
				{
					__60 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_60)));
				}
			}
		}

		PlainstComplex __61;
		public PlainstComplex _61
		{
			get
			{
				return __61;
			}

			set
			{
				if (__61 != value)
				{
					__61 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_61)));
				}
			}
		}

		PlainstComplex __62;
		public PlainstComplex _62
		{
			get
			{
				return __62;
			}

			set
			{
				if (__62 != value)
				{
					__62 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_62)));
				}
			}
		}

		PlainstComplex __63;
		public PlainstComplex _63
		{
			get
			{
				return __63;
			}

			set
			{
				if (__63 != value)
				{
					__63 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_63)));
				}
			}
		}

		PlainstComplex __64;
		public PlainstComplex _64
		{
			get
			{
				return __64;
			}

			set
			{
				if (__64 != value)
				{
					__64 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_64)));
				}
			}
		}

		PlainstComplex __65;
		public PlainstComplex _65
		{
			get
			{
				return __65;
			}

			set
			{
				if (__65 != value)
				{
					__65 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_65)));
				}
			}
		}

		PlainstComplex __66;
		public PlainstComplex _66
		{
			get
			{
				return __66;
			}

			set
			{
				if (__66 != value)
				{
					__66 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_66)));
				}
			}
		}

		PlainstComplex __67;
		public PlainstComplex _67
		{
			get
			{
				return __67;
			}

			set
			{
				if (__67 != value)
				{
					__67 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_67)));
				}
			}
		}

		PlainstComplex __68;
		public PlainstComplex _68
		{
			get
			{
				return __68;
			}

			set
			{
				if (__68 != value)
				{
					__68 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_68)));
				}
			}
		}

		PlainstComplex __69;
		public PlainstComplex _69
		{
			get
			{
				return __69;
			}

			set
			{
				if (__69 != value)
				{
					__69 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_69)));
				}
			}
		}

		PlainstComplex __70;
		public PlainstComplex _70
		{
			get
			{
				return __70;
			}

			set
			{
				if (__70 != value)
				{
					__70 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_70)));
				}
			}
		}

		PlainstComplex __71;
		public PlainstComplex _71
		{
			get
			{
				return __71;
			}

			set
			{
				if (__71 != value)
				{
					__71 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_71)));
				}
			}
		}

		PlainstComplex __72;
		public PlainstComplex _72
		{
			get
			{
				return __72;
			}

			set
			{
				if (__72 != value)
				{
					__72 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_72)));
				}
			}
		}

		PlainstComplex __73;
		public PlainstComplex _73
		{
			get
			{
				return __73;
			}

			set
			{
				if (__73 != value)
				{
					__73 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_73)));
				}
			}
		}

		PlainstComplex __74;
		public PlainstComplex _74
		{
			get
			{
				return __74;
			}

			set
			{
				if (__74 != value)
				{
					__74 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_74)));
				}
			}
		}

		PlainstComplex __75;
		public PlainstComplex _75
		{
			get
			{
				return __75;
			}

			set
			{
				if (__75 != value)
				{
					__75 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_75)));
				}
			}
		}

		PlainstComplex __76;
		public PlainstComplex _76
		{
			get
			{
				return __76;
			}

			set
			{
				if (__76 != value)
				{
					__76 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_76)));
				}
			}
		}

		PlainstComplex __77;
		public PlainstComplex _77
		{
			get
			{
				return __77;
			}

			set
			{
				if (__77 != value)
				{
					__77 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_77)));
				}
			}
		}

		PlainstComplex __78;
		public PlainstComplex _78
		{
			get
			{
				return __78;
			}

			set
			{
				if (__78 != value)
				{
					__78 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_78)));
				}
			}
		}

		PlainstComplex __79;
		public PlainstComplex _79
		{
			get
			{
				return __79;
			}

			set
			{
				if (__79 != value)
				{
					__79 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_79)));
				}
			}
		}

		PlainstComplex __80;
		public PlainstComplex _80
		{
			get
			{
				return __80;
			}

			set
			{
				if (__80 != value)
				{
					__80 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_80)));
				}
			}
		}

		PlainstComplex __81;
		public PlainstComplex _81
		{
			get
			{
				return __81;
			}

			set
			{
				if (__81 != value)
				{
					__81 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_81)));
				}
			}
		}

		PlainstComplex __82;
		public PlainstComplex _82
		{
			get
			{
				return __82;
			}

			set
			{
				if (__82 != value)
				{
					__82 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_82)));
				}
			}
		}

		PlainstComplex __83;
		public PlainstComplex _83
		{
			get
			{
				return __83;
			}

			set
			{
				if (__83 != value)
				{
					__83 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_83)));
				}
			}
		}

		PlainstComplex __84;
		public PlainstComplex _84
		{
			get
			{
				return __84;
			}

			set
			{
				if (__84 != value)
				{
					__84 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_84)));
				}
			}
		}

		PlainstComplex __85;
		public PlainstComplex _85
		{
			get
			{
				return __85;
			}

			set
			{
				if (__85 != value)
				{
					__85 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_85)));
				}
			}
		}

		PlainstComplex __86;
		public PlainstComplex _86
		{
			get
			{
				return __86;
			}

			set
			{
				if (__86 != value)
				{
					__86 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_86)));
				}
			}
		}

		PlainstComplex __87;
		public PlainstComplex _87
		{
			get
			{
				return __87;
			}

			set
			{
				if (__87 != value)
				{
					__87 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_87)));
				}
			}
		}

		PlainstComplex __88;
		public PlainstComplex _88
		{
			get
			{
				return __88;
			}

			set
			{
				if (__88 != value)
				{
					__88 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_88)));
				}
			}
		}

		PlainstComplex __89;
		public PlainstComplex _89
		{
			get
			{
				return __89;
			}

			set
			{
				if (__89 != value)
				{
					__89 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_89)));
				}
			}
		}

		PlainstComplex __90;
		public PlainstComplex _90
		{
			get
			{
				return __90;
			}

			set
			{
				if (__90 != value)
				{
					__90 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_90)));
				}
			}
		}

		PlainstComplex __91;
		public PlainstComplex _91
		{
			get
			{
				return __91;
			}

			set
			{
				if (__91 != value)
				{
					__91 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_91)));
				}
			}
		}

		PlainstComplex __92;
		public PlainstComplex _92
		{
			get
			{
				return __92;
			}

			set
			{
				if (__92 != value)
				{
					__92 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_92)));
				}
			}
		}

		PlainstComplex __93;
		public PlainstComplex _93
		{
			get
			{
				return __93;
			}

			set
			{
				if (__93 != value)
				{
					__93 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_93)));
				}
			}
		}

		PlainstComplex __94;
		public PlainstComplex _94
		{
			get
			{
				return __94;
			}

			set
			{
				if (__94 != value)
				{
					__94 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_94)));
				}
			}
		}

		PlainstComplex __95;
		public PlainstComplex _95
		{
			get
			{
				return __95;
			}

			set
			{
				if (__95 != value)
				{
					__95 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_95)));
				}
			}
		}

		PlainstComplex __96;
		public PlainstComplex _96
		{
			get
			{
				return __96;
			}

			set
			{
				if (__96 != value)
				{
					__96 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_96)));
				}
			}
		}

		PlainstComplex __97;
		public PlainstComplex _97
		{
			get
			{
				return __97;
			}

			set
			{
				if (__97 != value)
				{
					__97 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_97)));
				}
			}
		}

		PlainstComplex __98;
		public PlainstComplex _98
		{
			get
			{
				return __98;
			}

			set
			{
				if (__98 != value)
				{
					__98 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_98)));
				}
			}
		}

		PlainstComplex __99;
		public PlainstComplex _99
		{
			get
			{
				return __99;
			}

			set
			{
				if (__99 != value)
				{
					__99 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_99)));
				}
			}
		}

		PlainstComplex __100;
		public PlainstComplex _100
		{
			get
			{
				return __100;
			}

			set
			{
				if (__100 != value)
				{
					__100 = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(_100)));
				}
			}
		}

		public void CopyPlainToCyclic(HansPlc.stHugeStructureOfComplex target)
		{
			_1.CopyPlainToCyclic(target._1);
			_2.CopyPlainToCyclic(target._2);
			_3.CopyPlainToCyclic(target._3);
			_4.CopyPlainToCyclic(target._4);
			_5.CopyPlainToCyclic(target._5);
			_6.CopyPlainToCyclic(target._6);
			_7.CopyPlainToCyclic(target._7);
			_8.CopyPlainToCyclic(target._8);
			_9.CopyPlainToCyclic(target._9);
			_10.CopyPlainToCyclic(target._10);
			_11.CopyPlainToCyclic(target._11);
			_12.CopyPlainToCyclic(target._12);
			_13.CopyPlainToCyclic(target._13);
			_14.CopyPlainToCyclic(target._14);
			_15.CopyPlainToCyclic(target._15);
			_16.CopyPlainToCyclic(target._16);
			_17.CopyPlainToCyclic(target._17);
			_18.CopyPlainToCyclic(target._18);
			_19.CopyPlainToCyclic(target._19);
			_20.CopyPlainToCyclic(target._20);
			_21.CopyPlainToCyclic(target._21);
			_22.CopyPlainToCyclic(target._22);
			_23.CopyPlainToCyclic(target._23);
			_24.CopyPlainToCyclic(target._24);
			_25.CopyPlainToCyclic(target._25);
			_26.CopyPlainToCyclic(target._26);
			_27.CopyPlainToCyclic(target._27);
			_28.CopyPlainToCyclic(target._28);
			_29.CopyPlainToCyclic(target._29);
			_30.CopyPlainToCyclic(target._30);
			_31.CopyPlainToCyclic(target._31);
			_32.CopyPlainToCyclic(target._32);
			_33.CopyPlainToCyclic(target._33);
			_34.CopyPlainToCyclic(target._34);
			_35.CopyPlainToCyclic(target._35);
			_36.CopyPlainToCyclic(target._36);
			_37.CopyPlainToCyclic(target._37);
			_38.CopyPlainToCyclic(target._38);
			_39.CopyPlainToCyclic(target._39);
			_40.CopyPlainToCyclic(target._40);
			_41.CopyPlainToCyclic(target._41);
			_42.CopyPlainToCyclic(target._42);
			_43.CopyPlainToCyclic(target._43);
			_44.CopyPlainToCyclic(target._44);
			_45.CopyPlainToCyclic(target._45);
			_46.CopyPlainToCyclic(target._46);
			_47.CopyPlainToCyclic(target._47);
			_48.CopyPlainToCyclic(target._48);
			_49.CopyPlainToCyclic(target._49);
			_50.CopyPlainToCyclic(target._50);
			_51.CopyPlainToCyclic(target._51);
			_52.CopyPlainToCyclic(target._52);
			_53.CopyPlainToCyclic(target._53);
			_54.CopyPlainToCyclic(target._54);
			_55.CopyPlainToCyclic(target._55);
			_56.CopyPlainToCyclic(target._56);
			_57.CopyPlainToCyclic(target._57);
			_58.CopyPlainToCyclic(target._58);
			_59.CopyPlainToCyclic(target._59);
			_60.CopyPlainToCyclic(target._60);
			_61.CopyPlainToCyclic(target._61);
			_62.CopyPlainToCyclic(target._62);
			_63.CopyPlainToCyclic(target._63);
			_64.CopyPlainToCyclic(target._64);
			_65.CopyPlainToCyclic(target._65);
			_66.CopyPlainToCyclic(target._66);
			_67.CopyPlainToCyclic(target._67);
			_68.CopyPlainToCyclic(target._68);
			_69.CopyPlainToCyclic(target._69);
			_70.CopyPlainToCyclic(target._70);
			_71.CopyPlainToCyclic(target._71);
			_72.CopyPlainToCyclic(target._72);
			_73.CopyPlainToCyclic(target._73);
			_74.CopyPlainToCyclic(target._74);
			_75.CopyPlainToCyclic(target._75);
			_76.CopyPlainToCyclic(target._76);
			_77.CopyPlainToCyclic(target._77);
			_78.CopyPlainToCyclic(target._78);
			_79.CopyPlainToCyclic(target._79);
			_80.CopyPlainToCyclic(target._80);
			_81.CopyPlainToCyclic(target._81);
			_82.CopyPlainToCyclic(target._82);
			_83.CopyPlainToCyclic(target._83);
			_84.CopyPlainToCyclic(target._84);
			_85.CopyPlainToCyclic(target._85);
			_86.CopyPlainToCyclic(target._86);
			_87.CopyPlainToCyclic(target._87);
			_88.CopyPlainToCyclic(target._88);
			_89.CopyPlainToCyclic(target._89);
			_90.CopyPlainToCyclic(target._90);
			_91.CopyPlainToCyclic(target._91);
			_92.CopyPlainToCyclic(target._92);
			_93.CopyPlainToCyclic(target._93);
			_94.CopyPlainToCyclic(target._94);
			_95.CopyPlainToCyclic(target._95);
			_96.CopyPlainToCyclic(target._96);
			_97.CopyPlainToCyclic(target._97);
			_98.CopyPlainToCyclic(target._98);
			_99.CopyPlainToCyclic(target._99);
			_100.CopyPlainToCyclic(target._100);
		}

		public void CopyPlainToCyclic(HansPlc.IstHugeStructureOfComplex target)
		{
			this.CopyPlainToCyclic((HansPlc.stHugeStructureOfComplex)target);
		}

		public void CopyPlainToShadow(HansPlc.stHugeStructureOfComplex target)
		{
			_1.CopyPlainToShadow(target._1);
			_2.CopyPlainToShadow(target._2);
			_3.CopyPlainToShadow(target._3);
			_4.CopyPlainToShadow(target._4);
			_5.CopyPlainToShadow(target._5);
			_6.CopyPlainToShadow(target._6);
			_7.CopyPlainToShadow(target._7);
			_8.CopyPlainToShadow(target._8);
			_9.CopyPlainToShadow(target._9);
			_10.CopyPlainToShadow(target._10);
			_11.CopyPlainToShadow(target._11);
			_12.CopyPlainToShadow(target._12);
			_13.CopyPlainToShadow(target._13);
			_14.CopyPlainToShadow(target._14);
			_15.CopyPlainToShadow(target._15);
			_16.CopyPlainToShadow(target._16);
			_17.CopyPlainToShadow(target._17);
			_18.CopyPlainToShadow(target._18);
			_19.CopyPlainToShadow(target._19);
			_20.CopyPlainToShadow(target._20);
			_21.CopyPlainToShadow(target._21);
			_22.CopyPlainToShadow(target._22);
			_23.CopyPlainToShadow(target._23);
			_24.CopyPlainToShadow(target._24);
			_25.CopyPlainToShadow(target._25);
			_26.CopyPlainToShadow(target._26);
			_27.CopyPlainToShadow(target._27);
			_28.CopyPlainToShadow(target._28);
			_29.CopyPlainToShadow(target._29);
			_30.CopyPlainToShadow(target._30);
			_31.CopyPlainToShadow(target._31);
			_32.CopyPlainToShadow(target._32);
			_33.CopyPlainToShadow(target._33);
			_34.CopyPlainToShadow(target._34);
			_35.CopyPlainToShadow(target._35);
			_36.CopyPlainToShadow(target._36);
			_37.CopyPlainToShadow(target._37);
			_38.CopyPlainToShadow(target._38);
			_39.CopyPlainToShadow(target._39);
			_40.CopyPlainToShadow(target._40);
			_41.CopyPlainToShadow(target._41);
			_42.CopyPlainToShadow(target._42);
			_43.CopyPlainToShadow(target._43);
			_44.CopyPlainToShadow(target._44);
			_45.CopyPlainToShadow(target._45);
			_46.CopyPlainToShadow(target._46);
			_47.CopyPlainToShadow(target._47);
			_48.CopyPlainToShadow(target._48);
			_49.CopyPlainToShadow(target._49);
			_50.CopyPlainToShadow(target._50);
			_51.CopyPlainToShadow(target._51);
			_52.CopyPlainToShadow(target._52);
			_53.CopyPlainToShadow(target._53);
			_54.CopyPlainToShadow(target._54);
			_55.CopyPlainToShadow(target._55);
			_56.CopyPlainToShadow(target._56);
			_57.CopyPlainToShadow(target._57);
			_58.CopyPlainToShadow(target._58);
			_59.CopyPlainToShadow(target._59);
			_60.CopyPlainToShadow(target._60);
			_61.CopyPlainToShadow(target._61);
			_62.CopyPlainToShadow(target._62);
			_63.CopyPlainToShadow(target._63);
			_64.CopyPlainToShadow(target._64);
			_65.CopyPlainToShadow(target._65);
			_66.CopyPlainToShadow(target._66);
			_67.CopyPlainToShadow(target._67);
			_68.CopyPlainToShadow(target._68);
			_69.CopyPlainToShadow(target._69);
			_70.CopyPlainToShadow(target._70);
			_71.CopyPlainToShadow(target._71);
			_72.CopyPlainToShadow(target._72);
			_73.CopyPlainToShadow(target._73);
			_74.CopyPlainToShadow(target._74);
			_75.CopyPlainToShadow(target._75);
			_76.CopyPlainToShadow(target._76);
			_77.CopyPlainToShadow(target._77);
			_78.CopyPlainToShadow(target._78);
			_79.CopyPlainToShadow(target._79);
			_80.CopyPlainToShadow(target._80);
			_81.CopyPlainToShadow(target._81);
			_82.CopyPlainToShadow(target._82);
			_83.CopyPlainToShadow(target._83);
			_84.CopyPlainToShadow(target._84);
			_85.CopyPlainToShadow(target._85);
			_86.CopyPlainToShadow(target._86);
			_87.CopyPlainToShadow(target._87);
			_88.CopyPlainToShadow(target._88);
			_89.CopyPlainToShadow(target._89);
			_90.CopyPlainToShadow(target._90);
			_91.CopyPlainToShadow(target._91);
			_92.CopyPlainToShadow(target._92);
			_93.CopyPlainToShadow(target._93);
			_94.CopyPlainToShadow(target._94);
			_95.CopyPlainToShadow(target._95);
			_96.CopyPlainToShadow(target._96);
			_97.CopyPlainToShadow(target._97);
			_98.CopyPlainToShadow(target._98);
			_99.CopyPlainToShadow(target._99);
			_100.CopyPlainToShadow(target._100);
		}

		public void CopyPlainToShadow(HansPlc.IShadowstHugeStructureOfComplex target)
		{
			this.CopyPlainToShadow((HansPlc.stHugeStructureOfComplex)target);
		}

		public void CopyCyclicToPlain(HansPlc.stHugeStructureOfComplex source)
		{
			_1.CopyCyclicToPlain(source._1);
			_2.CopyCyclicToPlain(source._2);
			_3.CopyCyclicToPlain(source._3);
			_4.CopyCyclicToPlain(source._4);
			_5.CopyCyclicToPlain(source._5);
			_6.CopyCyclicToPlain(source._6);
			_7.CopyCyclicToPlain(source._7);
			_8.CopyCyclicToPlain(source._8);
			_9.CopyCyclicToPlain(source._9);
			_10.CopyCyclicToPlain(source._10);
			_11.CopyCyclicToPlain(source._11);
			_12.CopyCyclicToPlain(source._12);
			_13.CopyCyclicToPlain(source._13);
			_14.CopyCyclicToPlain(source._14);
			_15.CopyCyclicToPlain(source._15);
			_16.CopyCyclicToPlain(source._16);
			_17.CopyCyclicToPlain(source._17);
			_18.CopyCyclicToPlain(source._18);
			_19.CopyCyclicToPlain(source._19);
			_20.CopyCyclicToPlain(source._20);
			_21.CopyCyclicToPlain(source._21);
			_22.CopyCyclicToPlain(source._22);
			_23.CopyCyclicToPlain(source._23);
			_24.CopyCyclicToPlain(source._24);
			_25.CopyCyclicToPlain(source._25);
			_26.CopyCyclicToPlain(source._26);
			_27.CopyCyclicToPlain(source._27);
			_28.CopyCyclicToPlain(source._28);
			_29.CopyCyclicToPlain(source._29);
			_30.CopyCyclicToPlain(source._30);
			_31.CopyCyclicToPlain(source._31);
			_32.CopyCyclicToPlain(source._32);
			_33.CopyCyclicToPlain(source._33);
			_34.CopyCyclicToPlain(source._34);
			_35.CopyCyclicToPlain(source._35);
			_36.CopyCyclicToPlain(source._36);
			_37.CopyCyclicToPlain(source._37);
			_38.CopyCyclicToPlain(source._38);
			_39.CopyCyclicToPlain(source._39);
			_40.CopyCyclicToPlain(source._40);
			_41.CopyCyclicToPlain(source._41);
			_42.CopyCyclicToPlain(source._42);
			_43.CopyCyclicToPlain(source._43);
			_44.CopyCyclicToPlain(source._44);
			_45.CopyCyclicToPlain(source._45);
			_46.CopyCyclicToPlain(source._46);
			_47.CopyCyclicToPlain(source._47);
			_48.CopyCyclicToPlain(source._48);
			_49.CopyCyclicToPlain(source._49);
			_50.CopyCyclicToPlain(source._50);
			_51.CopyCyclicToPlain(source._51);
			_52.CopyCyclicToPlain(source._52);
			_53.CopyCyclicToPlain(source._53);
			_54.CopyCyclicToPlain(source._54);
			_55.CopyCyclicToPlain(source._55);
			_56.CopyCyclicToPlain(source._56);
			_57.CopyCyclicToPlain(source._57);
			_58.CopyCyclicToPlain(source._58);
			_59.CopyCyclicToPlain(source._59);
			_60.CopyCyclicToPlain(source._60);
			_61.CopyCyclicToPlain(source._61);
			_62.CopyCyclicToPlain(source._62);
			_63.CopyCyclicToPlain(source._63);
			_64.CopyCyclicToPlain(source._64);
			_65.CopyCyclicToPlain(source._65);
			_66.CopyCyclicToPlain(source._66);
			_67.CopyCyclicToPlain(source._67);
			_68.CopyCyclicToPlain(source._68);
			_69.CopyCyclicToPlain(source._69);
			_70.CopyCyclicToPlain(source._70);
			_71.CopyCyclicToPlain(source._71);
			_72.CopyCyclicToPlain(source._72);
			_73.CopyCyclicToPlain(source._73);
			_74.CopyCyclicToPlain(source._74);
			_75.CopyCyclicToPlain(source._75);
			_76.CopyCyclicToPlain(source._76);
			_77.CopyCyclicToPlain(source._77);
			_78.CopyCyclicToPlain(source._78);
			_79.CopyCyclicToPlain(source._79);
			_80.CopyCyclicToPlain(source._80);
			_81.CopyCyclicToPlain(source._81);
			_82.CopyCyclicToPlain(source._82);
			_83.CopyCyclicToPlain(source._83);
			_84.CopyCyclicToPlain(source._84);
			_85.CopyCyclicToPlain(source._85);
			_86.CopyCyclicToPlain(source._86);
			_87.CopyCyclicToPlain(source._87);
			_88.CopyCyclicToPlain(source._88);
			_89.CopyCyclicToPlain(source._89);
			_90.CopyCyclicToPlain(source._90);
			_91.CopyCyclicToPlain(source._91);
			_92.CopyCyclicToPlain(source._92);
			_93.CopyCyclicToPlain(source._93);
			_94.CopyCyclicToPlain(source._94);
			_95.CopyCyclicToPlain(source._95);
			_96.CopyCyclicToPlain(source._96);
			_97.CopyCyclicToPlain(source._97);
			_98.CopyCyclicToPlain(source._98);
			_99.CopyCyclicToPlain(source._99);
			_100.CopyCyclicToPlain(source._100);
		}

		public void CopyCyclicToPlain(HansPlc.IstHugeStructureOfComplex source)
		{
			this.CopyCyclicToPlain((HansPlc.stHugeStructureOfComplex)source);
		}

		public void CopyShadowToPlain(HansPlc.stHugeStructureOfComplex source)
		{
			_1.CopyShadowToPlain(source._1);
			_2.CopyShadowToPlain(source._2);
			_3.CopyShadowToPlain(source._3);
			_4.CopyShadowToPlain(source._4);
			_5.CopyShadowToPlain(source._5);
			_6.CopyShadowToPlain(source._6);
			_7.CopyShadowToPlain(source._7);
			_8.CopyShadowToPlain(source._8);
			_9.CopyShadowToPlain(source._9);
			_10.CopyShadowToPlain(source._10);
			_11.CopyShadowToPlain(source._11);
			_12.CopyShadowToPlain(source._12);
			_13.CopyShadowToPlain(source._13);
			_14.CopyShadowToPlain(source._14);
			_15.CopyShadowToPlain(source._15);
			_16.CopyShadowToPlain(source._16);
			_17.CopyShadowToPlain(source._17);
			_18.CopyShadowToPlain(source._18);
			_19.CopyShadowToPlain(source._19);
			_20.CopyShadowToPlain(source._20);
			_21.CopyShadowToPlain(source._21);
			_22.CopyShadowToPlain(source._22);
			_23.CopyShadowToPlain(source._23);
			_24.CopyShadowToPlain(source._24);
			_25.CopyShadowToPlain(source._25);
			_26.CopyShadowToPlain(source._26);
			_27.CopyShadowToPlain(source._27);
			_28.CopyShadowToPlain(source._28);
			_29.CopyShadowToPlain(source._29);
			_30.CopyShadowToPlain(source._30);
			_31.CopyShadowToPlain(source._31);
			_32.CopyShadowToPlain(source._32);
			_33.CopyShadowToPlain(source._33);
			_34.CopyShadowToPlain(source._34);
			_35.CopyShadowToPlain(source._35);
			_36.CopyShadowToPlain(source._36);
			_37.CopyShadowToPlain(source._37);
			_38.CopyShadowToPlain(source._38);
			_39.CopyShadowToPlain(source._39);
			_40.CopyShadowToPlain(source._40);
			_41.CopyShadowToPlain(source._41);
			_42.CopyShadowToPlain(source._42);
			_43.CopyShadowToPlain(source._43);
			_44.CopyShadowToPlain(source._44);
			_45.CopyShadowToPlain(source._45);
			_46.CopyShadowToPlain(source._46);
			_47.CopyShadowToPlain(source._47);
			_48.CopyShadowToPlain(source._48);
			_49.CopyShadowToPlain(source._49);
			_50.CopyShadowToPlain(source._50);
			_51.CopyShadowToPlain(source._51);
			_52.CopyShadowToPlain(source._52);
			_53.CopyShadowToPlain(source._53);
			_54.CopyShadowToPlain(source._54);
			_55.CopyShadowToPlain(source._55);
			_56.CopyShadowToPlain(source._56);
			_57.CopyShadowToPlain(source._57);
			_58.CopyShadowToPlain(source._58);
			_59.CopyShadowToPlain(source._59);
			_60.CopyShadowToPlain(source._60);
			_61.CopyShadowToPlain(source._61);
			_62.CopyShadowToPlain(source._62);
			_63.CopyShadowToPlain(source._63);
			_64.CopyShadowToPlain(source._64);
			_65.CopyShadowToPlain(source._65);
			_66.CopyShadowToPlain(source._66);
			_67.CopyShadowToPlain(source._67);
			_68.CopyShadowToPlain(source._68);
			_69.CopyShadowToPlain(source._69);
			_70.CopyShadowToPlain(source._70);
			_71.CopyShadowToPlain(source._71);
			_72.CopyShadowToPlain(source._72);
			_73.CopyShadowToPlain(source._73);
			_74.CopyShadowToPlain(source._74);
			_75.CopyShadowToPlain(source._75);
			_76.CopyShadowToPlain(source._76);
			_77.CopyShadowToPlain(source._77);
			_78.CopyShadowToPlain(source._78);
			_79.CopyShadowToPlain(source._79);
			_80.CopyShadowToPlain(source._80);
			_81.CopyShadowToPlain(source._81);
			_82.CopyShadowToPlain(source._82);
			_83.CopyShadowToPlain(source._83);
			_84.CopyShadowToPlain(source._84);
			_85.CopyShadowToPlain(source._85);
			_86.CopyShadowToPlain(source._86);
			_87.CopyShadowToPlain(source._87);
			_88.CopyShadowToPlain(source._88);
			_89.CopyShadowToPlain(source._89);
			_90.CopyShadowToPlain(source._90);
			_91.CopyShadowToPlain(source._91);
			_92.CopyShadowToPlain(source._92);
			_93.CopyShadowToPlain(source._93);
			_94.CopyShadowToPlain(source._94);
			_95.CopyShadowToPlain(source._95);
			_96.CopyShadowToPlain(source._96);
			_97.CopyShadowToPlain(source._97);
			_98.CopyShadowToPlain(source._98);
			_99.CopyShadowToPlain(source._99);
			_100.CopyShadowToPlain(source._100);
		}

		public void CopyShadowToPlain(HansPlc.IShadowstHugeStructureOfComplex source)
		{
			this.CopyShadowToPlain((HansPlc.stHugeStructureOfComplex)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainstHugeStructureOfComplex()
		{
			__1 = new PlainstComplex();
			__2 = new PlainstComplex();
			__3 = new PlainstComplex();
			__4 = new PlainstComplex();
			__5 = new PlainstComplex();
			__6 = new PlainstComplex();
			__7 = new PlainstComplex();
			__8 = new PlainstComplex();
			__9 = new PlainstComplex();
			__10 = new PlainstComplex();
			__11 = new PlainstComplex();
			__12 = new PlainstComplex();
			__13 = new PlainstComplex();
			__14 = new PlainstComplex();
			__15 = new PlainstComplex();
			__16 = new PlainstComplex();
			__17 = new PlainstComplex();
			__18 = new PlainstComplex();
			__19 = new PlainstComplex();
			__20 = new PlainstComplex();
			__21 = new PlainstComplex();
			__22 = new PlainstComplex();
			__23 = new PlainstComplex();
			__24 = new PlainstComplex();
			__25 = new PlainstComplex();
			__26 = new PlainstComplex();
			__27 = new PlainstComplex();
			__28 = new PlainstComplex();
			__29 = new PlainstComplex();
			__30 = new PlainstComplex();
			__31 = new PlainstComplex();
			__32 = new PlainstComplex();
			__33 = new PlainstComplex();
			__34 = new PlainstComplex();
			__35 = new PlainstComplex();
			__36 = new PlainstComplex();
			__37 = new PlainstComplex();
			__38 = new PlainstComplex();
			__39 = new PlainstComplex();
			__40 = new PlainstComplex();
			__41 = new PlainstComplex();
			__42 = new PlainstComplex();
			__43 = new PlainstComplex();
			__44 = new PlainstComplex();
			__45 = new PlainstComplex();
			__46 = new PlainstComplex();
			__47 = new PlainstComplex();
			__48 = new PlainstComplex();
			__49 = new PlainstComplex();
			__50 = new PlainstComplex();
			__51 = new PlainstComplex();
			__52 = new PlainstComplex();
			__53 = new PlainstComplex();
			__54 = new PlainstComplex();
			__55 = new PlainstComplex();
			__56 = new PlainstComplex();
			__57 = new PlainstComplex();
			__58 = new PlainstComplex();
			__59 = new PlainstComplex();
			__60 = new PlainstComplex();
			__61 = new PlainstComplex();
			__62 = new PlainstComplex();
			__63 = new PlainstComplex();
			__64 = new PlainstComplex();
			__65 = new PlainstComplex();
			__66 = new PlainstComplex();
			__67 = new PlainstComplex();
			__68 = new PlainstComplex();
			__69 = new PlainstComplex();
			__70 = new PlainstComplex();
			__71 = new PlainstComplex();
			__72 = new PlainstComplex();
			__73 = new PlainstComplex();
			__74 = new PlainstComplex();
			__75 = new PlainstComplex();
			__76 = new PlainstComplex();
			__77 = new PlainstComplex();
			__78 = new PlainstComplex();
			__79 = new PlainstComplex();
			__80 = new PlainstComplex();
			__81 = new PlainstComplex();
			__82 = new PlainstComplex();
			__83 = new PlainstComplex();
			__84 = new PlainstComplex();
			__85 = new PlainstComplex();
			__86 = new PlainstComplex();
			__87 = new PlainstComplex();
			__88 = new PlainstComplex();
			__89 = new PlainstComplex();
			__90 = new PlainstComplex();
			__91 = new PlainstComplex();
			__92 = new PlainstComplex();
			__93 = new PlainstComplex();
			__94 = new PlainstComplex();
			__95 = new PlainstComplex();
			__96 = new PlainstComplex();
			__97 = new PlainstComplex();
			__98 = new PlainstComplex();
			__99 = new PlainstComplex();
			__100 = new PlainstComplex();
		}
	}
}