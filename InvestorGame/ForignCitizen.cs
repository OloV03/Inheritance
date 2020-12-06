using System;
using System.Collections.Generic;
using System.Text;

namespace Primer
{
    sealed class ForignCitizen : Citizen
    {
        private string foreignPassport; // Номер загран паспрорта
        private DateTime visaOpen;      // Дата открытия визы
        private DateTime visaClose;     // Дата закрытия визы

        public ForignCitizen(string foreignPassport, DateTime visaOpen, DateTime viseClose, 
                             string _name, string _surname, bool _sex, string _pass, string _address) 
                             : base (_name, _surname, _sex, _pass, _address)
        {
            this.foreignPassport = foreignPassport;
            this.visaOpen = visaOpen;
            this.visaClose = viseClose;
        }

        public string ForeignPassport
        {
            get { return foreignPassport; }
            set { foreignPassport = value; }

        }
        public DateTime VisaOpen
        {
            get { return visaOpen; }
            set { visaOpen = value; }
        }
        public DateTime VisaClose
        {
            get { return visaClose; }
            set { visaClose = value; }
        }

        public void Print()
        {
            base.Print();
            Console.WriteLine($"ForeignPassport: {foreignPassport}");
            Console.WriteLine($"Visa open date: {visaOpen}");
            Console.WriteLine($"Visa close date: {visaClose}");
        }
    }
}
