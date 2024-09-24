using Harjoitus12KT;

class Program
{
    private static void Main(string[] args)
    {
        Kortit KKortit = new Kortit();

        KKortit.kortit();
        KKortit.Tulostus();
        KKortit.Shuffle();
    }
}