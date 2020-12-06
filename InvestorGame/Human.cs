using System;
using System.Collections.Generic;
using System.Text;

namespace Primer
{
    class Human
    {
        protected string name;   
        protected string surname;
        protected bool sex; //true - girl, false - boy

        public Human(string name, string surname, bool sex)
        {
            this.name = name;
            this.surname = surname;
            this.sex = sex;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public bool Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public void Print()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Surname: {surname}");
            if (sex) Console.WriteLine("Sex: Female");
            else Console.WriteLine("Sex: Male");
        }
    }
}
