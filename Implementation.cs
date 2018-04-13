using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace HackerRank
{
    public class Implementation
    {
        public static void extraLongFactorials(int n)
        {
            BigInteger number = 1;

            for (int i = 1; i <= n; i++)
            {
                number = number * i;
            }
            Console.WriteLine(number);
        }
    }
}
