using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string s = Console.ReadLine();

            if (isPalindrom(s) == true)
            {
                Console.WriteLine("Это предложение является полнидромом");
            }
            else
            {
                Console.WriteLine("Это предложение не является полиндромом");
            }
            Console.ReadLine();
        }
        public static bool isPalindrom(string s)
        {

            bool p = true;

            for (int i = 0; i < s.Length - 1; i++)
            {
                int m = s.Length - 1 - i;

                if (s[i] != s[m])
                {
                    p = false;
                }
            }
            return p;
        }

    }
}
