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

            // Гениальное решение дабы избежать лишней запары с знатью
            return $"{NumValue.ToString().Replace("11", "J").Replace("12", "Q").Replace("13", "K").Replace("14", "A")}{CardType.getType()}";
        }
        public override bool Equals(object obj)
        {
            if (obj is Card)
            {
                Card tmp = obj as Card;
                //Если одинаковый тип
                if (this.NumValue > tmp.NumValue && this.CardType.getType() == tmp.CardType.getType())
                {
                    return true;
                }
                //козырь
                if (this.CardType.IsTrumpf && !tmp.CardType.IsTrumpf)
                {
                    return true;
                }
                if (this.CardType.IsTrumpf && tmp.CardType.IsTrumpf && this.NumValue > tmp.NumValue)
                {
                    return true;
                }
                return false;
            }
            return false;
        }

    }
}
