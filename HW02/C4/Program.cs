using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4
{
    class Program
    {
        static void Main(string[] args)
        {
            // taking input for count
            WriteLine("Enter count");
            int count = int.Parse(Console.ReadLine());
            // i =0
            int i = 0;
            decimal sum = 0;
            decimal avg = 0;
            int input = 0;
            // i<count
            while (i< count)
            {
                // taking number input
                WriteLine("enter a number");
                input = int.Parse(Console.ReadLine());
                // sum becomes sum+input
                sum = sum + input;
                // increment i by 1
                i = i + 1;
            }
            // print sum
            WriteLine($"sum is {sum}.");
            
            avg = (decimal)( sum / count);
            // print avg
            WriteLine( $"avg is {avg}.");

        }
    }
}
