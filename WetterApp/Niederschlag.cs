using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WetterApp
{
    class Niederschlag
    {
        Random niederschlagRandomizer = new Random();
        private const int MinNumber = 0;
        private const int MaxNumber = 50;

        public int[] getRandomNiederschlagArray(int arraySize)
        {

            var intArray = new int[arraySize];

            for (var i = 0; i < arraySize; i++)
            {
                intArray[i] = niederschlagRandomizer.Next(MinNumber, MaxNumber + 1);
            }

            return intArray;
        }

        public static void ShowNiederschlag(Array array)
        {
            foreach (int x in array)
            {
                Console.WriteLine("Tag {0} - Niederschlag: {1} mm", Array.IndexOf(array, x) + 1 , x);
            }
        }

        public int niederschlagMittelWert(params int[] array)
        {
            var sum = 0;
            var result = 0;

            foreach (var tage in array)
            {
                sum += tage;
                result = sum / array.Length;
            }

            return result;
        }
    }
}
