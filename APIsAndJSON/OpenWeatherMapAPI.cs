using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        public MainInfo Main { get; set; }

        public class MainInfo
        {
            public double Temp { get; set; }
        }

    }
}
