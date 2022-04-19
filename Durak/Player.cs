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
            PlayerCards = new List<Card>();
        }

        public void showCards()
        {
            Console.Write($"{Name}:\t\tКозырь: ");

            Console.ForegroundColor = System.Trumpf.getColor();
            Console.Write($"{System.Trumpf.getType()}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();


            for (int i = 0; i < PlayerCards.Count; i++)
            {
                Console.ForegroundColor = PlayerCards[i].CardType.getColor();
                Console.Write($"{PlayerCards[i].NumValue.ToString().Replace("11", "J").Replace("12", "Q").Replace("13", "K").Replace("14", "A")}{PlayerCards[i].CardType.getType()} ");
            }
            Console.Write("\n");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private string showCardsString()
        {
            //PlayerCards.Sort();

            string deck = "Ваша колода:\n";
            for (int i = 0; i < PlayerCards.Count; i++)
            {
                deck += $"{PlayerCards[i]} ";
            }
            return deck;
        }

        public override string ToString()
        {
            return $"{Name}\n{showCardsString()}";
        }
    }
}
