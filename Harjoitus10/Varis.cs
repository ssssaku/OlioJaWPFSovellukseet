namespace Harjoitus10
{
    class Varis : Eläin, ICanFly
    {
        public float WingSize { get; set; }
        public Varis(string _name, float _wingSize)
        {
            Name = _name;
            WingSize = _wingSize;
        }

        public void Fly()
        {
            Console.WriteLine("{0} lentää. Siipien koko on {1}", Name, WingSize);
        }
        public override void MakeASound()
        {
            Console.WriteLine("KAKAA KAKAA");   
        }
    }
}
