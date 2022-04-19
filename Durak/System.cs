using Durak.CardTypes;
using Durak.IRealisation.Actions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak
{
    class System
    {
        private Player[] Players = new Player[2];

        public static ICardType Trumpf;
        


        private Random rand = new Random();
        private List<Card> AllDeck = new List<Card>();
        public static List<Card> DeckOnTable = new List<Card>();
        public void startGame(Player firstPlayer, Player secondPlayer)
        {
            Players[0] = firstPlayer;
            Players[1] = secondPlayer;



            generateNewDeck();
            fillHand();
            do
            {
                
                Players[0].Act = new Attack();
                Players[0].Act.action(Players[0], Players[1]);

                fillHand();

                for (int i = 0; i < Players.Length; i++)
                {
                    if (Players[0].PlayerCards.Count == 0 || AllDeck.Count == 0)
                    {
                        Console.WriteLine($"Победил {Players[0].Name}");
                        break;
                    }
                }

                Console.Clear();
                Players[1].Act = new Attack();
                Players[1].Act.action(Players[1], Players[0]);

                for (int i = 0; i < Players.Length; i++)
                {
                    if (Players[0].PlayerCards.Count == 0 || AllDeck.Count == 0)
                    {
                        Console.WriteLine($"Победил {Players[0].Name}");
                        break;
                    }
                }

                fillHand();
                Console.Clear();
            } while (true);
        }

        public void fillHand()
        {
            for (int i = 0; i < Players.Length; i++)
            {
                while (Players[i].PlayerCards.Count < 6)
                {
                    Players[i].PlayerCards.Add(getCardFromDeck());
                }

            }
        }

        public void generateNewDeck()
        {
            //пики (♠), червы (♥), бубны (♦) и трефы (♣).
            ICardType[] cardTypes = new ICardType[4] { new Spades(), new Hearts(), new Diamonds(), new Clubs() };

            int trumpf = rand.Next(0, 4);
            cardTypes[trumpf].IsTrumpf = true;
            Trumpf = cardTypes[trumpf];


            //как я знаю в новой упаковке укладывают сначала все номиналы одной масти потом другой потом третьей и т д
            for (int i = 0; i < 4; i++)
            {
                for (int j = 2; j <= 14; j++)
                {
                    AllDeck.Add(new Card(j, cardTypes[i]));
                }
            }
        }
        public Card getCardFromDeck()
        {
            int cardNum = rand.Next(0, AllDeck.Count);
            Card card = AllDeck[cardNum];
            AllDeck.Remove(AllDeck[cardNum]);//
            return card;
        }
        public static void showDeckOnTable()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < DeckOnTable.Count; i++)
            {
                Console.ForegroundColor = DeckOnTable[i].CardType.getColor();
                Console.Write($"{DeckOnTable[i].NumValue.ToString().Replace("11", "J").Replace("12", "Q").Replace("13", "K").Replace("14", "A")}{DeckOnTable[i].CardType.getType()} ");
            }
            Console.Write("\n");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
