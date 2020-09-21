using System;
using Vortex.Connector;
using Vortex.Connector.Peripheries;
using Vortex.Connector.Attributes;
using Vortex.Connector.ValueTypes;
using Vortex.Connector.Identity;
using HansPlcConnector.Properties;

[assembly: Vortex.Connector.Attributes.AssemblyPlcCounterPart("{\r\n  \"Types\": [\r\n    {\r\n      \"TypeAttributes\": \"\",\r\n      \"TypeName\": \"enumStationStatus\",\r\n      \"Namespace\": \"HansPlc\",\r\n      \"TypeMetaInfo\": 5\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"fbDrive\",\r\n      \"Namespace\": \"HansPlc\",\r\n      \"TypeMetaInfo\": 4\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"fbFluentString\",\r\n      \"Namespace\": \"HansPlc\",\r\n      \"TypeMetaInfo\": 4\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"fbWorldWeatherWatch\",\r\n      \"Namespace\": \"HansPlc\",\r\n      \"TypeMetaInfo\": 4\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"structWeatherStation\",\r\n      \"Namespace\": \"HansPlc\",\r\n      \"TypeMetaInfo\": 1\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"Utils\",\r\n      \"Namespace\": \"HansPlc\",\r\n      \"TypeMetaInfo\": 0\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"prgAddedProperties\",\r\n      \"Namespace\": \"HansPlc\",\r\n      \"TypeMetaInfo\": 3\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"MAIN\",\r\n      \"Namespace\": \"HansPlc\",\r\n      \"TypeMetaInfo\": 3\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"prgSimple\",\r\n      \"Namespace\": \"HansPlc\",\r\n      \"TypeMetaInfo\": 3\r\n    },\r\n    {\r\n      \"TypeAttributes\": \"\\n{attribute addProperty Name \\\"\\\" }\",\r\n      \"TypeName\": \"prgWeatherStations\",\r\n      \"Namespace\": \"HansPlc\",\r\n      \"TypeMetaInfo\": 3\r\n    }\r\n  ],\r\n  \"Name\": \"HansPlc\",\r\n  \"Namespace\": \"HansPlc\"\r\n}")]
namespace HansPlc
{
	public partial class HansPlcTwinController : Vortex.Connector.ITwinController, IHansPlcTwinController, IShadowHansPlcTwinController
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
		Utils _Utils;
		public Utils Utils
		{
			get
			{
				return _Utils;
			}
		}

		IUtils IHansPlcTwinController.Utils
		{
			get
			{
				return Utils;
			}
		}

		IShadowUtils IShadowHansPlcTwinController.Utils
		{
			get
			{
				return Utils;
			}
		}

		prgAddedProperties _prgAddedProperties;
		public prgAddedProperties prgAddedProperties
		{
			get
			{
				return _prgAddedProperties;
			}
		}

		IprgAddedProperties IHansPlcTwinController.prgAddedProperties
		{
			get
			{
				return prgAddedProperties;
			}
		}

		IShadowprgAddedProperties IShadowHansPlcTwinController.prgAddedProperties
		{
			get
			{
				return prgAddedProperties;
			}
		}

		MAIN _MAIN;
		public MAIN MAIN
		{
			get
			{
				return _MAIN;
			}
		}

		IMAIN IHansPlcTwinController.MAIN
		{
			get
			{
				return MAIN;
			}
		}

		IShadowMAIN IShadowHansPlcTwinController.MAIN
		{
			get
			{
				return MAIN;
			}
		}

		prgSimple _prgSimple;
		public prgSimple prgSimple
		{
			get
			{
				return _prgSimple;
			}
		}

		IprgSimple IHansPlcTwinController.prgSimple
		{
			get
			{
				return prgSimple;
			}
		}

		IShadowprgSimple IShadowHansPlcTwinController.prgSimple
		{
			get
			{
				return prgSimple;
			}
		}

		prgWeatherStations _prgWeatherStations;
		public prgWeatherStations prgWeatherStations
		{
			get
			{
				return _prgWeatherStations;
			}
		}

		IprgWeatherStations IHansPlcTwinController.prgWeatherStations
		{
			get
			{
				return prgWeatherStations;
			}
		}

		IShadowprgWeatherStations IShadowHansPlcTwinController.prgWeatherStations
		{
			get
			{
				return prgWeatherStations;
			}
		}

		public void LazyOnlineToShadow()
		{
			Utils.LazyOnlineToShadow();
			prgAddedProperties.LazyOnlineToShadow();
			MAIN.LazyOnlineToShadow();
			prgSimple.LazyOnlineToShadow();
			prgWeatherStations.LazyOnlineToShadow();
		}

