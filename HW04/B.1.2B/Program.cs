using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B._1._2B
{
    class Program
    {
        //Q.B.1.2 b sum of all combination product
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = i + 1; j <= 5; j++)
                {
                    for (int k = j + 1; k <= 5; k++)
                    {
                        sum += i * j * k;
                        Console.WriteLine("{0},{1}, {2};", i, j, k);
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
