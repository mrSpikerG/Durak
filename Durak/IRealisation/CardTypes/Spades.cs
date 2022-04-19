using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak.CardTypes
{
    class Spades : ICardType
    {
        public bool IsTrumpf { get; set; }
        public Spades()
        {
            IsTrumpf = false;
        }

        public bool getTrumpf()
        {
            return IsTrumpf;
        }
        public ConsoleColor getColor()
        {
            return ConsoleColor.DarkGray;
        }

        public string getType()
        {
            return "♠";
        }
    }
}
