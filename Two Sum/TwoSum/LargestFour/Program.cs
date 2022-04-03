using System;
using System.Collections.Generic;
using System.Linq;

namespace LargestFour
{
    class Program
    {
        public static int LargestFour(int[] arr)
        {
            //int[] fourValues = new int[4];

            List<int> values = arr.ToList();

            List<int> fourValues = new List<int>();

            int maxValue = Int32.MinValue;
            int maxIndex = 0;

            int times = (values.Count < 4) ? values.Count : 4;

            for (int i = 0; i < times; i++)
            {
                maxValue = Int32.MinValue;
                for (int j = 0; j < values.Count; j++)
                {
                    if (values[j] > maxValue)
                    {
                        maxValue = values[j];
                        maxIndex = j;
                    }
                }
                fourValues.Add(maxValue);
                values.RemoveAt(maxIndex);
            }

            int sum = 0;

            foreach (var item in fourValues)
            {
                sum += item;
            }

            //values.Sort();

            //int count = 4;

            //foreach (var item in values)
            //{
            //    if(count > 0)
            //    {
            //        sum += item;
            //        count--;
            //    }
            //}

            // code goes here  
            return sum;

        }

        static void Main()
        {
            // keep this function call here
            int[] input = new int[] { 1, 1, 1, -5 };

            Console.WriteLine(LargestFour(input));
        }
    }
}
