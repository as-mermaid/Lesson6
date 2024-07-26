using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string str1 = "";
            string str2 = "";

            foreach (char ch in str)
            {
                if (ch != ' ')
                {
                    str1 += char.ToLower(ch);
                    str2 = char.ToLower(ch) + str2;
                }
            }

            if (str1 == str2)
            {
                Console.WriteLine("Строка является полиндромом");
            }
            else
            {
                Console.WriteLine("Строка не является полиндромом");
            }
            Console.ReadKey();
        }
    }
}
