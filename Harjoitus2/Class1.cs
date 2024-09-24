namespace Harjoitus2
{
    class Opiskelija
    {
        public string Nimi { get; set; }
        public string OpiskelijaID { get; set; }
        public int Opintopisteet { get; set; }


        public Opiskelija(string _nimi, string _opiskelijaid, int _opintopisteet)
        {
            Nimi = _nimi;
            OpiskelijaID = _opiskelijaid;
            Opintopisteet = _opintopisteet;
        }

        public string TulostaData()
        {
            string OppilaanTiedot = "Nimi: " + Nimi + " Nopeus: " + OpiskelijaID + " Renkaat: " + Opintopisteet.ToString();

            return OppilaanTiedot;
        }
    }
}