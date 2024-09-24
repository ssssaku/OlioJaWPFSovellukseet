namespace Harjoitus6
{
    abstract class Eläin
    {
        public int maxIkä;
        public abstract int MaxIkä { get; set; }

        private string nimi;
        public string Nimi { get; set; }


        private int ikä;
        public virtual int Ikä
        {
            get { return ikä; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Annettu ikä on pienempi kuin 0, Eläimen ikä asetettu 0");
                    value = 0;
                }
                else if (value > MaxIkä)
                {
                    Console.WriteLine("Annettu ikä ylittää {0}. Eläimen iäksi asetettu {1}", MaxIkä, MaxIkä - 1);
                    value = MaxIkä - 1;
                }

                ikä = value;
            }
        }

        private static int instanssit = 0;

        public Eläin()
        {
            instanssit++;
        }

        public static void KuinkaMonta()
        {
            Console.WriteLine("Eläimiä on yhteensä luotu " + instanssit + " kappaletta");
        }
        public abstract void Ääntele();
    }
}