using System;
using System.Collections.Generic;
using System.Linq;

namespace WetterApp.WeatherMeasurements
{
   public class LuftDruck
   {
       private int _minValue = 800;
       private int _maxValue = 1100;
       private int dayCount;
       private static List<int> luftDruck { get; set; }

       public LuftDruck()
       {
           luftDruck = new List<int>();
       }

       public LuftDruck(int dayCount)
           : this()
       {
           this.dayCount = dayCount;
       }

       public List<int> GetPrecipitation()
       {
           var temperaturRandomizer = new Random();

           for (var i = _minValue; i < dayCount; i++)
           {
               luftDruck.Add(temperaturRandomizer.Next(_maxValue));
           }

           return luftDruck;
       }

       public static void PrintArray()
       {
           foreach (var x in luftDruck)
               Console.WriteLine("Day {0} - Air pressure: {1} mbar", luftDruck.IndexOf(x) + 1, x);
       }

       public static void PrintMiddleValue()
       {
           Console.WriteLine("Average air pressure: {0} mbar", luftDruck.Sum() / luftDruck.Count);
       }
    }
}
