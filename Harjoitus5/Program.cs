namespace Harjoitus5
{
    public class Program
    {
        static void Main(string[] args)
        {
            double a = 9.0f;
            double b = 5.1f;

            double summa = Laskuri.summa(a, b);
            double erotus = Laskuri.erotus(a, b);
            double kerto = Laskuri.kerto(a, b);
            double jako = Laskuri.jako(a, b);

            Console.WriteLine("Numeroiden {0} ja {1}:", a, b);
            Console.WriteLine("Summa: " + summa);
            Console.WriteLine("Erotus: " + erotus);
            Console.WriteLine("Kertolasku: " + kerto);
            Console.WriteLine("Jakolasku: " + jako);
        }
    }
}