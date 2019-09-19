using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B6
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int previous = 0;
            int min = int.MaxValue;
           // bool flag = false;
            int preprevious = 0;
            int preprevious1 = 0;

            while (true)
            {




                WriteLine("enter number");
                int currentNumber = int.Parse(ReadLine());
                if (currentNumber <= 0)
                {
                    break;
                }
                else
                {
                    WriteLine($"current number is {currentNumber}");
                    
                    if (currentNumber < min)
                    {
                        min = currentNumber;
                    }
                }
                preprevious1 = preprevious;
                preprevious = previous;
                previous = currentNumber;
                int a = min * min;
                if (a < previous)
                {

                    count++;

                    WriteLine("Smallest number in the sequence is : {0}", min);
                    WriteLine($"count is : {count}");
                    WriteLine("sequence is {0}, {1} {2}", preprevious1, preprevious, previous);
                }
                
            }




            
            

        }
    }
}
