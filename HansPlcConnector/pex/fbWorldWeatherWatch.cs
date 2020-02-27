using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HansPlc
{
    public partial class fbWorldWeatherWatch
    {
        public IEnumerable<PlainstructWeatherStation> GetStationsPOCO()
        {            
            return this.GetChildren().Where(p => p is structWeatherStation).Select(p => ((structWeatherStation)p).POCO);           
        }

        public IEnumerable<object> WeatherStations
        {
            get
            { 
                return this.GetChildren().Where(p => p.GetType() == typeof(structWeatherStation));
            }
        }
    }
}