		public void LazyShadowToOnline()
		{
			Utils.LazyShadowToOnline();
			prgAddedProperties.LazyShadowToOnline();
			MAIN.LazyShadowToOnline();
			prgSimple.LazyShadowToOnline();
			prgWeatherStations.LazyShadowToOnline();
		}

		public PlainHansPlcTwinController CreatePlainerType()
		{
			var cloned = new PlainHansPlcTwinController();
			cloned.Utils = Utils.CreatePlainerType();
			cloned.prgAddedProperties = prgAddedProperties.CreatePlainerType();
			cloned.MAIN = MAIN.CreatePlainerType();
			cloned.prgSimple = prgSimple.CreatePlainerType();
			cloned.prgWeatherStations = prgWeatherStations.CreatePlainerType();
			return cloned;
		}

		protected PlainHansPlcTwinController CreatePlainerType(PlainHansPlcTwinController cloned)
		{
			cloned.Utils = Utils.CreatePlainerType();
			cloned.prgAddedProperties = prgAddedProperties.CreatePlainerType();
			cloned.MAIN = MAIN.CreatePlainerType();
			cloned.prgSimple = prgSimple.CreatePlainerType();
			cloned.prgWeatherStations = prgWeatherStations.CreatePlainerType();
			return cloned;
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

		public IHansPlcTwinController Online
		{
			get
			{
				return (IHansPlcTwinController)this;
			}
		}

		public IShadowHansPlcTwinController Shadow
		{
			get
			{
				return (IShadowHansPlcTwinController)this;
			}
		}

		public Vortex.Connector.IConnector Connector
		{
			get;
			set;
		}

		public HansPlcTwinController()
		{
			var adapter = new Vortex.Connector.ConnectorAdapter(typeof (DummyConnectorFactory));
			this.Connector = adapter.GetConnector(new object[]{});
			_Utils = new Utils(this.Connector, "", "Utils");
			_prgAddedProperties = new prgAddedProperties(this.Connector, "", "prgAddedProperties");
			_MAIN = new MAIN(this.Connector, "", "MAIN");
			_prgSimple = new prgSimple(this.Connector, "", "prgSimple");
			_prgWeatherStations = new prgWeatherStations(this.Connector, "", "prgWeatherStations");
		}

		public HansPlcTwinController(Vortex.Connector.ConnectorAdapter adapter, object[] parameters)
		{
			this.Connector = adapter.GetConnector(parameters);
			_Utils = new Utils(this.Connector, "", "Utils");
			_prgAddedProperties = new prgAddedProperties(this.Connector, "", "prgAddedProperties");
			_MAIN = new MAIN(this.Connector, "", "MAIN");
			_prgSimple = new prgSimple(this.Connector, "", "prgSimple");
			_prgWeatherStations = new prgWeatherStations(this.Connector, "", "prgWeatherStations");
		}

		public HansPlcTwinController(Vortex.Connector.ConnectorAdapter adapter)
		{
			this.Connector = adapter.GetConnector(adapter.Parameters);
			_Utils = new Utils(this.Connector, "", "Utils");
			_prgAddedProperties = new prgAddedProperties(this.Connector, "", "prgAddedProperties");
			_MAIN = new MAIN(this.Connector, "", "MAIN");
			_prgSimple = new prgSimple(this.Connector, "", "prgSimple");
			_prgWeatherStations = new prgWeatherStations(this.Connector, "", "prgWeatherStations");
		}

		public static string LocalizationDirectory
		{
			get;
			set;
		}

		private static Vortex.Localizations.Abstractions.ITranslator _translator
		{
			get;
			set;
		}

		internal static Vortex.Localizations.Abstractions.ITranslator Translator
		{
			get
			{
				if (_translator == null)
				{
					_translator = Vortex.Localizations.Abstractions.ITranslator.Get(typeof (Localizations));
				} return  _translator ; 

			}
		}
	}

	public partial interface IHansPlcTwinController
	{
		IUtils Utils
		{
			get;
		}

		IprgAddedProperties prgAddedProperties
		{
			get;
		}

		IMAIN MAIN
		{
			get;
		}

		IprgSimple prgSimple
		{
			get;
		}

		IprgWeatherStations prgWeatherStations
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		HansPlc.PlainHansPlcTwinController CreatePlainerType();
	}

	public partial interface IShadowHansPlcTwinController
	{
		IShadowUtils Utils
		{
			get;
		}

		IShadowprgAddedProperties prgAddedProperties
		{
			get;
		}

		IShadowMAIN MAIN
		{
			get;
		}

		IShadowprgSimple prgSimple
		{
			get;
		}

		IShadowprgWeatherStations prgWeatherStations
		{
			get;
		}

		System.String AttributeName
		{
			get;
		}

