using System;
using System.Collections.Generic;
using System.Linq;

namespace WetterApp.Measurements
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

       public List<int> GetPressure()
       {
           var tluftDruckRandomizer = new Random();

           for (var i = 0; i < dayCount; i++)
           {
               luftDruck.Add(tluftDruckRandomizer.Next(_minValue, _maxValue));
           }

           return luftDruck;
       }

       public void PrintArray()
       {
           foreach (var x in luftDruck)
               Console.WriteLine("Day {0} - Air pressure: {1} mbar", luftDruck.IndexOf(x) + 1, x);
       }

       public void PrintMiddleValue()
       {
           Console.WriteLine("Average air pressure: {0} mbar", luftDruck.Sum() / luftDruck.Count);
       }
    }
}
