using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    // Qc. Divisible by 2^d.
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("enter a integer");
            int n = int.Parse(ReadLine());
            WriteLine("enter the power");
            int d = int.Parse(ReadLine());
            int r = n % 10;
            int last_digit = r;
            if(last_digit%d == 0)
            {
                WriteLine("number is divisible by power");
            }
            else
            {
                WriteLine("number is not divisible by power");
            }
        }
    }
}