		HansPlc.PlainHansPlcTwinController CreatePlainerType();
	}

	
            /// <summary>
            /// This is POCO object for its respective onliner class. For documentation of this type see the onliner class.
            /// </summary>
            /// <exclude />
	public partial class PlainHansPlcTwinController : System.ComponentModel.INotifyPropertyChanged, Vortex.Connector.IPlain
	{
		PlainUtils _Utils;
		public PlainUtils Utils
		{
			get
			{
				return _Utils;
			}

			set
			{
				if (_Utils != value)
				{
					_Utils = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(Utils)));
				}
			}
		}

		PlainprgAddedProperties _prgAddedProperties;
		public PlainprgAddedProperties prgAddedProperties
		{
			get
			{
				return _prgAddedProperties;
			}

			set
			{
				if (_prgAddedProperties != value)
				{
					_prgAddedProperties = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(prgAddedProperties)));
				}
			}
		}

		PlainMAIN _MAIN;
		public PlainMAIN MAIN
		{
			get
			{
				return _MAIN;
			}

			set
			{
				if (_MAIN != value)
				{
					_MAIN = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(MAIN)));
				}
			}
		}

		PlainprgSimple _prgSimple;
		public PlainprgSimple prgSimple
		{
			get
			{
				return _prgSimple;
			}

			set
			{
				if (_prgSimple != value)
				{
					_prgSimple = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(prgSimple)));
				}
			}
		}

		PlainprgWeatherStations _prgWeatherStations;
		public PlainprgWeatherStations prgWeatherStations
		{
			get
			{
				return _prgWeatherStations;
			}

			set
			{
				if (_prgWeatherStations != value)
				{
					_prgWeatherStations = value;
					PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(nameof(prgWeatherStations)));
				}
			}
		}

		public void CopyPlainToCyclic(HansPlc.HansPlcTwinController target)
		{
			Utils.CopyPlainToCyclic(target.Utils);
			prgAddedProperties.CopyPlainToCyclic(target.prgAddedProperties);
			MAIN.CopyPlainToCyclic(target.MAIN);
			prgSimple.CopyPlainToCyclic(target.prgSimple);
			prgWeatherStations.CopyPlainToCyclic(target.prgWeatherStations);
		}

		public void CopyPlainToCyclic(HansPlc.IHansPlcTwinController target)
		{
			this.CopyPlainToCyclic((HansPlc.HansPlcTwinController)target);
		}

		public void CopyPlainToShadow(HansPlc.HansPlcTwinController target)
		{
			Utils.CopyPlainToShadow(target.Utils);
			prgAddedProperties.CopyPlainToShadow(target.prgAddedProperties);
			MAIN.CopyPlainToShadow(target.MAIN);
			prgSimple.CopyPlainToShadow(target.prgSimple);
			prgWeatherStations.CopyPlainToShadow(target.prgWeatherStations);
		}

		public void CopyPlainToShadow(HansPlc.IShadowHansPlcTwinController target)
		{
			this.CopyPlainToShadow((HansPlc.HansPlcTwinController)target);
		}

		public void CopyCyclicToPlain(HansPlc.HansPlcTwinController source)
		{
			Utils.CopyCyclicToPlain(source.Utils);
			prgAddedProperties.CopyCyclicToPlain(source.prgAddedProperties);
			MAIN.CopyCyclicToPlain(source.MAIN);
			prgSimple.CopyCyclicToPlain(source.prgSimple);
			prgWeatherStations.CopyCyclicToPlain(source.prgWeatherStations);
		}

		public void CopyCyclicToPlain(HansPlc.IHansPlcTwinController source)
		{
			this.CopyCyclicToPlain((HansPlc.HansPlcTwinController)source);
		}

		public void CopyShadowToPlain(HansPlc.HansPlcTwinController source)
		{
			Utils.CopyShadowToPlain(source.Utils);
			prgAddedProperties.CopyShadowToPlain(source.prgAddedProperties);
			MAIN.CopyShadowToPlain(source.MAIN);
			prgSimple.CopyShadowToPlain(source.prgSimple);
			prgWeatherStations.CopyShadowToPlain(source.prgWeatherStations);
		}

		public void CopyShadowToPlain(HansPlc.IShadowHansPlcTwinController source)
		{
			this.CopyShadowToPlain((HansPlc.HansPlcTwinController)source);
		}

		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		public PlainHansPlcTwinController()
		{
			_Utils = new PlainUtils();
			_prgAddedProperties = new PlainprgAddedProperties();
			_MAIN = new PlainMAIN();
			_prgSimple = new PlainprgSimple();
			_prgWeatherStations = new PlainprgWeatherStations();
		}
	}
}