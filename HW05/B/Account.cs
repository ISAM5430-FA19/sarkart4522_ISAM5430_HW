using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B
{
   public  class Account
    {
        private string _name;
        public readonly bool Is_Active;
        private double money;
        private double balance;
        private double _withdraw;
        public bool IsActive
        {
            get; set;
        }
        //java, c#, c++

        //public Account(string name)
        //{

        //    //  if(!string.IsNullOrEmpty(name))
        //    _name = name;
        //    Is_Active = true;
        //    IsActive = true;
        //}

        //public Account(String name, bool isActive)
        //{
        //    Name = name;
        //    IsActive = Is_Active = isActive;

        //}

        public double Balance
        {
            set
            {
                balance = value;
            }
        }

        public double moneywithdraw
        {
            set
            {
                money = value;

                if (money > balance)
                {
                    throw new Exception("withdrawl amount exceed the balance");
                }
                else
                {

                    _withdraw = balance - money;
                }
            }

            get
            {
                return _withdraw;
            }
        }

        public override string ToString()
        {
            //object
            //return GetType().FullName
            //return base.ToString();
            if (IsActive)
            {
                return $"Active account {Name}";
            }
            else
            {
                return $"Inactive Account {Name}";
            }
        }
        //public string GetName()
        //{
        //    return _name;
        //}

        //public void SetName(string name)
        //{
        //    _name = name;
        //}

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value != null && value != "")
                    _name = value;
            }
        }
    }
}
