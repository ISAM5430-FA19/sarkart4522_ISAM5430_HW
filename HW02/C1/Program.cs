using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1
{
    class Program
    {
        static void Main(string[] args)
        {
           //c.1 Questsion 1 20,19,18,17......1
            //num=20
            int num = 20;
            //while num <=1
            while (num >= 1)
            {
                //print num
                WriteLine(num);
                //num = num-1
                num = num - 1;
            }
            //c.1 question 2,4,6,8....
            //i=2
            int i = 2;
            //while i less than equal to 10
            while(i<= 10)
            {
                // print i
                Write(i + "  " );
                //increment i by 2
                i = i + 2;
            }

            // c.1 question 3 10,20,30.....
            //j=0
            int j = 0;
            // condition j<100
            while (j < 100)
            {
                // print j
                Write(j + " ");
                //increment j by 10
                j = j + 10;
            }

            // c.1 question 4  1,5,7,11,13,17,19
            //k=0
            int k = 1;
            //condition k<20
            while(k < 20)
            {
                //k is odd and not divisible by 3
                if(k%2 == 1 && k%3 != 0)
                {
                    //print k
                    Write(k + "  ");
                }
                //incrementing k by 1
                k = k + 1;
            }
            // c.1 question 6 
            // a=1
            int a = 1;
            //while a <=100
            while (a <= 100)
            {
                if ((a%3 !=0 && a%5 !=0) || (a%3 ==0 && a%5 == 0))
                {
                    //print a
                    WriteLine(a);
                }
                //incerementing a by 1
                a = a + 1;
            }
            //c.1 question7 

            char c = 'a';
            while(c <= 'z')
            {
                //print char c
                Write(c + " ");
                //incrementing c by 1
                c++;
                
            }
            //c.1 question 5
            // m =4
            int m = 4;
            int result = 0;
            while (m < 10)
            {
                // m power 2
                result = (int )Math.Pow(m,2);
                //print result
                WriteLine(result);
                //incrementing m by 1
                m = m + 1;
            }
           

            
        }
       
         

    }
}
