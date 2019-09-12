using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C3
{
    class Program
    {
        static void Main(string[] args)
        {
            // c.3 question 11.

            // initializing i =1
            int i = 1;
            // factorial is 1 
            int fact = 1;
            // condition is i <=6
            while (i <= 6)
            {
                // fact becomes fact*i
                fact = fact * i;
                //print fact
                Console.Write(fact + " ");
                // increment i by 1
                i = i + 1;
            }
            // c.3 question 12
            // a =0 
            int a = 0;
            // b =1
            int b = 1;
            //c =0
            int c = 0;
            // j=1
            int j = 1;
            // taking  input
            Console.WriteLine("enter no of times ");
            int n = int.Parse(Console.ReadLine());
            // condition j<n
            while(j < n)
            {
                // print a
                Console.Write(a + " ");
                //a+b goes to c
                c = a + b;
                // value of b to a
                a = b;
                // value of c to b
                b = c;
                // increment j by 1
                j = j + 1;
            }


        }
    }
}
