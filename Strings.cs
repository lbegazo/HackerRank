using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class Strings
    {
        private const string alphabet = "abcdefghijklmnopqrstuvwxyz";

        public static int CamelCase(char[] arr)
        {
            int result = 0;
            result = arr.Where(x => char.IsUpper(x)).Count() + 1;
            return result;
        }

        public static void Capitalize()
        {
            string[] firstNames = { "juan", "carlos", "pepe", "paola", "ricardo" };

            foreach (var item in firstNames)
            {
                Console.WriteLine(char.ToUpper(item[0]) + item.Substring(1));
            }
        }

        public static string super_reduced_string(string s)
        {
            string a = string.Empty;
            StringBuilder sb = new StringBuilder(s);

            for (int i = 0; i < sb.Length - 1; i++)
            {
                if (sb[i] == sb[i + 1])
                {
                    sb.Remove(i, 2);
                    i = -1;
                }
            }

            return sb.Length == 0 ? "Empty String" : sb.ToString();
        }

        public static int twoCharaters(string s)
        {
            int result = 0;
            string chain = s;
            string chain2 = string.Empty;
            char[] arr = s.ToCharArray();
            HashSet<char> list = new HashSet<char>(s);
            char[] arr2 = list.ToArray();

            for (int i = 0; i < arr2.Length; i++)
            {
                char x = arr2[i];
                chain = chain.Replace(x.ToString(), "");

                var list2 = chain.GroupBy(p => p);


            }



            return result;

            /*
            int result = 0;
            char[] arr = s.ToCharArray();

            var list = arr.GroupBy(x => x);

            foreach (var item in list)
            {
                Console.WriteLine("{0}{1}",item.Key,item.Count());
            }

            var sort = (from i in list
                       orderby i.Count()
                       descending
                       select i).Take(2);
            
            foreach (var item in sort)
            {
                result += item.Count();
            }

            return result;
            */
        }

        public static string caesarCipher(string s, int k)
        {
            char[] arrAlphabet = alphabet.ToCharArray();
            char[] arrChain = s.ToCharArray();
            char[] arrNew = new char[s.Length];
            int index = 0, indexFinal = 0;

            if (k > alphabet.Length)
                k = k % alphabet.Length;

            for (int i = 0; i < arrChain.Length; i++)
            {
                if (char.IsLetter(arrChain[i]))
                {
                    index = alphabet.IndexOf(char.ToLower(arrChain[i]));

                    if ((index + k) <= alphabet.Length-1)
                        indexFinal = index + k;
                    else
                    {
                        indexFinal = k - (alphabet.Length - index);
                    }
                    arrNew[i] = char.IsUpper(arrChain[i]) ? char.ToUpper(arrAlphabet[indexFinal]) : arrAlphabet[indexFinal];
                }
                else
                {
                    arrNew[i] = arrChain[i];
                }
            }

            return new string(arrNew);
        }
    }
}
