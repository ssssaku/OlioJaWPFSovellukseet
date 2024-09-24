using System;
using System.Collections.Generic;

namespace Harjoitus6
{
    class Program
    {
        static void Main(string[] args)
        {
            Lintu varis = new Lintu("Varis", 20, "Kakaaw Kakaaw");
            Lintu lintu = new Lintu("Lintu", 60, "Tsirp Tsirp");

            varis.Ääntele();
            lintu.Ääntele();

            Koira mopsi = new Koira("Mopsi", 3);
            Koira mopsi2 = new Koira("Mopsi", -2);

            mopsi.Ääntele();

            Eläin.KuinkaMonta();
            Lintu.KuinkaMonta();
            Koira.KuinkaMonta();
        }
    }
}