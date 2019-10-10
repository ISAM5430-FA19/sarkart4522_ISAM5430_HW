using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Money money = new Money(1.5,25);
            Money money1 = new Money(1.5);
            money.DecrementMoney();
            money1.IncrementMoney();
            Console.WriteLine(money.GetMoneyValue());
            Console.WriteLine(money1.GetMoneyValue());
            Console.WriteLine(money);
            Console.WriteLine(money1);

            
        }
    }
}
