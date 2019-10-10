using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C._4
{
    public class Park
    {
        public string _parkName;
        public string _location;
        public string _typeOfFacility;
        public string _typeOfpark;
        public int _fee;
        public int _noOfemployee;
        public int _noOfvisitors;
        public double _annualBudget;

        public Park()
        {

        }

        public Park(int NoOfVisitors, double AnnualBudget, int Fee)
        {
            this._noOfvisitors = NoOfVisitors;
            this._annualBudget = AnnualBudget;
            this._fee = Fee;
        }

        public void cost()
        {
            double TotalCost = _annualBudget / _noOfvisitors;
            Console.WriteLine("total cost is {0}", TotalCost);
        }

        public void revenue()
        {
            double Revenue = _fee * _noOfvisitors;
            Console.WriteLine("total revenue is {0}", Revenue);
        }

        public void SetName(string Parkname, string Location, string TypeOfPark)
        {
            this._parkName = Parkname;
            this._location = Location;
            this._typeOfpark = TypeOfPark;
        }
        public string GetName()
        {
            return this._parkName + "," + this._location + "," + this._typeOfpark;
        }
        public void SetFacility(string Parkname, string Location, string TypeOfFacility)
        {
            this._parkName = Parkname;
            this._location = Location;
            this._typeOfFacility = TypeOfFacility;
        }
        public string GetFacility()
        {
            return this._parkName + "," + this._location + "," + this._typeOfFacility;
        }

        public string Parkname { get; set; }
        public string Facility { get; set; }
        public string ParkType { get; set; }
        public int Visitors { get; set; }
        public int Employee { get; set; }
        public string Locationpark { get; set; }
        public double Budget { get; set; }
        public int Fees { get; set; }

        public override string ToString()
        {
            return $"parkname: {Parkname}" + "," + $"Facility: {Facility}" + "," + $"parktype: {ParkType}" + "," + $"visitors {Visitors}" + "," +
                $"Employee {Employee}" + "," + $"Location: {Locationpark}" + "," + $"Budget:{Budget}" + "," + $"fees is : {Fees}";
                   
        }

    }
}
