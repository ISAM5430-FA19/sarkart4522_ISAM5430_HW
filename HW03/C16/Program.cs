using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C16
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("enter a positive number");
            int n = int.Parse(ReadLine());
            for(int row = 1; row<= n; row++)
            {
                for(int col = 1; col<= n- row; col++)
                {
                    Write("0");
                }
                for(int col =row; col>= 1; col--)
                {
                    Write(col);
                }
                WriteLine("");
            }

        }
    }
}
