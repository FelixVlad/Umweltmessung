using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using WetterApp.Models;

namespace WetterApp
{
    static class Program
    {
        static void Main(string[] args)
        {
            var days = DaysGenerator.GetDays();

            Console.WriteLine("Welcome to our meteo software");
            Console.WriteLine("Please enter one of the following commands: TC, AP, PM");
            Console.WriteLine("Or press Enter to exit the program");
            var input = Console.ReadLine();

            WeatherOperations.GetInfo(input, days);
        }
    }
}