namespace Harjoitus7
{
    class Program
    {
        static void Main(string[] args)
        {
            Hissi hissi = new Hissi(1, 6);

            int uusiKerros;
            string lukija;

            Console.WriteLine("Tervetuloa hissiin. Poistu hissistä kirjoittamalla 'poistu'");

            while (true)
            {
                Console.WriteLine();
                Console.Write("Anna uusi kerros ({0}) < ", hissi.PalautaMinMax());

                lukija = Console.ReadLine();

                if (lukija.Equals("poistu"))
                    break;

                bool tarkistus = int.TryParse(lukija, out uusiKerros);

                if (tarkistus)
                {
                    hissi.Kerros = uusiKerros;
                }
                else
                {
                    Error.KirjoitaError("0003f; Virheellinen syöttö! Kokeile uudestaan.");
                }

                hissi.TulostaNykyinenKerros();
            }

            Console.WriteLine("Poistuttiin hissistä");
        }
    }
}