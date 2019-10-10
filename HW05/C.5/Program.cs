using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a month");
            int Month1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a day");
            int Day1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a year");
            int Year1 = int.Parse(Console.ReadLine());
            Date date = new Date(Month1,Day1,Year1);
            date.Datedisplay();
            

            
            
            

        }
    }
}
