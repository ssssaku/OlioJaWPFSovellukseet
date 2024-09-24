﻿namespace Harjoitus11
{
    class Opiskelija
    {
        private string etunimi;
        private string sukunimi;
        private string opiskelijaID;
        public string Etunimi { get => etunimi; }
        public string Sukunimi { get => sukunimi; }
        public string OpiskelijaID { get => opiskelijaID; }

        public Opiskelija(string etunimi, string sukunimi, string opiskelijaID)
        {
            this.etunimi = etunimi;
            this.sukunimi = sukunimi;
            this.opiskelijaID = opiskelijaID;
        }


        public string HaeData()
        {
            return Etunimi + " " + Sukunimi + ". ID: " + OpiskelijaID;
        }
    }
}