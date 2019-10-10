using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B5
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("enter  Initial numbers");
            int item = int.Parse(ReadLine());
            
            int d = 0;
            int closestnumber = 0;
            int min = int.MaxValue;
            while(true)
            {
                WriteLine("enter numbers");
                int number = int.Parse(ReadLine());
                
                 if(item == number)
                {
                    break;
                }
                else
                {
                    d = Math.Abs(number - item);
                    if (d < min)
                    {
                        min = d;
                        closestnumber = number;
                    }
                    

                }
            }
            WriteLine($"closestnumber is {closestnumber}");

            }
        }
}
