using System;
using System.Linq;

namespace HansPlc
{
    public partial class structWeatherStation
    {
        public PlainstructWeatherStation POCO
        {
            get
            {
                var poco = this.CreatePlainerType();
                this.FlushOnlineToPlain(poco);
                return poco;
            }
        }
    }
}
