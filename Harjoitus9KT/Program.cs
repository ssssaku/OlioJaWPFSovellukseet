using System;

namespace Harjoitus9
{
    class Radio
    {
        private int _äänenvoimakkuus = 0;
        private int _minÄänenvoimakkuus = 0;
        private int _maxÄänenvoimakkuus = 9;

        private double _Taajuus = 88.0;
        private double _minTaajuus = 88.0;
        private double _maxTaajuus = 107.9;

        public bool isOn { get; private set; }

        public void TurnOn()
        {
            isOn = true;
            Console.WriteLine("Radio on nyt päällä");
            PrintStatus();
        }

        public void TurnOff()
        {
            isOn = false;
            Console.WriteLine("Radio on nyt pois päältä");
        }

        public void NostaÄänenvoimakkuus()
        {
            if (isOn)
            {
                if (_äänenvoimakkuus < _maxÄänenvoimakkuus)
                {
                    _äänenvoimakkuus++;
                }
                Console.WriteLine($"Äänenvoimakkuus on nyt {_äänenvoimakkuus}");
            }
            else
            {
                Console.WriteLine("Radio ei ole päällä");
            }
        }

        public void LaskeÄänenvoimakkuus()
        {
            if (isOn)
            {
                if (_äänenvoimakkuus > _minÄänenvoimakkuus)
                {
                    _äänenvoimakkuus--;
                }
                Console.WriteLine($"Äänenvoimakkuus on nyt {_äänenvoimakkuus}");
            }
            else
            {
                Console.WriteLine("Radio ei ole päällä");
            }
        }

        public void SetTaajuus(double Taajuus)
        {
            if (isOn)
            {
                if (Taajuus >= _minTaajuus && Taajuus <= _maxTaajuus)
                {
                    _Taajuus = Taajuus;
                    Console.WriteLine($"Taajuus on nyt {Taajuus}");
                }
                else
                {
                    Console.WriteLine($"Taajuuden on oltava {_minTaajuus} - {_maxTaajuus} väliltä");
                }
            }
            else
            {
                Console.WriteLine("Radio on pois päältä");
            }
        }

        public void PrintStatus()
        {
            if (isOn)
            {
                Console.WriteLine($"Äänenvoimakkuus: {_äänenvoimakkuus}, Taajuus: {_Taajuus}");
            }
            else
            {
                Console.WriteLine("Radio ei ole päällä");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Radio radio = new Radio();

            while (true)
            {
                Console.WriteLine("Radion toiminnot: on/off, nosta/laske äänenvoimakkuutta, aseta taajuus");
                string input = Console.ReadLine().ToLower();

                if (input == "on")
                {
                    radio.TurnOn();
                }
                else if (input == "off")
                {
                    radio.TurnOff();
                }
                else if (input == "nosta äänenvoimakkuutta")
                {
                    radio.NostaÄänenvoimakkuus();
                }
                else if (input == "laske äänenvoimakkuutta")
                {
                    radio.LaskeÄänenvoimakkuus();
                }
                else if (input.StartsWith("aseta taajuus"))
                {
                    double Taajuus;
                    if (double.TryParse(input.Substring("aseta Taajuus".Length).Trim(), out Taajuus))
                    {
                        radio.SetTaajuus(Taajuus);
                    }
                    else
                    {
                        Console.WriteLine("Virheellinen toiminto");
                    }
                }
                else
                {
                    Console.WriteLine("Virheellinen toiminto");
                }
            }
        }
    }
}
