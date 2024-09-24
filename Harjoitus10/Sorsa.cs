using System.Xml.Linq;

namespace Harjoitus10
{
    class Sorsa : Eläin, ICanFly
    {
        public int SwimSpeed { get; set; }
        public float WingSize { get; set; }

        public Sorsa(string _name, float wingSize, int _speed)
        {
            Name = _name;
            WingSize = wingSize;
            SwimSpeed = _speed;
        }

        public void Fly()
        {
            Console.WriteLine("{0} lentää. Siipien koko on {1}", Name, WingSize);
        }

        public override void MakeASound()
        {
            Console.WriteLine("kvaak");
        }

        public void Swim()
        {
            Console.WriteLine("{0} ui nopeudella {1}", Name, SwimSpeed);
        }
    }
}
