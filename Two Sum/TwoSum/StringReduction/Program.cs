using System;
using System.Collections.Generic;

namespace StringReduction
{
    class Program
    {
        public static string StringReduction(string str)
        {
            int contReduction = 1;
            char element;
            int posElement = 0;

            Dictionary<char, int> abc = new Dictionary<char, int>();
            abc.Add('a', 0);
            abc.Add('b', 0);
            abc.Add('c', 0);

            char[] strClone = str.ToCharArray();

            if (str.Length > 0)
            {
                while (contReduction > 0)
                {
                    contReduction = 0;
                    element = str[0];
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (element != str[i] && (element == 'a' || element == 'b' || element == 'c') && (str[i] == 'a' || str[i] == 'b' || str[i] == 'c'))
                        {
                            abc[element]++;
                            abc[str[i]]++;

                            foreach (var itemAbc in abc)
                            {
                                if (itemAbc.Value == 0)
                                {
                                    strClone[i] = itemAbc.Key;
                                    strClone[posElement] = '@';
                                    contReduction++;
                                    break;
                                }
                            }
                            abc[element] = 0;
                            abc[str[i]] = 0;
                        }

                        element = strClone[i];
                        posElement = i;
                    }

                    str = "";

                    for (int i = 0; i < strClone.Length; i++)
                    {
                        if (strClone[i] != '@')
                            str += strClone[i];
                    }

                    strClone = str.ToCharArray();
                }
            }

            return str.Length.ToString();

        }

        static void Main()
        {
            // keep this function call here
            string cadena = "abcabc";

            Console.WriteLine(StringReduction(cadena));
        }
    }
}
