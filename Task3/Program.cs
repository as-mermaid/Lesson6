using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string result = "";
            int braceCount = 0;

            foreach (char ch in s)
            {
                if (ch == '{')
                {
                    braceCount++;
                }
                else if (ch == '}')
                {
                    if (braceCount > 0)
                        braceCount--;
                }
                else
                {
                    if (braceCount == 0)
                        result += ch;
                }
            }

           
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
