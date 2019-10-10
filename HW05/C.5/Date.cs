using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C._5
{
   public class Date
    {
        

       
        public int month
        {
            get;
            set;
        }
        public int day
        {
            get;
            set;
        }
        public int year
        {
            get;
            set;
        }
        public Date(int Month, int Day, int Year)
        {
            month = Month;
            day = Day;
            year = Year;
        }
        public void  Datedisplay()
        {
            Console.WriteLine("Date is : {0},{1},{2}",month.ToString() + "/" + day.ToString() + "/" + year.ToString());
        }
       



    }
}
