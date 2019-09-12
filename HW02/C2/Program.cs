using static System.Console;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C2
{
    class Program
    {
        static void Main(string[] args)
        {   //c.2 question 8  1,2,4,8,16,32,64

            //int i =1
            int i = 1;
            // condition i<=100
            while (i <= 100)
            {
                //print i
                WriteLine(i);
                // i = i multiply by 2 +0
                i = i *2 + 0;
               
            } 
            //c.2 question 9 100,50,25,...
            // int j = 100
            int j = 100;
            // condition j >0
            while (j >0)
            {
                //print j
                Write(j + " ");
                // j divide by 2 +0
                j = j / 2 + 0;
               
                
            }
            //c.2 question10  100,50,25,12.5,6.25.....
            // k=0
            decimal k = 100;
            //k>1
            while (k > 1)
            {
                //print k
                Write(k + " ");
                // k/2 +0
                k =( k / 2 + 0);
            }
        }
    }
}
