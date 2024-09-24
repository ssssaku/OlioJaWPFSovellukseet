using Harjoitus3KT;

internal class Program
{
    public static void Main(string[] args)
    {
        Kiuas KiuasOlio = new Kiuas(false, 0, 0);

        Console.WriteLine("Kommenot: Virta, Lämpötila, Kosteus");
        for (; ; )
        {
            string syöte = Console.ReadLine();
            if(syöte.ToLower() == "virta")
            {
                if (!KiuasOlio.päällä)
                {
                    KiuasOlio.päällä = true;
                    Console.WriteLine("kiuas on päällä...");
                }
                else if (KiuasOlio.päällä)
                {
                    KiuasOlio.päällä = false;
                    Console.WriteLine("kiuas on pois päältä...");
                }
            }
            if (syöte.ToLower() == "lämpötila")
            {
                Console.WriteLine("anna lämpötila");
                KiuasOlio.lampotila = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Lämpötila on nyt " + KiuasOlio.lampotila + " celciusta");
            }

            if (syöte.ToLower() == "kosteus")
            {
                Console.WriteLine("anna kosteus");
                KiuasOlio.kosteus = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Kosteus on nyt " + KiuasOlio.kosteus);
            }
        }
    }
}
