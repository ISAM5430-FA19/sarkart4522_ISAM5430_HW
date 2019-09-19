using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C13
{
    class Program
    {
        static void Main(string[] args)
        {
            double principal = 1000;
            double amount = 0;
            double amount1 = 0;
            double r = 0.05;
            double n = 0;
            for(r = 5; r <= 10; r++)
            {
                for (n = 1; n <= 10; n++)
                {
                    amount = Math.Pow((1 + r / 100), n);
                    amount1 = principal * amount;
                    WriteLine($"the year {r}% yields {amount1}");

                }
            }

            
            
            



        }
    }
}
