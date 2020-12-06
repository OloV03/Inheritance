using System;
using System.Collections.Generic;
using System.Text;

namespace Primer
{
    class Citizen : Human
    {
        protected string password;
        protected string address;
        public Citizen(string _name, string _surname, bool _sex, 
                       string _pass, string _address) : base (_name, _surname, _sex)
        {
            password = _pass;
            address = _address;
        }

        public string Pass
        {
            get { return password; }
            set { password = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public void Print()
        {
            base.Print();
            Console.WriteLine($"Password: {password}");
            Console.WriteLine($"Address: {address}");
        }
    }
}
