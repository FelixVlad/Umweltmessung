using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WetterApp
{
   public class LuftDruck
    {
       Random luftRandomizer = new Random();
        private const int MinNumber = 0;
        private const int MaxNumber = 1000;

        public int[] GetRandomLuftDruckArray(int arraySize)
        {
           
            var intArray = new int[arraySize];

            for (var i = 0; i < arraySize; i++)
            {
                intArray[i] = luftRandomizer.Next(MinNumber, MaxNumber + 1);
            }

            return intArray;
        }

        public static void ShowLuftDruck(Array array)
        {
            foreach (int x in array)
            {
                Console.WriteLine("Tag {0} - Luftdruck: {1} mbar" , Array.IndexOf(array, x) + 1 , x);     
            }
        }

        public int LuftDruckMittelWert(params int[] array)
        {
            var sum = 0;
            var result = 0;

            foreach (var tage in array)
            {
                sum += tage;
                result = sum / array.Length;
            }

            return result ;
        }
    }
}
