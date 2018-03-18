using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WetterApp.Measurements
{
    interface IMeasurable
    {
        int MinValue { get; set; }
        int MaxValue { get; set; }
        List<int> MeassureList { get; set; }

        List<int> GetWeatherDates();
        void PrintArray();
        void PrintMiddleValue();
    }
}
