using System;
using System.Collections.Generic;
using System.Linq;

namespace WetterApp.WeatherMeasurements
{
    class Niederschlag
    {
        private int _minValue = 0;
        private int _maxValue = 20;
        private int dayCount;
        private static List<int> niederschlag { get; set; }

        public Niederschlag()
        {
            niederschlag = new List<int>();
        }

        public Niederschlag(int dayCount)
            : this()
        {
            this.dayCount = dayCount;
        }

        public List<int> GetPrecipitation()
        {
            var temperaturRandomizer = new Random();

            for (var i = _minValue; i < dayCount; i++)
            {
                niederschlag.Add(temperaturRandomizer.Next(_maxValue));
            }

            return niederschlag;
        }

        public static void PrintArray()
        {
            foreach (var x in niederschlag)
                Console.WriteLine("Day {0} - Precipitation: {1} mm", niederschlag.IndexOf(x) + 1, x);
        }

        public static void PrintMiddleValue()
        {
            Console.WriteLine("Average precipitation: {0} mm", niederschlag.Sum() / niederschlag.Count);
        }
    }
}
