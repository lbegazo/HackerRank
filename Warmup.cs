using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class Warmup
    {
        public static int simpleArraySum(int[] ar)
        {
            return ar.Sum();
        }

        public static long[] miniMaxSum(long[] arr)
        {
            long max = 0, min = 0, total = 0;
            long[] result = new long[2];
            Array.Sort(arr);

            total = arr.Sum();
            max = total - arr[arr.Length - 1];
            min = total - arr[0];

            result[0] = max;
            result[1] = min;

            return result;
        }

        public static int birthdayCakeCandles(int n, int[] ar)
        {
            int max = 0, result = 0;
            max=ar.Max();

            result = ar.Where(i => i == max).Count();

            return result;
        }

    }
}
