using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B._2._5c
{
    class Program
    {
        static void Main(string[] args)
        {
            for(char c = 'A'; c <= 'H'; c++)
            {
                for(char s = 'A'; s <= 'H'; s++)
                {
                    bool vowelA = s == 'A' || s == 'E';
                    {
                        int vowel = (vowelA ? 1 : 0);
                            {

                            if(vowel == 1)
                            {
                                Console.Write($"{c}{s}");
                            }
                        }
                        for(char z = 'A'; z <= 'H'; z++)
                        {
                            if(c!=z && vowel == 1)
                            {
                                Console.Write($"{c}{s}{z}");
                            }
                        }
                    }
                }
            }
        }
    }
}
