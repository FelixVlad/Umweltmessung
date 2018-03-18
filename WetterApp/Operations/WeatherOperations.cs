using System;
using System.Collections.Generic;
using WetterApp.Models;
using WetterApp.Operations.MeassuresOperations;

namespace WetterApp.Operations
{
    public static class WeatherOperations
    {
        public static void GetInfo(string input, List<Day> daysList)
        {
            string commandInput;

            switch (input.ToUpper())
            {
                case "TC":
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("<Temperature>");
                    Console.WriteLine("ad : Weather on a certain amount of days (for each day separately");
                    Console.WriteLine("cd : Weather on a certain day");
                    Console.WriteLine("at : Average temperrature over a period");
                    Console.WriteLine("df : Default weather data (last 10 days");
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("ex : - Exit");
                    Console.Write(">");
                    commandInput = Console.ReadLine();
                    commandInput = commandInput.Substring(0, 2);
                    TemperatureOperations.CommandSwitchTC(commandInput, daysList);
                    break;

                case "AP":
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("<Air Pressure>");
                    Console.WriteLine("ad : Weather on a certain amount of days (for each day separately");
                    Console.WriteLine("cd : Weather on a certain day");
                    Console.WriteLine("at : Average pressure over a period");
                    Console.WriteLine("df : Default weather data (last 10 days");
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("ex : - Exit");
                    Console.Write(">");
                    commandInput = Console.ReadLine();
                    commandInput = commandInput.Substring(0, 2);
                    AirPressureOperations.CommandSwitchAP(commandInput, daysList);
                    break;

                case "PM":
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("<Precipitation>");
                    Console.WriteLine("ad : Weather on a certain amount of days (for each day separately");
                    Console.WriteLine("cd : Weather on a certain day");
                    Console.WriteLine("at : Average precipitation over a period");
                    Console.WriteLine("df : Default weather data (last 10 days");
                    Console.WriteLine("--------------------------------------------");
                    Console.WriteLine("ex : - Exit");
                    Console.Write(">");
                    commandInput = Console.ReadLine();
                    commandInput = commandInput.Substring(0, 2);
                    PrecipitationsOperations.CommandSwitchPM(commandInput, daysList);
                    break;

                case "EX":
                {
                    Console.WriteLine("Application closing...");
                    break;
                }

                default:
                    Console.WriteLine("Unknown Command " + input.ToLower());
                    Console.WriteLine("Please, make sure you are using the correct command or try again later.");
                    break;
            }
        }

        public static int GetNumberOfDays(string input)
        {
            try
            {
                var days = Convert.ToInt32(input);

                if (days < 367 && days >0)  
                    return days;
                
                else
                {
                    Console.WriteLine("Please write a valid number of days (between 1 and 366)"); 
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Make sure you wrote a positive number {0}", e.Message);
                return 0;
            }
        }
    }
}
