using System;

namespace Harjoitus13KT
{
    class Pelaajat
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public int PelaajaNro { get; set; }
    }

    class Joukkue
    {
        public string Nimi { get; set; }
        public string Kotikaupunki { get; set; }
        // private Dictionary<int, Pelaajat>
    }
}