using System;

namespace Ovning2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.Write("Skriv in ditt förnamn: ");
            var fornamn = Console.ReadLine();
            Console.Write("Skriv in ditt efternamn: ");
            var efternamn = Console.ReadLine();
            Console.WriteLine($"Välkommen {fornamn} {efternamn}!");

        }
    }
}
