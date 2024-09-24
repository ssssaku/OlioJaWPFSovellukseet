using System;
using System.Collections.Generic;

namespace Harjoitus4KT
{
    class Albumi
    {
        public string Nimi { get; set; }
        public string Esittaja { get; set; }
        public int Julkaisuvuosi { get; set; }
        public List<Kappale> Kappaleet { get; set; }

        public Albumi(string nimi, string esittaja, int julkaisuvuosi)
        {
            Nimi = nimi;
            Esittaja = esittaja;
            Julkaisuvuosi = julkaisuvuosi;
            Kappaleet = new List<Kappale>();
        }

        public void LisaaKappale(Kappale kappale)
        {
            Kappaleet.Add(kappale);
        }

        public void TulostaAlbumi()
        {
            Console.WriteLine("Albumi: {0} ({1}), julkaistu {2}", Nimi, Esittaja, Julkaisuvuosi);
            Console.WriteLine("Kappaleet:");

            foreach (Kappale kappale in Kappaleet)
            {
                Console.WriteLine("- {0}", kappale.ToString());
            }
        }
    }

    class Kappale
    {
        public string Nimi { get; set; }
        public string Esittaja { get; set; }
        public TimeSpan Kesto { get; set; }

        public Kappale(string nimi, string esittaja, TimeSpan kesto)
        {
            Nimi = nimi;
            Esittaja = esittaja;
            Kesto = kesto;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1}) - {2:mm\\:ss}", Nimi, Esittaja, Kesto);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Albumi albumi = new Albumi("Rumours", "Fleetwood Mac", 1977);

            albumi.LisaaKappale(new Kappale("Second Hand News", "Fleetwood Mac", new TimeSpan(0, 2, 43)));
            albumi.LisaaKappale(new Kappale("Dreams", "Fleetwood Mac", new TimeSpan(0, 4, 14)));
            albumi.LisaaKappale(new Kappale("Never Going Back Again", "Fleetwood Mac", new TimeSpan(0, 2, 15)));
            albumi.LisaaKappale(new Kappale("Don't Stop", "Fleetwood Mac", new TimeSpan(0, 3, 11)));
            albumi.LisaaKappale(new Kappale("Go Your Own Way", "Fleetwood Mac", new TimeSpan(0, 3, 38)));
            albumi.LisaaKappale(new Kappale("Songbird", "Christine McVie", new TimeSpan(0, 3, 20)));

            albumi.TulostaAlbumi();

            Console.ReadKey();
        }
    }
}