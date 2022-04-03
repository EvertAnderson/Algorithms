using System;
using System.Collections.Generic;

namespace Coderbyte
{
    class Program
    {
        public static string MinWindowSubstring(string[] strArr)
        {
            Dictionary<char, int> countLetters = new Dictionary<char, int>();

            for (int i = (int)'a'; i <= (int)'z'; i++)
            {
                countLetters.Add((char)i, 0);
            }
            // code goes here
            foreach (var item in strArr[1])
            {
                countLetters[item]++;
            }

            Dictionary<char, int> countLetters2 = new Dictionary<char, int>(countLetters);

            int beginIndex = 0;
            int endIndex = 0;

            for (int i = 0; i < strArr[0].Length; i++)
            {
                if (countLetters[strArr[0][i]] > 0)
                    countLetters[strArr[0][i]]--;

                if (countZero(countLetters, strArr[1]))
                {
                    endIndex = i;
                    break;
                }
            }

            for (int i = strArr[0].Length - 1; i >= 0; i--)
            {
                if (countLetters2[strArr[0][i]] > 0)
                    countLetters2[strArr[0][i]]--;

                if (countZero(countLetters2, strArr[1]))
                {
                    beginIndex = i;
                    break;
                }
            }

            string finalString = "";

            for (int i = beginIndex; i <= endIndex; i++)
            {
                finalString += strArr[0][i];
            }

            return finalString;
        }

        public static bool countZero(Dictionary<char, int> dic, string strTwo)
        {
            foreach (var item in strTwo)
            {
                if (dic[item] > 0) return false;
            }

            return true;
        }

        static void Main()
        {
            // keep this function call here
            string[] cadena = { "aaffhkksemckelloe", "fhea" };
            Console.WriteLine(MinWindowSubstring(cadena));
        }
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");
        //}
    }
}
