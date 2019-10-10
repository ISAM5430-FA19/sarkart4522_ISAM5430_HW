using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C._14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            WriteLine("(a)");
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Write("*");
                }
                WriteLine("");
            }

            // (b)
            WriteLine("(b)");
            for (int row1 = n; row1 >= 1; row1--)
            {
                for (int col1 = 1; col1 <= row1; col1++)
                {

                    Write("*");
                }
                WriteLine("");
            }


            WriteLine("(c)");

               for(int row2 = n; row2 >= 1; row2--)
                {
                    for(int col2 = 1; col2<= n - row2; col2++)
                    {
                        Write(" ");
                    }
                    for (int col2 = 1; col2 <= row2; col2++)
                    {
                        Write("*");
                    }
                    WriteLine("");
                }
            

            WriteLine("(d)");


            for (int row3 = 1; row3 <= n; row3++)
            {
                for (int col3 = 1; col3 <= n - row3 ; col3++)
                {
                    Write(" ");
                }
                for(int col3 = 1; col3 <= row3; col3++)
                {
                    Write("*");
                }
                WriteLine(" ");
            }
           

        }
    }
}
