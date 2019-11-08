using System;

namespace Ovning1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.Write("Skriv in ditt namn: ");
            var namn = Console.ReadLine();
            Console.WriteLine($"Välkommen {namn}!");

        }
    }
}
