using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus3KT
{
    public class Kiuas
    {
        public bool päällä;
        public float lampotila;
        public float kosteus;

        public Kiuas(bool _päällä, int _lampotila, int _kosteus)
        {
            päällä = _päällä;
            lampotila = _lampotila;
            kosteus = _kosteus;
        }
    }
}