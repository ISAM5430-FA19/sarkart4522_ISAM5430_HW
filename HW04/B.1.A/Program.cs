using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B._1.A
{
    class Program
    {
        // Q. B.1 1 a. With one number, you should see 1,2,3,4,5
        static void Main(string[] args)
        {
            for(int i =1; i<=5; i++)
            {
                for(int j = 1; j<=5; j++)
                {
                    if(i == j)
                    {
                        continue;
                    }
                    else
                    {
                        Console.Write(i+","+j +   ";" );
                    }
                }
            }
        }
    }
}
