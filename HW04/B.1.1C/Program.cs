using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1._1B
{
    class Program
    {
        // Q.B.1.1 c sum of all permutation product
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (i != j)
                    {
                        for (int k = 1; k <= 5; k++)
                        {
                            if (k != i && k != j)
                            {
                                sum += i * j * k;
                                Console.Write($" {i}, {j}, {k}" + ";");
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
            Console.WriteLine(" sum is {0}", sum);
        }
    }
}
