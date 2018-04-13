    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

namespace HackerRank
{
    public class Sorting
    {

        public static int findIndexOfArray(int V, int[] arr)
        {
            int index = 0;
            index = Array.IndexOf(arr, V);
            return index;
        }

        public static string[] bigSorting(string[] arr)
        {
            Array.Sort(arr, SortBigNumbersHelper.SortBigNumbers());
            return arr;
        }

        public class SortBigNumbersHelper : IComparer
        {
            public static IComparer SortBigNumbers()
            {
                return (IComparer)new SortBigNumbersHelper();
            }

            public int Compare(object p, object q)
            {
                string x = p.ToString(), y = q.ToString();

                if (x.Length != y.Length)
                    return x.Length - y.Length;


                for (int i = 0; i < x.Length; i++)
                {
                    char left = x[i];
                    char right = y[i];

                    if (left != right)
                        return left - right;
                }

                return 0;
            }
        }

        public static void insertionSort1(int n, int[] arr)
        {
            int lastInt = arr[n - 1];
            int replaceInt = 0;

            for (int i = n - 1; i > 0; i--)
            {
                if (arr[i - 1] > lastInt)
                {
                    arr[i] = arr[i - 1];
                    replaceInt = arr[i];
                    printArray(arr);
                }
            }

            int index = Array.IndexOf(arr, replaceInt);
            arr[index] = lastInt;
            printArray(arr);

        }

        public static void insertionSort2(int n, int[] arr)
        {
            int temp1 = 0, temp2 = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    //count++;
                    temp1 = arr[i + 1];
                    arr[i + 1] = arr[i];
                    arr[i] = temp1;

                    for (int j = i; j >= 1; j--)
                    {
                        if (temp1 < arr[j - 1])
                        {
                            //count++;
                            temp2 = arr[j - 1];
                            arr[j] = temp2;
                            arr[j - 1] = temp1;
                        }
                    }
                }
                printArray(arr);
            }

        }

        private static void printArray(int[] arr)
        {
            string message = string.Empty;
            for (int i = 0; i < arr.Length; i++)
            {
                message += String.Concat(arr[i].ToString(), " ");
                if (i + 1 == arr.Length)
                {
                    Console.WriteLine(message);
                }
            }
        }

        public static int[] countingSort(int[] arr)
        {
            int[] range = new int[100];

            foreach (var item in arr)
            {
                range[item]++;
            }

            return range;
        }

        public static int runningTime(int[] arr)
        {
            int temp1, temp2 = 0, count=0;

            for (int i = 0; i < arr.Length-1; i++)
            {
                if (arr[i] > arr[i + 1])
                {
                    count++;
                    temp1 = arr[i + 1];
                    arr[i + 1] = arr[i];
                    arr[i] = temp1;

                    for (int j = i; j >= 1; j--)
                    {
                        if (temp1 < arr[j - 1])
                        {
                            count++;
                            temp2 = arr[j - 1];
                            arr[j] = temp2;
                            arr[j-1] = temp1;
                        }
                    }
                }
                //printArray(arr);
            }

            return count;
        }

        public static void countingSort2(int[] arr)
        {
            StringBuilder chain = new StringBuilder();

            int[] range = new int[100];

            foreach (var item in arr)
            {
                range[item]++;
            }

            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < range[i]; j++)
                {
                    chain.Append(i.ToString() + " ");
                }
                
            }

            Console.WriteLine(chain);
        }
    }
}
