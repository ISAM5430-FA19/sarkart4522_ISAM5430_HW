using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B._2._5a
{
    class Program
    {
        static void Main(string[] args)
        {

            for (char a = 'A'; a <= 'H'; a++)
            {
                bool vowelA = a == 'A' || a == 'E';

                for (char b = 'A'; b <= 'H'; b++)
                {
                    bool vowelB = b == 'A' || b == 'E';
                    int vowels2 = (vowelA ? 1 : 0) + (vowelB ? 1 : 0);
                    if (vowels2 >= 1)
                    {
                        Write($"{a}{b}");
                    }
                    for (char c = 'A'; c <= 'H'; c++)
                    {
                        bool vowelC = c == 'A' || c == 'E';
                        // if (a == 'A' || a == 'E' || b == 'A' || b == 'E')

                        int vowels = vowels2 + (vowelC ? 1 : 0);
                        //  int consonants= (!vowelA ? 1 : 0) + (!vowelB ? 1 : 0) + (!vowelC ? 1 : 0);

                        //var x=booleanststement==true? truestatement:falsestatement. <---- C-like language


                        if (vowels == 1 || vowels == 2)
                            Write($"{a}{b}{c}  ");



                    }
                }
            }
        }
    }
}