using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak
{
    interface ICardType
    {
        public ConsoleColor getColor();
        public string getType();
    }
}
