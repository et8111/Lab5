using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        public static long FACS(long num)
        {
            return (num == 1) ? 1 : num * FACS(num - 1);
        }

        public static long MAX(long num, int next) //9223372036854775807
        {
            num *= (next + 1);
            return (num > 0)? MAX(num, next+1): next;
        }

        static void Main(string[] args)
        {
            bool s = true;
            //long temp = 0;
            while (s)
            {
                Console.Write("ENTER SOMETHING (1-20): ");
                int num = int.Parse(Console.ReadLine());
                if (num > 20 || num < 1)
                    continue;
                Console.WriteLine("FACTORIAL OF " + num + " IS " + FACS(num));
                Console.Write("AGAIN (y/n)?: ");
                s = (Console.ReadLine() == "y") ? true : false;
            }
            //Console.Write("RUN MAX  (y/n)???:");
            //if (Console.ReadLine() == "y")
            //    temp = MAX(1,1);
            //Console.WriteLine("MAX FACTORIAL OF " + temp + " IS " + FACS(temp));
        }
    }
}
