using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorway motorway = new Motorway("Avenue");
            Console.WriteLine("full name of Motorway is: {0}", motorway.Fullname);

            Motorway m1 = new Motorway("Street", true);
            Console.WriteLine("fullname of motorway and wheather toll or not: {0},{1}", m1.Fullname, m1.Toll);

            Motorway m2 = new Motorway("Road", 8);
            
                Console.WriteLine("fullname of motorway and no of lanes is: {0},{1}  ", m2.Fullname, m2.Numberoflanes);
            

            Motorway m3 = new Motorway();
            m3.Direction = "N";
            m3.Lane = 8;
            m3.Surface = "concrete";
            m3.IsToll = false;
            m3.Name = "Lane";
            m3.party = "Govt";
            Console.WriteLine(m3.ToString());
        }
    }
}
