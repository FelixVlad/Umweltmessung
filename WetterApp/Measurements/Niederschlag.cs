using System;
using System.Collections.Generic;
using System.Linq;

namespace WetterApp.Measurements
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
            var precipitationRandomizer = new Random();

            for (var i = 0; i < dayCount; i++)
            {
                niederschlag.Add(precipitationRandomizer.Next(_minValue, _maxValue));
            }

            return niederschlag;
        }

        public void PrintArray()
        {
            foreach (var x in niederschlag)
                Console.WriteLine("Day {0} - Precipitation: {1} mm", niederschlag.IndexOf(x) + 1, x);
        }

        public void PrintMiddleValue()
        {
            Console.WriteLine("Average precipitation: {0} mm", niederschlag.Sum() / niederschlag.Count);
        }
    }
}
