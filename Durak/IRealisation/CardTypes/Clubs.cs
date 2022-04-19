using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak.CardTypes
{
    class Clubs : ICardType
    {

        public bool IsTrumpf { get; set; }
        public Clubs()
        {
            IsTrumpf = false;
        }

        public bool getTrumpf()
        {
            return IsTrumpf;
        }

        public ConsoleColor getColor()
        {
            return ConsoleColor.Black;
        }

        public string getType()
        {
            return "♣";
        }
    }
}
