using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A
{
    class Program
    {
        // QA. Divisible by 3.
        static void Main(string[] args)
        {
            WriteLine("Enter a digit");
            int n = int.Parse(ReadLine());
            int sum = 0;
            while (n != 0)
            {
                int r = n % 10;
                sum = sum + r;
                n = n / 10;

            }
            if(sum%3 == 0)
            {
                WriteLine("it is divisible by 3");
            }
        }
    }
}
