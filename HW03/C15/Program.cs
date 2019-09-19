using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C15
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("enter a positive number");
            int n = int.Parse(ReadLine());
            WriteLine("the pattern will be :");
            for(int i = 1; i <= n; i++)
            {
                for(int j = 1; j<= i; j++)
                {
                    Write(j);
                }
                WriteLine("");
            }
        }
    }
}
