using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WetterApp.Models
{
    public class Day
    {
        public Day(int precipitation, int airPressure, int temperature)
        {
            Precipitation = precipitation;
            AirPressure = airPressure;
            Temperature = temperature;
        }

        public int Precipitation { get; set; }
        public int AirPressure { get; set; }
        public int Temperature { get; set; }
    }
}