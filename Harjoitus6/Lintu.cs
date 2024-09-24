namespace Harjoitus6
{
    class Lintu : Eläin
    {
        private string LinnunÄäni { get; set; }

        public override int MaxIkä { get => maxIkä; set => maxIkä = value; }

        private static int instanssit = 0;

        public Lintu(string _nimi, int _ikä, string _ääni)
        {
            MaxIkä = 50;

            Nimi = _nimi;
            Ikä = _ikä;
            LinnunÄäni = _ääni;

            instanssit++;

            Console.WriteLine("Uusi Lintu luotu, linnun nimi: " + Nimi);
        }

        public static new void KuinkaMonta()
        {
            Console.WriteLine("Lintuja on yhteensä luotu " + instanssit + " kappaletta");
        }

        public override void Ääntele()
        {
            Console.WriteLine(Nimi + " sanoo: " + LinnunÄäni);
        }
    }
}