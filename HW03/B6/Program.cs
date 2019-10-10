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
            int i = 1;
            int count = 0;
            int min = int.MaxValue;

            string output = "";
            WriteLine("enter input");

            while (i > 0)
            {

                count++;
                i = int.Parse(ReadLine());
                if (i < min)
                {
                    min = i;
                }
                else if (min*min <= i)
                {
                    output += i + "|";
                    WriteLine("count:" + count + "\n output:" + output);
                    WriteLine("\n Enter new set of numbers:");
                    i = 1;
                    count = 0;
                    min = int.MaxValue;
                }
                if (count != 0)
                {
                    output += i + ",";

                }
            }
            WriteLine("\n  result: " + output);



                
                



            
            

        }
    }
}
