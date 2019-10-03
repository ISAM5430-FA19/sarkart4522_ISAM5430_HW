using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B._2._4A
{
    class Program
    {

        // Q.B.2.4b  words have middle number to be vowel
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'H'; i++)
            {
                for (char j = 'A'; j <= 'H'; j++)
                {
                    for (char k = 'A'; k <= 'H'; k++)
                    {
                        if ( j == 'A' || j == 'E')
                        {
                            Console.WriteLine("word have middle letter vowel : {0},{1},{2}", i, j, k);
                        }
                    }
                }
            }
        }
    }
}
