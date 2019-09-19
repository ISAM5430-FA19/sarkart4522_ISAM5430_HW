using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B9
{
    class Program
    {
        static void Main(string[] args)
        {
            String binary = null;
            string bit = "";
            WriteLine("enter a positive integer");
            int a = int.Parse(ReadLine());
            while(a != 0)
            {
                int r = a % 2;
                 bit = r.ToString();
                a = a / 2;
                binary = bit + binary;

            }
            
            WriteLine($"binary number of positive integer is : {binary}");
        }
    }
}
