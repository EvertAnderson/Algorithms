using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace TwoSum
{
    class Result
    {

        /*
         * Complete the 'simpleArraySum' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts INTEGER_ARRAY ar as parameter.
         */

        public static int simpleArraySum(List<int> ar)
        {
            int suma = 0;
            foreach (var item in ar)
            {
                suma += item;
            }
            return suma;
            //return ar.Sum();
        }
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> result = new List<int> { 0, 0 };

            if(a.Count == b.Count && a.Count >= 3)
            {
                for (int i = 0; i < a.Count; i++)
                {
                    if (a[i] > b[i])
                    {
                        result[0]++;
                    }
                    else if (b[i] < a[i])
                    {
                        result[1]++;
                    }
                }
            }

            return result;
        }

        public static int diagonalDifference(List<List<int>> arr)
        {
            int sumRight = 0;
            int sumLeft = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                sumRight += arr[i][i];
                sumLeft += arr[i][arr.Count - 1 - i];
            }

            return Math.Abs(sumRight - sumLeft);
        }

        public static void plusMinus(List<int> arr)
        {
            Dictionary<int, double> dict = new Dictionary<int, double> { { 0, 0 }, { 1, 0 }, { 2, 0 } };

            foreach (var item in arr)
            {
                if (item > 0) dict[0]++;
                else if (item < 0) dict[1]++;
                else dict[2]++;
            }

            if(arr.Count > 0)
            {
                Console.WriteLine("{0:N6}", dict[0] / arr.Count);
                Console.WriteLine("{0:N6}", dict[1] / arr.Count);
                Console.WriteLine("{0:N6}", dict[2] / arr.Count);
            }
        }
        public static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j < n-i-1 )
                    {
                        Console.Write(" ");
                    } 
                    else
                    {
                        Console.Write("#");
                    }
                }
                Console.WriteLine();
            }
        }

        public static void miniMaxSum(List<int> arr)
        {
            long min = arr[0]; long max = arr[0];
            long sum = 0;
            foreach (var item in arr)
            {
                if (min < item) min = item;
                if (max > item) max = item;
                sum += item;
            }

            Console.WriteLine("{0} {1}", sum - min, sum - max);
        }

        public static void fizzBuzz(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (n % 3 != 0 && n % 5 != 0) Console.WriteLine(n.ToString());
                else if (n % 3 == 0) Console.WriteLine("Fizz");
                else if (n % 5 == 0) Console.WriteLine("Buzz");
                else if (n % 3 == 0 && n % 5 == 0) Console.WriteLine("FizzBuzz");
            }
        }

        public static int birthdayCakeCandles(List<int> candles)
        {
            int max = 0;
            int cont = 0;
            foreach (var item in candles)
            {
                if (item > max)
                {
                    max = item;
                    cont = 1;
                } 
                else if (item == max)
                {
                    cont++;
                }
            }

            return cont;
        }

        public static string timeConversion(string s)
        {
            string temp = s.Substring(0, 8);
            if (s.Length == 10)
            {
                string[] sDate = new string[3];
                sDate = s.Split(':');
                if (sDate[2].Contains("PM"))
                {
                    temp = (Convert.ToInt32(sDate[0]) == 12 ? Convert.ToInt32(sDate[0]) : Convert.ToInt32(sDate[0]) + 12).ToString().PadLeft(2);
                } 
                else
                {
                    temp = (Convert.ToInt32(sDate[0]) == 12 ? 0 : Convert.ToInt32(sDate[0])).ToString("D2");
                }
                temp += ":" + sDate[1] + ":" + sDate[2].Substring(0, 2);
            }
            return temp;
        }

        public static int camelcase(string s)
        {
            bool justLetters = true;
            //Validate letters from a-z to A-Z
            foreach (var item in s)
            {
                if ((item < 'a' || item > 'z') && (item < 'A' || item > 'Z'))
                {
                    justLetters = false;
                    break;
                }
            }

            int count = 0;

            if (justLetters)
            {
                foreach (var item in s)
                {
                    if (count == 0 && item == s.First() && item >= 'a' && item <= 'z' )
                    {
                        count++;
                    }
                    else if (count >= 1 && item >= 'A' && item <= 'Z')
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        public static int roundUp(int n)
        {
            return (n + 4) / 5 * 5;
        }

        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> newGrades = new List<int>(grades);

            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] >= 38 && grades[i] % 5 > 2)
                {
                    newGrades[i] = (grades[i] + 4) / 5 * 5;
                }
            }

            return newGrades;
        }

        public static List<int> gradingStudents2(List<int> grades)
        {
            List<int> newGrades = new List<int>(grades);

            for (int i = 0; i < grades.Count; i++)
            {
                newGrades[i] = (grades[i] + 4) / 5 * 5;
            }

            return newGrades;
        }

        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            int appleCount = 0; int orangeCount = 0;

            foreach (var item in apples)
            {
                if (a + item >= s && a + item <= t)
                {
                    appleCount++;
                }
            }

            foreach (var item in oranges)
            {
                if (b + item >= s && b + item <= t)
                {
                    orangeCount++;
                }
            }

            Console.WriteLine(appleCount);
            Console.WriteLine(orangeCount);
        }

        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            bool minorX = x1 < x2 ? true : false;
            bool initialPos = minorX;

            while (initialPos == minorX)
            {
                x1 += v1;
                x2 += v2;

                minorX = x1 < x2 ? true : false;
            }

            if (x1 == x2)
                return "YES";
            else
                return "NO";
        }

        public class Tree
        {
            public string letter { get; set; }
            public List<Tree> children { get; set; }
        }

        public static Tree fillTree()
        {
            Tree tree = new Tree() { children = new List<Tree>() };
            tree.children.Add(new Tree() { letter = "E", children = new List<Tree>() });
            tree.children.Add(new Tree() { letter = "T", children = new List<Tree>() });
            //Left Arm E
            tree.children[0].children.Add(new Tree() { letter = "I", children = new List<Tree>() });
            tree.children[0].children.Add(new Tree() { letter = "A", children = new List<Tree>() });
            //Left Arm I
            tree.children[0].children[0].children.Add(new Tree() { letter = "S", children = new List<Tree>() });
            tree.children[0].children[0].children.Add(new Tree() { letter = "U", children = new List<Tree>() });
            //Right Arm A
            tree.children[0].children[1].children.Add(new Tree() { letter = "R", children = new List<Tree>() });
            tree.children[0].children[1].children.Add(new Tree() { letter = "W", children = new List<Tree>() });

            //Right Arm T
            tree.children[1].children.Add(new Tree() { letter = "N", children = new List<Tree>() });
            tree.children[1].children.Add(new Tree() { letter = "M", children = new List<Tree>() });
            //Left Arm N
            tree.children[1].children[0].children.Add(new Tree() { letter = "D", children = new List<Tree>() });
            tree.children[1].children[0].children.Add(new Tree() { letter = "K", children = new List<Tree>() });
            //Right Arm M
            tree.children[1].children[1].children.Add(new Tree() { letter = "G", children = new List<Tree>() });
            tree.children[1].children[1].children.Add(new Tree() { letter = "O", children = new List<Tree>() });

            return tree;
        }

        public static void PrintTree(Tree parentNode, string signals, ref List<string> list)
        {
            if (signals.Length == 0)
            { 
                list.Add(parentNode.letter);
                return;
            }

            if (signals[0] == '.')
            {
                PrintTree(parentNode.children[0], signals.Substring(1), ref list);
            }
            else if (signals[0] == '-')
            {
                PrintTree(parentNode.children[1], signals.Substring(1), ref list);
            }
            else if (signals[0] == '?')
            {
                PrintTree(parentNode.children[0], signals.Substring(1), ref list);
                PrintTree(parentNode.children[1], signals.Substring(1), ref list);
            }
        }

        public static string[] Possibilities(string signals)
        {
            Tree tree = fillTree();
            List<string> list = new List<string>();

            PrintTree(tree, signals, ref list);

            return list.ToArray();
        }


        public static string[,] GenerateMatrixData(string data)
        {
            var nRows = data.Split("\n");
            var nColumns = nRows.Length > 0 ? nRows[0].Split(',').Length : 0;

            var matrix = new string[nRows.Length, nColumns];

            for (int i = 0; i < nRows.Length; i++)
            {
                var columns = nRows[i].Split(',');
                for (int j = 0; j < nColumns; j++)
                {
                    matrix[i, j] = columns[j];
                }
            }

            return matrix;
        }

        public static List<List<string>> SwapColumnsInMatrix(string[,] matrix, int rows, int columns)
        {
            var table = new List<List<string>>();

            for (int i = 0; i < columns; i++)
            {
                var list = new List<string>();
                for (int j = 0; j < rows; j++)
                {
                    list.Add(matrix[j, i]);
                }
                table.Add(list);
            }

            return table;
        }

        public static string PrintResult(List<List<string>> table, int rows, int columns)
        {
            string result = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                        result += table[j][i] + ",";
                    else
                        result += table[j][i];
                }
                if (i != rows - 1)
                    result += "\n";
            }

            return result;
        }

        public static string SortCsvColumns(string csvData)
        {
            var rows = csvData.Split("\n");
            var nColumns = rows.Length > 0 ? rows[0].Split(',').Length : 0;

            var matrix = GenerateMatrixData(csvData);
            var table = SwapColumnsInMatrix(matrix, rows.Length, nColumns);

            //Order by Columns base on the name
            table = table.OrderBy(x => x[0]).ToList();

            Console.WriteLine(csvData);
            Console.WriteLine(PrintResult(table, rows.Length, nColumns));
            return PrintResult(table, rows.Length, nColumns);
        }

        public static int[] Merge(int[] nums1, int m, int[] nums2, int n)
        {
            List<int> nums3 = new List<int>();
            int x = m + n;
            //if (n > m) x = n;

            int iM = 0;
            int iN = 0;

            //{ 1, 2, 3 }
            //{ 2, 5, 6 }
            /*
             * 
             */

            for (int i = 0; i < x; i++)
            {
                //int iM2 = iM;
                //int iN2 = iN;
                if (iM < m && iN < n && nums1[iM] == nums2[iN])
                {
                    nums3.Add(nums1[iM]);
                    nums3.Add(nums1[iM]);
                    iM++;
                    iN++;
                    i++;
                }
                else {
                    if (iM < m)
                    {
                        if(iN == n)
                        {
                            nums3.Add(nums1[iM]);
                            iM++;
                        } else if (nums1[iM] < nums2[iN])
                        {

                        }

                        nums3.Add(nums1[iM]);
                        iM++;
                    }
                    else if (iN < n && nums2[iN] < nums1[iM])
                    {
                        nums3.Add(nums2[iN]);
                        iN++;
                    }
                } 
            }

            return nums3.ToArray();
        }

        public static string MathChallenge(string str)
        {
            str = Regex.Replace(str, "\\s+", "");

            List<string> numbers = Regex.Replace(str, @"[a-zA-Z+\-*/=]", "@").Trim('@').Split('@').ToList();
            List<int> onlyNumbers = numbers.Select(x => int.Parse(x)).ToList();

            foreach (var item in str)
            {
                int a = 0;
            }

            return str;
        }

        public static bool Exits(int[] ints, int k)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] == k)
                    return true;
            }
            return false;
        }
        public static int ComputeCloseToZero(int[] ts)
        {
            int min = int.MaxValue;

            for (int i = 0; i < ts.Length; i++)
            {
                if (Math.Abs(ts[i]) < Math.Abs(min))
                    min = ts[i];
                else if (Math.Abs(ts[i]) == Math.Abs(min) && ts[i] > min)
                    min = ts[i];
            }
            return min;
        }
    }
    class Program
    {
        static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            Dictionary<string, int> dict2 = new Dictionary<string, int>();

            if(dict2.ContainsKey("Hola"))
            {
                dict2["Hola"]++;
            }


            List<int> result = new List<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int rest = target - nums[i];
                if (dict.FirstOrDefault(x => x.Value == rest).Value != dict.Values.Last())
                {
                    result.Add(dict[rest]);
                    result.Add(i);
                    break;
                }
                else
                {
                    dict.Add(i, nums[i]);
                }
            }

            return result.ToArray();
        }
        static void Main(string[] args)
        {
            var list = new List<int>() { 40, 38, 37, 80, 99, 77 };
            int[] nums1 = new int[3] { 1, 2, 3 };
            int[] nums2 = new int[3] { 2, 5, 6 };
            int[] nums3 = new int[4] { -9, 14, 37, 102 };

            //var result = Result.Merge(nums1, nums1.Length, nums2, nums2.Length);
            //Result.Possibilities("?-?");
            //Result.SortCsvColumns("Beth,Charles,Danielle,Adam,Eric\n17945,10091,10088,3907,10132\n2,12,13,48,11");
            Console.WriteLine(Result.Exits(nums3, 36) ? "true" : "false");
            Console.ReadKey();
        }
    }
}
