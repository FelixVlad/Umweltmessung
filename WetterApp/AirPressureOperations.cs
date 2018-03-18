using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WetterApp.Models;

namespace WetterApp
{
    public static class AirPressureOperations
    {
        public static void CommandSwitchAP(string input, List<Day> dayList)
        {
            int numOfDays;
            IEnumerable<Day> days;
            int airPressureSum = 0;
            switch (input.ToUpper())
            {
                case "AA":
                    Console.WriteLine("Enter amount of days:");
                    numOfDays = WeatherOperations.GetNumberOfDays(Console.ReadLine());
                    days = dayList.Take(numOfDays);
                    foreach (var day in days)
                    {
                        Console.WriteLine(day.AirPressure);
                    }
                    break;
                case "BB":
                    Console.WriteLine("Enter day number:");
                    var dayNumber = WeatherOperations.GetNumberOfDays(Console.ReadLine());
                    Console.WriteLine(dayList[dayNumber - 1].AirPressure);
                    break;
                case "CC":
                    Console.WriteLine("Enter amount of days:");
                    numOfDays = WeatherOperations.GetNumberOfDays(Console.ReadLine());
                    days = dayList.Take(numOfDays);
                    foreach (var day in days)
                    {
                        airPressureSum += day.AirPressure;
                    }

                    var average = airPressureSum / days.Count();
                    Console.WriteLine("Average: " + average);
                    break;
                case "DD":
                    days = dayList.Take(10);
                    foreach (var day in days)
                    {
                        Console.WriteLine(day.AirPressure);
                        airPressureSum += day.AirPressure;
                    }

                    var average2 = airPressureSum / days.Count();
                    Console.WriteLine("Average: " + average2);
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;
            }
        }
    }
}
