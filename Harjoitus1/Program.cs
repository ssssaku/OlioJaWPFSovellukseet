//Saku Lyytikäinen 
using Harjoitus1;

class Program
{   
    public static void Main(string[] args)
    {
        Ajoneuvo AjoneuvoOlio = new Ajoneuvo("Ford", 80, 4);

        Console.WriteLine(AjoneuvoOlio.TulostaData());
    }
}