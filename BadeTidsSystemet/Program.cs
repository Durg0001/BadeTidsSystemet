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

        }
    }
}
