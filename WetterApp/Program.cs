using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WetterApp.WeatherMeasurements;

namespace WetterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a amount of days, please!");
   
            var dayCount = Convert.ToInt32(Console.ReadLine());

            var luft = new LuftDruck();
            var nieder = new Niederschlag();
            var temperatur = new Temperatur(dayCount);

            if (dayCount <= 366 && dayCount >= 0)
            {
                temperatur.GetTemperatur();
                Temperatur.PrintArray();
                Temperatur.PrintMiddleValue();

                Console.WriteLine("Weather in the last {0} days: ", dayCount);

                Console.WriteLine("Enter an exact tag: ");

            }
            else
            {
                Console.WriteLine("Max 366 days!");
            }
        Console.ReadKey();        
        }
    }
}
