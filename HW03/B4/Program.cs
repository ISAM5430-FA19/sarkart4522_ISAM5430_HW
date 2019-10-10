using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B4
{
    class Program
    {
        static void Main(string[] args)
        {
            int side1 = 0;
            int side2 = 0;
            int side3 = 0;
            for(int i =0; i<3; i++)
            {
                WriteLine("enter input");
                int input = int.Parse(ReadLine());


                if (input <= 0)
                {
                    break;
                }
                if (i == 0)
                {
                    side1 = input;
                }
                else if (i == 1) 
                {
                        side2 = input;
                }
                       else if (i == 2)
                        {
                            side3 = input;
                        }

                    }
                
               
                if ((side1 + side2) > side3)
                {
                    WriteLine("valid");
                }
                else
                {
                    WriteLine("invalid");
                }
                

            }
        }
    }

