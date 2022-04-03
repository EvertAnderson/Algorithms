using System;
using System.Collections.Generic;
using System.Linq;

namespace SwitchSort
{
    class Program
    {
        public static int SwitchSort(int[] arr)
        {
            List<int> values = arr.ToList();
            List<int> valuesSorted = arr.ToList();

            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < valuesSorted.Count; i++)
            {
                dict.Add(valuesSorted[i], i);
            }

            valuesSorted.Sort();

            Dictionary<int, int> dictSorted = new Dictionary<int, int>();

            for (int i = 0; i < valuesSorted.Count; i++)
            {
                dictSorted.Add(valuesSorted[i], i);
            }

            int sum = 0;
            for (int i = 0; i < dictSorted.Count; i++)
            {
                sum = 0;
                int posI = dict[dictSorted.ElementAt(i).Key];
                int posF = dictSorted.ElementAt(i).Value;

                if(posI != posF)
                {
                    if (posI > posF)
                    {
                        for (int j = posI; j >= 0; j--)
                        {

                        }
                    }
                    else
                    {

                    }
                }

                sum = Math.Abs(posI - posF);

                //dict.Remove
            }

            return sum;

        }
        static void Main(string[] args)
        {
            int[] numbers = new int[4] { 1, 3, 4, 2 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]},");
            }

            Console.WriteLine(SwitchSort(numbers));
        }
    }
}
