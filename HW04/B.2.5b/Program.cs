using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B._2._5b
{
    class Program
    {
        static void Main(string[] args)
        {
            for(char a = 'A'; a <= 'H'; a++)
            {
                bool consonantA = a == 'B' || a == 'C' || a == 'D' || a == 'G' || a == 'F' || a == 'H';
                int consonant = (consonantA ? 1 : 0);
                for(char b = 'A'; b <= 'H'; b++)
                {
                    for(char c = 'A'; c <= 'H'; c++)
                    {
                        bool vowel1 = c == 'E' || c == 'A';
                        int vowelB = (vowel1 ? 1 : 0);
                        if(consonant>=1 && vowelB >= 1)
                        {
                            Console.Write($"{a}{b}{c}");
                        }
                    }
                }
            }
        }
    }
}
