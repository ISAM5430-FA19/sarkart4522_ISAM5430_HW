﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c._3
{
    public class Money
    {
       public  Money(double dollar, double cents)
        {
            Cents = cents;
            Dollar = dollar + cents / 100;
        }

        public Money (double dollar)
        {
            Dollar = dollar;
        }

        private double Dollar { get; set; }
        private double Cents { get; set; }

        public double IncrementMoney()
        {
            return Dollar++;
        }

        public double DecrementMoney()
        {
            return Dollar--;
        }

        public string GetMoneyValue()
        {
            double quarters = Dollar * 4;
            double nickels = Dollar * 20;
            double dimes = Dollar * 10;
            double pennies = Dollar * 100;
            return $"no of dollars: {Dollar}\n" + $"no of quarters: {quarters}\n" + $"no of nickels: {nickels}\n" + $"no of pennies: {pennies}";

        }
        public override string ToString()
        {
            return $"${Dollar}";
        }
    }
}
