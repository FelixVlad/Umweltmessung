using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WetterApp.Measurements;

namespace WetterApp
{
    public static class Commands
    {
        private static bool ValidInput(int numOfDays)
        {
            return numOfDays < 367 && numOfDays > 0;
        }

        public static void GetTemperature(string command)
        {
            var command2 = string.Empty;
            Console.WriteLine("<Temperature>");
            Console.WriteLine("Choose a command(first two letters): ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("sd : Enter a specific number of days");
            Console.WriteLine("bk : Back to main menu");
            Console.WriteLine("--------------------------------------------");

            switch (command.ToUpper())
            {
                case "SD":
                {
                    Console.WriteLine("Enter a amount of days, please!");
                    try
                    {
                        var dayCount = Convert.ToInt32(Console.ReadLine());

                        if (ValidInput(dayCount))
                        {
                            Console.WriteLine("Weather in the last {0} days: ", dayCount);

                            var temperature = new Temperature(dayCount);
                            temperature.GetWeatherDates();
                            temperature.PrintArray();
                            temperature.PrintMiddleValue();

                            //Console.WriteLine("Enter an exact tag: ");
                        }
                        else
                        {
                            Console.WriteLine("There was an error processing the request.");
                            Console.WriteLine("Max days number of the days is 366");
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("{0} Please, make sure that you entered a number or try again later.",
                            e.Message);
                    }

                    break;
                }
                case "BK":
                {
                    command = "bk";
                    break;
                }
                default:
                {
                    Console.WriteLine("Unknown Command " + command.ToLower());
                    Console.WriteLine("Please, make sure you are using the correct command or try again later.");
                    break;
                }
            }
        }

        public static void GetAirPressure()
        {
            Console.WriteLine("<Air Pressure>");
            //Console.WriteLine("Enter a amount of days, please!");
            Console.WriteLine("Please enter 'default', dayNumber or numberOfDays!");
            var input = Console.ReadLine();

            AirPressure airPressure;

            switch (input.ToUpper())
            {
                case "DEFAULT":
                    Console.WriteLine("Air pressure in the last 10 days ");

                    airPressure = new AirPressure(10);
                    airPressure.GetWeatherDates();
                    airPressure.PrintArray();
                    airPressure.PrintMiddleValue();
                    break;

                case "NUMBEROFDAYS":
                    Console.WriteLine("Please enter amount of days:");
                    try
                    {
                        var dayCount = Convert.ToInt32(Console.ReadLine());

                        if (ValidInput(dayCount))
                        {
                            Console.WriteLine("Air pressure in the last {0} days: ", dayCount);

                            airPressure = new AirPressure(dayCount);
                            airPressure.GetWeatherDates();
                            airPressure.PrintArray();
                            airPressure.PrintMiddleValue();

                            //Console.WriteLine("Enter an exact tag: ");
                        }
                        else
                        {
                            Console.WriteLine("There was an error processing the request.");
                            Console.WriteLine("Max days number of the days is 366");
                        }
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("Invalid input");
                    }
                    break;

                case "DAYNUMBER":
                    Console.WriteLine("Please enter day number:");
                    try
                    {
                        var dayNumber = Convert.ToInt32(Console.ReadLine());

                        airPressure = new AirPressure(1);
                        airPressure.PrintDay(dayNumber);
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input");
                    }

                    break;
            }


            //try
            //{
            //    var dayCount = Convert.ToInt32(input);

            //    if (ValidInput(dayCount) && dayCount == 1)
            //    {

            //    }

            //    else if (ValidInput(dayCount))
            //    {
            //        Console.WriteLine("Air pressure in the last {0} days: ", dayCount);

            //        var airPressure = new AirPressure(dayCount);
            //        airPressure.GetWeatherDates();
            //        airPressure.PrintArray();
            //        airPressure.PrintMiddleValue();

            //        //Console.WriteLine("Enter an exact tag: ");
            //    }
            //    else
            //    {
            //        Console.WriteLine("There was an error processing the request.");
            //        Console.WriteLine("Max days number of the days is 366");
            //    }
            //}
            //catch (Exception e)
            //{
            //    if (input == "default")
            //    {
            //        Console.WriteLine("Air pressure in the last 10 days ");

            //        var airPressure = new AirPressure(10);
            //        airPressure.GetWeatherDates();
            //        airPressure.PrintArray();
            //        airPressure.PrintMiddleValue();
            //    }

            //    else
            //        Console.WriteLine("{0} Please, make sure that you entered a number or try again later.", e.Message);
            //}
        }

        public static void GetPrecipitations()
        {
            Console.WriteLine("<Precipitation>");
            Console.WriteLine("Enter a amount of days, please!");
            try
            {
                var dayCount = Convert.ToInt32(Console.ReadLine());

                if (ValidInput(dayCount))
                {
                    Console.WriteLine("Air pressure in the last {0} days: ", dayCount);

                    var precipitation = new Precipitation(dayCount);
                    precipitation.GetWeatherDates();
                    precipitation.PrintArray();
                    precipitation.PrintMiddleValue();

                    //Console.WriteLine("Enter an exact tag: ");
                }
                else
                {
                    Console.WriteLine("There was an error processing the request.");
                    Console.WriteLine("Max days number of the days is 366");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Please, make sure that you entered a number or try again later.", e.Message);
            }
        }
    }
}