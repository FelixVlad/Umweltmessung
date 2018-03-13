using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WetterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a amount of days, please!");

            var tage = Convert.ToInt32(Console.ReadLine());

            var luft = new LuftDruck();
            var nieder = new Niederschlag();
            var temperatur = new Temperatur();

            if(tage <= 366){
                var luftArray = luft.GetRandomLuftDruckArray(tage);
                var niederArray = nieder.getRandomNiederschlagArray(tage);
                var temperaturArray = temperatur.GetRandomTemperaturArray(tage);

                LuftDruck.ShowLuftDruck(luftArray);
                Niederschlag.ShowNiederschlag(niederArray);
                temperatur.ShowTemperatur(temperaturArray);
            }
            else
            {
                Console.WriteLine("Max 366 days!");
            }
           
            Console.ReadKey();        
        }

    }
}
