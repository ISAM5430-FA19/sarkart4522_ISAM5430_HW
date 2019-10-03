using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C._9_F
{
    class Program
    {
        //Q.9.F do all letters in the word have alternating order
        static void Main(string[] args)
        {
            WriteLine("enter the first character");
            char pre = char.Parse(ReadLine());
            WriteLine("enter second char");
            char curr = char.Parse(ReadLine());
            bool isdesc = false;
            bool isasc = false;

            if (pre > curr)
            {
                isdesc = true;
            }
            else if (pre < curr)
            {
                isasc = true;
            }


            while (true)
            {
                var key_info = Console.ReadKey();

                char letter = char.ToUpperInvariant(key_info.KeyChar);
                char current = letter;



                if (!char.IsLetter(letter))
                {
                    break;
                }
                if (isasc == true)
                {
                    if (current > pre)
                    {
                        isasc = true;
                        isdesc = false;
                    }
                    else
                    {
                        break;
                    }
                }
                else if (isdesc == true)
                {
                    if (pre > current)
                    {
                        isdesc = true;
                        isasc = false;
                    }
                    else
                    {
                        break;
                    }
                }
                pre = current;
            }
        }
    }
}
