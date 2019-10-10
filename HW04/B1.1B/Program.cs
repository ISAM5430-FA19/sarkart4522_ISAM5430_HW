using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1._1B
{
    class Program
    {
        // Q.B.1.1.b  permutation with three numbers.
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i != j)
                    {
                        for(int k =1; k<=5; k++)
                        {
                            if(k!= i && k != j)
                            {
                                Console.Write($" {i}, {j}, {k}"+  ";");
                            }
                            else
                            {
                                continue;
                            }
                        }
                        
                    }
                    else
                    {
                        continue;
                    }
                   
                }
            }
        }
    }
}
