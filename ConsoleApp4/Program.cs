using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Maps(new[] { 1, 2, 3 });
            //GetMiddle1("middle");

            //DescendingOrder(2222131313);

            /*var haystack_1 = new object[] { '3', "123124234", null, "needle", "world", "hay", 2, '3', true, false };
            FindNeedle(haystack_1);*/
        }
        public static int[] Maps(int[] x)
        {
            Console.WriteLine(x.Select(e => e * 2).ToArray());
            return x.Select(e => e * 2).ToArray();
        }

        public static string GetMiddle1(string s)
        {
            if (s.Length % 2 != 0)
            {
                Console.WriteLine(s[s.Length / 2]);
                return Convert.ToString( s[s.Length / 2]);
            }
            return s.Substring(s.Length / 2 - 1,  2);
        }

        public static string GetMiddle(string s)
        {
            char[] letters = s.ToCharArray();
            if (letters.Length % 2 != 0)
            {
                Console.WriteLine(Convert.ToString(letters[letters.Length / 2]));
                return Convert.ToString( letters[letters.Length / 2]);
            }
            else
            {
                string rezult1 = Convert.ToString(letters[letters.Length / 2]);
                string rezult =Convert.ToString(letters[letters.Length / 2 - 1]) ; 
                Console.WriteLine(rezult+rezult1);
                return rezult + rezult1;
            }
        }

        public static string FindNeedle(object[] args)
        {
            string str = "needle";
            for(int i =0 ; i < args.Length; i++)
            {
                if( str == args[i])
                {
                    Console.WriteLine($"found the needle at position {i}");
                    return ($"found the needle at position {i}");
                }
            }

            return null;
        }



        public static int DescendingOrder(int num)
        {
            int[] digits = num.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();
            Array.Sort(digits);
            Array.Reverse(digits);

            Console.WriteLine(digits);
            string sorted = "";

            for (int i = 0; i < digits.Length; i++)
            {
                sorted = sorted + digits[i].ToString();
            }

            int result = int.Parse(sorted);
            Console.WriteLine(result);
            return result;
        }
    }
}
