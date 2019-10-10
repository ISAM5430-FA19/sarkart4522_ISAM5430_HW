using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B._2._3C
{
    class Program
    {
        //Q.B.2.3C words begin with consonent and end with vowel
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'H'; i++)
            {
                for (char j = 'A'; j <= 'H'; j++)
                {
                    if((i!='A' && i != 'E') && (j=='A' || j == 'E'))
                    {
                        Console.WriteLine("words starting with consonent and end with vowel  {0},{1}:", i, j);
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
