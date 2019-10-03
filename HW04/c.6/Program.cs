using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int count_vowel = 0;
            int count_conso = 0;
            int previous = 0;
            bool increasing = false;
            int syllable_count = 0;
            bool alternate = false;
            bool smooth = false;
            bool secondhalf = false;

            string result = "";
           

            while (true)
            {
                var key_info = Console.ReadKey();
               
                 char letter = char.ToUpperInvariant(key_info.KeyChar);
                char current = letter;

                
               
                if (!char.IsLetter(letter))
                {
                    break;
                }
                //Q.6 number of letter entered by user.
                count++;

                // Q.7 check for vowels aor consonants
                if (letter  == 'A' || letter == 'E' || letter =='I' || letter == 'O' || letter == 'U')
                {
                    count_vowel++;
                }
                else
                {
                    count_conso++;
                }
                //Q8.A count the number of syllables
                if((current == 'A' || current == 'E' || current == 'I' || current=='O' || current=='U') && (current!= 'A' ||
                    current!= 'E' ||  current!='I' || current != 'O'))
                {
                    syllable_count++;
                }
                //Q.9A.letters in increaing order

                if (current > previous)
                {
                    increasing = true;
                }
               // previous = current;
                // Q.9 B word on a musical instrument
                if (letter == 'C' || letter == 'A' || letter == 'D' || letter == 'E' || letter == 'F' || letter == 'G' || letter == 'B')
                {
                    result = result + letter + "";
                }
                else
                {
                    Console.WriteLine("result is {0}", result);
                    result = null;
                }
                //Q.9 C all letters in the second half of the alphabet
                if(letter>='N' && letter <= 'Z')
                {
                    secondhalf = true;
                }
                else
                {
                    secondhalf = false;
                }
                //Q.9 D word only alternate between vowel and consonent
                if(((letter == 'A' || letter=='E' || letter == 'I' || letter == 'O' || letter== 'U') && (letter+1 != 'A' || letter+1 != 'E' ||
                    letter+1!= 'I' || letter+1 != 'U' || letter+1!= 'O')) || ((letter != 'A' || letter != 'E' || letter != 'I' || letter != 'O' || letter != 'U') && (letter + 1 == 'A' || letter + 1 == 'E' ||
                    letter + 1 == 'I' || letter + 1 == 'U' || letter + 1 == 'O')))
                {
                    alternate = true;
                }
                else
                {
                    alternate = false;
                }
                //Q.9 E letter in th word have smooth transition

                if(current- previous <= 1)
                {
                    smooth = true;
                }
                else
                {
                    smooth = false;
                }


                previous = current;
            }
            Console.WriteLine("no of letter entered by user is {0}", count);
            Console.WriteLine("no of vowel and no of consonent entered by user is {0} {1}", count_vowel,count_conso);
            Console.WriteLine("syllables count is :", syllable_count);
            Console.WriteLine("All letter in increasing order {0}", increasing);
            Console.WriteLine("Alternate between vowel and consonent {0}", alternate);
            Console.WriteLine("result is {0}", result);
            Console.WriteLine("smooth transition is  {0}", smooth);
            Console.WriteLine("letter in second half  {0}", secondhalf);




        }
    }
}
