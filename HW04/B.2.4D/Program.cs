using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B._2._4D
{
    class Program
    {
        // Q.B.2.4 d  middle letter is a vowel must contain one unique character
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'H'; i++)
            {
                for (char j = 'A'; j <= 'H'; j++)
                {
                    for (char k = 'A'; k <= 'H'; k++)
                    {
                       if((i!=j && i!=k) && (j=='A' || j == 'E') && (k!=i && k != j))
                        {
                            Console.WriteLine("{0},{1},{2}", i, j, k);
                        }
                    }
                }
            }
        }
    }
}
