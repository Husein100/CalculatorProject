namespace Lommeregner
{
    internal class Program
    {
        static void Main(string[] args)
       {

            //Når du opretter et objekt af en klasse, reserveres der hukommelse til dette objekt,
            //og du får adgang til alle metoder og egenskaber, der er defineret i klassen.
            //Derfor opretter man en instans af en klasse, når man ønsker at udføre en bestemt
            //handling eller få adgang til data i overensstemmelse med den pågældende klasse.
            //
            // Opretter et objekt af klassen Calculator, en ny instans af min Calculator-klasse
            // Mit objekt, som jeg skal bruge her skal hedde lommeregner
            Calculator lommeregner = new Calculator();

            //variabel til opsamling af resultater
            double resultat = 0;

            Console.WriteLine("Hej, jeg er din super smarte lommerregner, som kan hjælpe dig med dine regneopgaver.");
            Console.WriteLine("Med mig kan du lave matematikopgaver hurtigere og mere korrekt.");
            Console.WriteLine();
            Console.WriteLine("-Du kan pluse to tal sammen ved at bruge +");
            Console.WriteLine();
            Console.WriteLine("-Du kan minuse to tal sammen ved at bruge -");
            Console.WriteLine();
            Console.WriteLine("-Du kan gange to tal sammen ved at bruge *");
            Console.WriteLine();
            Console.WriteLine("-Du kan dividere to tal sammen ved at bruge /");
            Console.WriteLine();
            Console.WriteLine("Vælg hvilken regneopgavetype du vil lave, skrive a,b,c eller d");
            Console.WriteLine();
            Console.WriteLine("-a for plus +");
            Console.WriteLine();
            Console.WriteLine("-b for minis -");
            Console.WriteLine();
            Console.WriteLine("-c for dividere *");
            Console.WriteLine();
            Console.WriteLine("-d for gange /");
            Console.WriteLine();
            bool erON = true;

            while (erON)
            {
                string reneoperationvalg = Console.ReadLine();

                switch (reneoperationvalg)
                {

                    case "a":
                        //Bruger bliver bedt om indput
                        //Indput bliver konverteret til int for at kunne blive bearbejdet i metoden,
                        //opretter også int variabler, som vi gemmer brugerindput i, så de kan komme i metoden
                        Console.WriteLine();
                        Console.Write("Indast første nummer:");
                        // Kalder metoden Add med to tal som argumenter, de to tal er brugerindput
                        //Metoden giver et resultat som vi printer ud
                        int x = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Indast andet nummer:");
                        int y = int.Parse(Console.ReadLine());
                        resultat = lommeregner.Add(x, y);
                        Console.WriteLine();
                        Console.WriteLine("Dit resultat er:" + resultat);
                        break;

                    case "b":
                        Console.Write("Indast første nummer:");
                        // Kalder metoden Substract med to tal som argumenter
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Indast andet nummer:");
                        y = int.Parse(Console.ReadLine());
                        resultat = lommeregner.Substract(x, y);
                        Console.WriteLine();
                        Console.WriteLine("Dit resultat er:" + resultat);
                        break;

                    case "c":
                        Console.Write("Indast første nummer:");
                        // Kalder metoden Divide med to tal som argumenter
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Indast andet nummer:");
                        y = int.Parse(Console.ReadLine());
                        resultat = lommeregner.Divide(x, y);
                        Console.WriteLine();
                        Console.WriteLine("Dit resultat er:" + resultat);
                        break;


                    case "d":
                        Console.Write("Indast første nummer:");
                        // Kalder metoden Multiplay med to tal som argumenter
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("Indast andet nummer:");
                        y = int.Parse(Console.ReadLine());
                        resultat = lommeregner.Multiply(x, y);
                        Console.WriteLine();
                        Console.WriteLine("Dit resultat er:" + resultat);
                        break;

                    default:
                        Console.WriteLine("Det valg som du har angivet eksisterer ikke. Valg igen.");
                        break;
                }

            }
            Console.ReadLine();









        }
    }
}
