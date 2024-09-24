// Saku Lyytikäinen
using System;

abstract class Henkilo
{
    public string Nimi { get; set; }
    public string Tyopaikka { get; set; }
    public int Palkka { get; set; }

    public abstract void KerroTiedot();
}

class Tyontekija : Henkilo
{
    public int Viikkotunnit { get; set; }

    public override void KerroTiedot()
    {
        Console.WriteLine("Työntekijän tiedot:");
        Console.WriteLine("Nimi: " + Nimi);
        Console.WriteLine("Työpaikka: " + Tyopaikka);
        Console.WriteLine("Palkka: " + Palkka);
        Console.WriteLine("Viikkotunnit: " + Viikkotunnit);
    }
}

class Pomo : Henkilo
{
    public int Bonus { get; set; }
    public string Auto { get; set; }

    public override void KerroTiedot()
    {
        Console.WriteLine("Pomon tiedot:");
        Console.WriteLine("Nimi: " + Nimi);
        Console.WriteLine("Työpaikka: " + Tyopaikka);
        Console.WriteLine("Palkka: " + Palkka);
        Console.WriteLine("Bonus: " + Bonus);
        Console.WriteLine("Auto: " + Auto);
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Luodaan Tyontekija-instanssi
        Tyontekija tyontekija = new Tyontekija();
        tyontekija.Nimi = "Matti Meikäläinen";
        tyontekija.Tyopaikka = "Firma Oy";
        tyontekija.Palkka = 3000;
        tyontekija.Viikkotunnit = 40;

        // Luodaan Pomo-instanssi
        Pomo pomo = new Pomo();
        pomo.Nimi = "Pekka Pomo";
        pomo.Tyopaikka = "Firma Oy";
        pomo.Palkka = 5000;
        pomo.Bonus = 10000;
        pomo.Auto = "Audi A6";

        // Tulostetaan henkilöiden tiedot
        tyontekija.KerroTiedot();
        pomo.KerroTiedot();
    }
}