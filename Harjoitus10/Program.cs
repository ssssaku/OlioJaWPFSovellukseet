using Harjoitus10;

internal class Program
{
    private static void Main(string[] args)
    {
        Varis varis = new Varis("Varis", 90);

        varis.MakeASound();
        varis.Fly();

        Kala ahven = new Kala("Ahven", 50, "Blörps");

        ahven.MakeASound();
        ahven.Swim();

        Sorsa sorsa = new Sorsa("Sorsa", 90, 10);

        sorsa.MakeASound();
        sorsa.Fly();
        sorsa.MakeASound();
        sorsa.Swim();
    }
}