using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak.CardTypes
{
    class Clubs : ICardType
    {
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
