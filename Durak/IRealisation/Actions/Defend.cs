using Durak.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak.IRealisation.Actions
{
    class Defend : IAttack
    {
        Action<Player>[] act;
        public Defend()
        {
            act = new Action<Player>[2];
            act[0] = claim;
            act[1] = defend;
        }

        public void action(Player player1, Player player2)
        {
            Console.WriteLine($"На вас напал {player2.Name}");
            System.showDeckOnTable();

            int chose;
            do
            {
                Console.WriteLine("1 - Загребсти карты ");
                Console.WriteLine("2 - Побить карту ");
                Console.Write("Ваш выбор: ");
                chose = int.Parse(Console.ReadLine());
                if (chose == 1 || chose == 2)
                {
                    break;
                }

            } while (true);
            act[chose - 1]?.Invoke(player1);
            System.DeckOnTable.Clear();
        }

        private void claim(Player player)
        {
            for (int i = 0; i < System.DeckOnTable.Count; i++)
            {
                player.PlayerCards.Add(System.DeckOnTable[i]);
                System.DeckOnTable.Remove(System.DeckOnTable[i]);
            }
        }
        private void defend(Player player)
        {
            Console.Clear();

            //гайд как отбиваться
            #region
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\tКраткое обучение как бится");
            Console.WriteLine("4513");
            Console.WriteLine("Вышеупомянутое значение означает что \nпервая карта на доске будет побита 4 вашей картой, \nвторая карта на доске - вашей пятой" +
                "\nтретья карта на доске будет побита 1 вашей картой, \nчетвертая карта на доске будет побита 3 вашей картой\n");
            Console.WriteLine("0 - чтобы загребсти карты");
            Console.ForegroundColor = ConsoleColor.White;
            #endregion

            System.showDeckOnTable();
            player.showCards();
            bool isNormal;
            string chose;
            int isNormalCount;
            do
            {
                isNormal = false;
                isNormalCount = 0;
                Console.Write("Введите какими картами будете бится: ");
                chose = Console.ReadLine();
                if (chose == "0")
                {
                    claim(player);
                    break;
                }
                if (chose.Length != System.DeckOnTable.Count)
                {
                    for (int i = 0; i < System.DeckOnTable.Count; i++)
                    {
                        if (player.PlayerCards[Convert.ToInt32(chose[i])].Equals(System.DeckOnTable[i]))
                        {
                            isNormalCount++;
                        }
                    }
                }
                if (isNormalCount == System.DeckOnTable.Count - 1)
                {
                    for (int i = 0; i < System.DeckOnTable.Count; i++)


                    isNormal = true;
                }

            } while (!isNormal);

        }
    }
}
