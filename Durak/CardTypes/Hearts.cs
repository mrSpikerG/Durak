using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak.CardTypes
{
    class Hearts : ICardType
    {
        public ConsoleColor getColor()
        {
            return ConsoleColor.Red;
        }

        public string getType()
        {
            return "♥";
        }
    }
}
