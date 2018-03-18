using System;
using System.Collections.Generic;
using System.Linq;

namespace WetterApp.Measurements
{
   public class AirPressure : IMeasurable
    {
       public int MinValue { get; set; }
       public int MaxValue { get; set; }
       public List<int> MeassureList { get; set; }
       private int _dayCount;

       private AirPressure(int minValue = 800, int maxValue = 1100)
       {
           MaxValue = maxValue;
           MinValue = minValue;
           MeassureList = new List<int>();
       }

       public AirPressure(int dayCount)
           : this()
       {
           this._dayCount = dayCount;
       }

       public List<int> GetWeatherDates()
       {
           var tluftDruckRandomizer = new Random();

           for (var i = 0; i < _dayCount; i++)
           {
               MeassureList.Add(tluftDruckRandomizer.Next(MinValue, MaxValue));
           }

           return MeassureList;
       }

       public void PrintArray()
       {
           foreach (var x in MeassureList)
               Console.WriteLine("Day {0} - Air pressure: {1} mbar", MeassureList.IndexOf(x) + 1, x);
       }

       public void PrintMiddleValue()
       {
           Console.WriteLine("Average air pressure: {0} mbar", MeassureList.Sum() / MeassureList.Count);
       }
    }
}
