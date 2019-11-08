using System;

namespace Ovning3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.Write("Skri in förnamn användare 1: ");
            var fornamn1 = Console.ReadLine();
            Console.Write("Skri in efternamn användare 1: ");
            var efternamn1 = Console.ReadLine();
            Console.Write("Skri in förnamn användare 2: ");
            var fornamn2 = Console.ReadLine();
            Console.Write("Skri in efternamn användare 2: ");
            var efternamn2 = Console.ReadLine();

            Console.WriteLine($"");
            Console.WriteLine($"Det var en gång två snickare.");
            Console.WriteLine($"Det ena var arg och den andra var snäll.");
            Console.WriteLine($"Den arga snickaren hette {fornamn1} {efternamn1}.");
            Console.WriteLine($"Den arga snickaren var alltid väldigt arg när hen jobbade.");
            Console.WriteLine($"Den snälla snickaren hette {fornamn2} {efternamn2}.");
            Console.WriteLine($"Den snälla snickaren var alltid väldigt snäll när hen jobbade.");
            Console.WriteLine($"Dessa snickare var en väldigt bra kombination.");
            Console.WriteLine($"Eftersom den arga snickaren kunde hantera svåra kunder...");
            Console.WriteLine($"...och den snälla snickaren kunde skapa bra affärer tack vare sin tålmodighet.");

        }
    }
}
