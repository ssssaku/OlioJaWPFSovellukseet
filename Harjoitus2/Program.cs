//Saku Lyytikäinen 
using Harjoitus2;

class Program
{
    public static void Main(string[] args)
    {
        Opiskelija OpiskelijaOlio = new Opiskelija("Oppilas", "1", 100);

        Console.WriteLine(OpiskelijaOlio.TulostaData());
    }
}