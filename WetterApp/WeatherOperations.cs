using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WetterApp.Models;

namespace WetterApp
{
    public static class WeatherOperations
    {
        public static void GetInfo(string input, List<Day> daysList)
        {
            string commandInput;
            switch (input.ToUpper())
            {
                case "TC":
                    Console.WriteLine("Please enter one of the following commands: AA, BB, CC, DD");
                    commandInput = Console.ReadLine();
                    TemperatureOperations.CommandSwitchTC(commandInput, daysList);
                    break;

                case "AP":
                    Console.WriteLine("Please enter one of the following commands: AA, BB, CC, DD");
                    commandInput = Console.ReadLine();
                    AirPressureOperations.CommandSwitchAP(commandInput, daysList);
                    break;

                case "PM":
                    Console.WriteLine("Please enter one of the following commands: AA, BB, CC, DD");
                    commandInput = Console.ReadLine();
                    PrecipitationsOperations.CommandSwitchPM(commandInput, daysList);
                    break;

                default:
                    Console.WriteLine("Invalid Command " + input);
                    break;
            }
        }

        public static int GetNumberOfDays(string input)
        {
            try
            {
                var days = Convert.ToInt32(input);
                return days;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
    }
}
