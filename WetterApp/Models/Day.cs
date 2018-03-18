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

        private int Precipitation { get; set; }
        private int AirPressure { get; set; }
        private int Temperature { get; set; }
    }
}