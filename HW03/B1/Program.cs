using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal sum = 0;
            int count = 0;
            decimal avg = 0;
            int max = int.MinValue;
            while (true)
            {
                Console.WriteLine("enter score 0 -100");
                int score = int.Parse(Console.ReadLine());



                if (score < 0 || score > 100)
                {
                    Console.WriteLine("Invalid scores entered, app has ended");
                    break;
                }
                else
                {
                    sum = sum + score;
                    count++;
                    if (score > max)
                    {
                        max = score;
                    }

                }




            }
            avg = sum / count;
            Console.WriteLine($"average is {avg}");

            Console.WriteLine($"best score is {max}");
        }
    }
}
