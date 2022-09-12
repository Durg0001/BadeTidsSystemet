using System;

namespace BadeTidsSystemet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("opgave 1");
            Console.WriteLine(" Test Kreds Klassen");
            Kreds k1 = new Kreds("Kreds", "Roskilde","maglegårdsvej 2", 10);

            Kreds k2 = new Kreds("Kreds", "København", "Rådhuspladsen 2", 15);

            Console.WriteLine(k1);
            Console.WriteLine(k2);
            Console.WriteLine();

            Console.WriteLine("opgave 2");

            Badetidsperiode b1 = new Badetidsperiode();
            b1.Type = "morgendukkert";
            b1.UgeDag = DayOfWeek.Sunday;
            b1.StartTidspunkt = new DateTime().AddHours(6).AddMinutes(30);
            b1.SlutTidspunkt = new DateTime().AddHours(8).AddMinutes(15);

            Badetidsperiode b2 = new Badetidsperiode();
            b2.Type = "Aftensvaler";
            b2.UgeDag = DayOfWeek.Monday;
            b2.StartTidspunkt = new DateTime().AddHours(12).AddMinutes(30);
            b2.SlutTidspunkt = new DateTime().AddHours(21).AddMinutes(15);

            
            Console.WriteLine(b1);
            Console.WriteLine(b2);

        }
    }
}
