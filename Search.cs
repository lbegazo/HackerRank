    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

namespace HackerRank
{
    public class Search
    {

        public static int pairs(int k, int[] arr)
        {
            Array.Sort(arr);
            HashSet<int> list = new HashSet<int>(arr);
            int sum = 0, count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                sum = arr[i] + k;
                if (list.Contains(sum))
                {
                    count++;
                }
            }
            /*
            int j = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                j = i - 1;
                while (j >= 0)
                {
                    if (arr[i] - arr[j] == k)
                    {                        
                        count++;
                        break;
                    }
                    j--;
                }
            }            
            */

            return count;
        }


        public static string solve(int[] a)
        {
            int sumLeft = 0, sumRight = 0;
            int sumTotal = a.Sum();

            if (a.Length == 1)
                return "YES";

            for (int i = a.Length - 1; i >= 0; i--)
            {
                sumRight += a[i];

                if (i > 0)
                    sumLeft = sumTotal - (sumRight + a[i - 1]);

                if (sumRight == sumLeft)
                {
                    return "YES";
                }
            }
            return "NO";
        }

        public static int gridlandMetro(int n, int m, int k, int[][] track)
        {
            int result = 0;

            return result;
        }


        public static void CapitalizeArray()
        {
            string[] firstNames = { "juan", "carlos", "pepe", "paola", "ricardo" };

            foreach (var item in firstNames)
            {
                Console.WriteLine(UppercaseFirst(item));
            }            
        }

        public static string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            return char.ToUpper(s[0]) + s.Substring(1);
        }




    }
}
