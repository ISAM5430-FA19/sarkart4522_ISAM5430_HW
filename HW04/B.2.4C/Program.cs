using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B._2._4C
{
    class Program
    {

        // Q.B.2.4c  words consist of one consonent and one vowel
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'H'; i++)
            {
                for (char j = 'A'; j <= 'H'; j++)
                {
                    for (char k = 'A'; k <= 'H'; k++)
                    {
                        if ((i != 'A' || i != 'E') && (j == 'A' && j == 'E') && (k == 'A' && k == 'E'))
                        {
                            Console.WriteLine("words with one consonent and vowel: {0},{1},{2}", i, j, k);
                        }
                        else if ((i != 'A' || i!= 'E') && (j != 'A' && j != 'E') && (k != 'A' && k != 'E'))
                        {
                            Console.WriteLine("words with one consonent and vowel: {0},{1},{2}", i, j, k);
                        }
                           else if ((i == 'A' || i== 'E') && (j == 'A' && j == 'E') && (k!=i || i != k))
                                                      
                            {
                            if (i!=j || j!=k) {

                                Console.WriteLine("words with one consonent and vowel: {0},{1},{2}", i, j, k);
                            }
                            }
                        
                        
                        





                     
                                
                        
                    }
                }
            }
        }
    }
}
