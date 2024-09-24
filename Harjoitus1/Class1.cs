namespace Harjoitus1
{
    class Ajoneuvo
    {
        public string Nimi { get; set; }
        public int Nopeus { get; set; }
        public int Renkaat { get; set; }
        

        public Ajoneuvo(string _nimi, int _nopeus, int _renkaat)
        {
            Nimi = _nimi;
            Nopeus = _nopeus;
            Renkaat = _renkaat;
        }
        
        public string TulostaData()
        {
            string AutonTiedot = "Nimi: " + Nimi + " Nopeus: " + Nopeus.ToString() + " Renkaat: " + Renkaat.ToString();

            return AutonTiedot;
        }   
    }
}