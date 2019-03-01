using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex55_Rekursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fakultet(8));
            Console.WriteLine(Fakultet(0));

            for (int i = 0; i < 35; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
            Console.WriteLine();

            Console.WriteLine("Regninger");
            Console.WriteLine(IsPalindrom(Console.ReadLine()));

        }
        public static int Fakultet(int n)
        {
            int res = 1;
            if (n < 2)
            {
                return res;
            }
            else
            {
                return n * Fakultet(n - 1);
            }
        }
        public static int Fibonacci(int n)
        {
            if (n.Equals(0))
            {
                return 0;
            }
            else if (n.Equals(1))
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }
        //Palindrom virker ikke?
        public static bool IsPalindrom(string text)
        {
            text = string.Concat(text.Where(c => !char.IsWhiteSpace(c)));
            text = text.ToLower();
            if (text.Length <= 1)
            {
                return true;
            }
            else
            {
                if (!text[0].Equals(text[text.Length - 1]))
                {
                    return false;
                }
                else
                {
                    return IsPalindrom(text.Substring(1, text.Length - 2));
                }
            }
        }
    }
}
