using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackmanChallenge
{
    public class Packman
    {
        public int Points { get; set; } = 5000;
        public byte Lives { get; set; } = 3;
        public bool PowerPellet { get; set; } = false;
        public int BonusFactor { get; set; } = 0;
        public int LivesGained { get; set; }
        public bool CanGainLife { get; set; }
    }
}
