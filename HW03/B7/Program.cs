using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B7
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("enter a positive integer");
            int input = int.Parse(ReadLine());
            int sum = 0;
            int a = 0;
            while(input != 0)
            {
                a = input % 10;
                sum = sum * 10 + a;
                input = input / 10;
            }
            WriteLine($"Reverse number is {sum}");

           
        }
    }
}
