using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("enter no of times ");
            int n = int.Parse(ReadLine());
            int sum = 0;
            int previous = 0;
            for(int i = 0; i< n; i++)
            {
                WriteLine("enter input");
                int input = int.Parse(ReadLine());
                sum = sum + input;
                
                if (input == previous)
                {
                    WriteLine($"break from loop {sum}");
                    break;
                }
                previous = input;

            }
            WriteLine($"the sum is {sum}");

        }
    }
}
