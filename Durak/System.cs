﻿using Durak.CardTypes;
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

        private ICardType Trumpf;



        private Random rand = new Random();
        private List<Card> AllDeck = new List<Card>();
        public static List<Card> DeckOnTable = new List<Card>();
        public void startGame(Player firstPlayer, Player secondPlayer)
        {
            Players[0] = firstPlayer;
            Players[1] = secondPlayer;



            generateNewDeck();



            bool isGameEnd = false;
            do
            {

                int chose;
                Console.WriteLine("1 - Выбрать карту чтобы побится");
                Console.WriteLine("2 - Загребсти карты");
                Console.WriteLine("3 - Сдаться");
                do
                {
                    Console.Write("Ваш выбор: ");
                    chose = int.Parse(Console.ReadLine());
                } while (chose < 1 || chose > 3);


            } while (!isGameEnd);
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
            for(int i = 0; i < DeckOnTable.Count; i++)
            {
                Console.Write($"{DeckOnTable[i]} ");
            }
        }
    }
}
