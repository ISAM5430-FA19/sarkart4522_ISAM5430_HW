using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B._1._2.A
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            int sum4 = 0;
            
            int product = 1;
            //Two Combinations
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i + 1; j <= 5; j++)
                {
                    Console.Write(i + "," + j + ";");
                    product = i * j;
                    sum1 = sum1 + product;
                }
            }
            Console.WriteLine(sum1);
            Console.WriteLine();

            //Three Combinations
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i + 1; j <= 5; j++)
                {
                    for (int k = j + 1; k <= 5; k++)
                    {
                        Console.Write(i + "," + j + "," + k + ";");
                        product = i * j * k;
                        sum2 = sum2 + product;
                    }

                }
            }
            Console.WriteLine(sum2);
            Console.WriteLine();

            //Four Combinations
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i + 1; j <= 5; j++)
                {
                    for (int k = j + 1; k <= 5; k++)
                    {
                        for (int l = k + 1; l <= 5; l++)
                        {
                            Console.Write(i + "," + j + "," + k + "," + l + ";");
                            product = i * j * k * l;
                            sum3 = sum3 + product;
                        }
                    }

                }
            }
            Console.WriteLine(sum3);
            Console.WriteLine();
            //Five Combinations
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i + 1; j <= 5; j++)
                {
                    for (int k = j + 1; k <= 5; k++)
                    {
                        for (int l = k + 1; l <= 5; l++)
                        {
                            for (int m = l + 1; m <= 5; m++)
                            {
                                Console.Write(i + "," + j + "," + k + "," + l + "," + m + ";");
                                product = i * j * k * l * m;
                                sum4 = sum4 + product;
                            }

                        }
                    }

                }
            }
            Console.WriteLine(sum4);
            Console.ReadLine();
        }
    }
}
