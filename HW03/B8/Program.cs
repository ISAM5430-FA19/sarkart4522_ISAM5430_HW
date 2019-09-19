using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B8
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("enter a positive integer");
            int a = int.Parse(ReadLine());
            WriteLine("enter a positive integer");
            int b = int.Parse(ReadLine());
            

            int sum1 = 0;
            int sum = a+b;
            while (sum != 0)
            {
                int r = sum % 10;
              
                
                    sum1 = sum1 * 10 + r;
                
                sum = sum / 10;
            }
            
           
            WriteLine($"Reverse sum is {sum1}");
        }
    }
}
