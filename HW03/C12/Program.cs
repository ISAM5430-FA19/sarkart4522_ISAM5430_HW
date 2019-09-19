using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C12
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int count = 0;
            WriteLine("enter a positive integer");
            int a = int.Parse(ReadLine());
            for(int i = 1; i <= a; i++)
            {
                count = 0;
                for(int j = 2; j <= i/2; j++)
                {
                    if(i%j == 0)
                    {
                        count++;
                        break;
                    }
                    
                }
                if(count ==0 && i!=1)
                {
                    Write(  i  + "   ");
                        
                }

            }
        }
    }
}
