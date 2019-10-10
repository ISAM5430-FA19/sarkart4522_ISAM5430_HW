using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxvalue = int.MinValue;
            int pre = 0;
            while (true)
            {
                Console.WriteLine("enter number");
                int a = int.Parse(Console.ReadLine());

                if (a < pre)
                {
                    break;
                }
                else
                {
                    pre = a;

                }
                if (a > maxvalue)
                {
                    maxvalue = a;
                }
            }
            Console.WriteLine($"max is {maxvalue}");

        }
        }
    }

