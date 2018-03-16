using System;
using System.Collections.Generic;
using System.Linq;

namespace WetterApp.WeatherMeasurements
{
    internal class Temperatur
    {

        private int _minValue = 0;
        private int _maxValue = 30;
        private int dayCount;
        private static List<int> temperatur { get; set; }

        public Temperatur()
        {
            temperatur = new List<int>();
        }

        public Temperatur(int dayCount)
           : this()
        {
            this.dayCount = dayCount;
        }

        public List<int> GetTemperatur()
        {
            var temperaturRandomizer = new Random();

            for (var i = _minValue; i < dayCount; i++)
            {
                temperatur.Add(temperaturRandomizer.Next(_maxValue));
            }

            return temperatur;
        }

        public static void PrintArray()
        {
            foreach (var x in temperatur)
                Console.WriteLine("Day {0} - Temperature: {1} ∘C", temperatur.IndexOf(x) + 1, x);
        }

        public static void PrintMiddleValue()
        {
            Console.WriteLine("Average temperature: {0} ∘C", temperatur.Sum() / temperatur.Count);
        }

    }
}
