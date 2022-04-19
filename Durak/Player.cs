using Durak.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak
{
    class Player
    {
        public IAttack Act { get; set; }
        public string Name { get; set; }
        public List<Card> PlayerCards { get; set; }

        //В разработке
        public long WinRate { get; set; }

        public Player(string name)
        {
            Name = name;
        }
        public string showCards()
        {
            PlayerCards.Sort();

            string deck = "Ваша колода:\n";
            for (int i = 0; i < PlayerCards.Count; i++)
            {
                deck +=$"{PlayerCards[i]} ";
            }
            return deck;
        }

        public override string ToString()
        {
            return $"{Name}\n{showCards()}";
        }
    }
}
