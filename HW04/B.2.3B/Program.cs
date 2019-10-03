using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B._2._3B
{
    class Program
    {
        // Q.B.2 b  words have one consonent and one vowel
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'H'; i++)
            {
                for (char j = 'A'; j <= 'H'; j++)
                {
                    if (((i == 'A' || i == 'E') && (j != 'A' && j != 'E')) || ((i != 'A' && i != 'E') && (j == 'A' || j == 'E')))
                    {
                        
                       
                        
                        Console.WriteLine("words atleast one vowel and one consonent is {0}{1}", i, j);
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
