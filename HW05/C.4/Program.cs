using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Park p1 = new Park();
            p1.SetName("palms", "clearlake", "local");
            Console.WriteLine("the name of park, location and type of park is : {0}", p1.GetName());

            Park p2 = new Park();
            p2.SetFacility("palms", "clearlake", "free");
            Console.WriteLine("the name of park, location and type of facility is : {0}", p2.GetFacility());

            Park park = new Park(50, 1500, 10);
            park.cost();
            park.revenue();

            Park p3 = new Park();
            p3.Parkname = "lake";
            p3.ParkType = "national";
            p3.Fees = 20;
            p3.Employee = 50;
            p3.Visitors = 200;
            p3.Locationpark = "houston";
            p3.Budget = 10000;

            Console.WriteLine( p3.ToString());

        }
    }
}
