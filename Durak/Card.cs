using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak
{
    class Card
    {
        public int NumValue { get; set; }
        public ICardType CardType { get; set; }

        public Card(int numValue, ICardType cardType)
        {
            NumValue = numValue;
            CardType = cardType;
        }

        public override string ToString()
        {

            Console.ForegroundColor = CardType.getColor();
            return $"{NumValue}{CardType.getType()}";
        }


    }
}
