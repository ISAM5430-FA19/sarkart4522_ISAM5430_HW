using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
    class Program
    {
        static void Main(string[] args)
        {
            //constructor
            //the default constructor that is parameterless
            Account account = new Account();
            // //constructor forces you initialize the required class
            //// account.SetName("Tameka");
            //// Console.WriteLine("The name is " + account.GetName());
            // account.Name = "Tam";
            // account.IsActive = true;
            // Console.WriteLine("Is the account active?" +
            //     account.IsActive);

            //// Console.WriteLine("The name 2 is" + account.Name);
            // //Fully Qualified type names, which include namesspace "dot" type name
            // Console.WriteLine(account);

            Console.WriteLine("enter the balance");
            double Balance1 = double.Parse(Console.ReadLine());
            account.Balance = Balance1;

            Console.WriteLine("enter money to withdraw");
            double money = double.Parse(Console.ReadLine());
            account.moneywithdraw = money;


            Console.WriteLine("money withdraw : {0}", account.moneywithdraw);

        }
    }
}
