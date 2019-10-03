using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B._2._4A
{
    class Program
    {
        //Q.B.2.4a  three letter word words with at least one vowel
        static void Main(string[] args)
        {
            for(char i = 'A'; i <= 'H'; i++)
            {
                for(char j = 'A'; j <= 'H'; j++)
                {
                    for(char k = 'A'; k <= 'H'; k++)
                    {
                        if((i=='A'|| i == 'E') || (j=='A' || j == 'E') || (k=='E' || k == 'A'))
                        {
                            Console.WriteLine("word with one vowel : {0},{1},{2}", i, j, k);
                        }
                    }
                }
            }
        }
    }
}
