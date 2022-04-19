using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak.CardTypes
{
    class Diamonds : ICardType
    {
        public bool IsTrumpf { get; set; }
        public Diamonds()
        {
            IsTrumpf = false;
        }

        public bool getTrumpf()
        {
            return IsTrumpf;
        }
        public ConsoleColor getColor()
        {
            return ConsoleColor.Red;
        }

        public string getType()
        {
            return "♦";
        }
    }
}
