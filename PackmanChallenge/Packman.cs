using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackmanChallenge
{
    public class Packman
    {
        public int Points { get; set; }
        public byte Lives { get; set; }
        public int BonusFactor { get; set; }

        public Packman()
        {
            Points = 5000;
            Lives = 3;
            BonusFactor = 0;
        }
    }
}
