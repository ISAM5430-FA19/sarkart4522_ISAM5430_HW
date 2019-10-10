using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    class Program
    {
        // QB. Divisible by 11
        static void Main(string[] args)
        {
            WriteLine("enter a digit");
            int n = int.Parse(ReadLine());
            int count = 0;
            int sum1 = 0;
            int sum2 = 0;
            int result = 0;
            while (n != 0)
            {
                int r = n % 10;
                count++;
                if(count%2 == 1)
                {
                    sum1 = sum1 + r;
                }
                else if(count%2 == 0)
                {
                    sum2 = sum2 + r;
                }
                n = n / 10;
            }
            result = sum1 - sum2;
            if(result%11 == 0)
            {
                WriteLine("it is divisible by 11");
            }
        }
    }
}
