namespace Harjoitus6
{
    class Koira : Eläin
    {

        public override int MaxIkä { get => maxIkä; set => maxIkä = value; }

        private static int instanssit = 0;

        public Koira(string _nimi, int _ikä)
        {
            MaxIkä = 25;

            Nimi = _nimi;
            Ikä = _ikä;

            instanssit++;

            Console.WriteLine("Uusi Koira luotu, koiran nimi: " + Nimi);
        }

        public static new void KuinkaMonta()
        {
            Console.WriteLine("Koiria on yhteensä luotu " + instanssit + " kappaletta");
        }

        public override void Ääntele()
        {
            Console.WriteLine(Nimi + " sanoo: Woof woof");
        }
    }
}