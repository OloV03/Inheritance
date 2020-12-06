using System;

namespace Primer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Какие-то человеки";

            Human hm = new Human("John", "Ivanov", false);
            hm.Print();

            Citizen ct = new Citizen("Arkady", "Petro", false, "666DuraK666", "Kursk");
            Console.WriteLine("-------------------");
            ct.Print();

            ForignCitizen frc = new ForignCitizen("#$^%^&@OOHHH@$%@*&^@", Convert.ToDateTime("22.01.2010"), Convert.ToDateTime("22.01.2100"),"Anna", "Malavka", true, "6809334BC", "London");
            Console.WriteLine("-------------------");
            frc.Print();

            Console.ReadKey();
        }

    }
}
