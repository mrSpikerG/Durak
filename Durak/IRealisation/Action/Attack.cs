using Durak.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak.IRealisation.Action
{
    class Attack : IAttack
    {
        public void action(Player player1, Player player2)
        {
            Console.WriteLine($"Вы нападаете на игрока {player2.Name}");

            bool isEnd = true;
            string yesOrNo;

            Console.WriteLine(player1);
            Console.Write($"Укажите какой картой вы собираетесь нападать(1-{player1.PlayerCards.Count}): ");
            int chose = int.Parse(Console.ReadLine());

            //Перенос карты на стол
            player1.PlayerCards.Remove(player1.PlayerCards[chose - 1]);
            System.DeckOnTable.Add(player1.PlayerCards[chose - 1]);


            bool canAdd, isNormalAttack;
            do
            {
                isNormalAttack = false;
                Console.Clear();
                System.showDeckOnTable();
                Console.WriteLine(player1);

                //Проверка может ли подкинуть
                #region
                canAdd = false;
                for (int i = 0; i < player1.PlayerCards.Count; i++)
                {
                    if (player1.PlayerCards[i].NumValue == System.DeckOnTable[0].NumValue)
                    {
                        canAdd = true;
                    }
                }
                #endregion

                //Подкидывание карты
                #region
                if (canAdd)
                {
                    Console.WriteLine("Хотите подбросить карту?(Да/Нет)");
                    yesOrNo = Console.ReadLine();
                    if (yesOrNo == "Да")
                    {
                        Console.Write($"Укажите какую карту вы собираетесь подкинуть(1-{player1.PlayerCards.Count}): ");
                        chose = int.Parse(Console.ReadLine());

                        for (int i = 0; i < System.DeckOnTable.Count; i++)
                        {
                            if (player1.PlayerCards[chose - 1] == System.DeckOnTable[i])
                            {
                                isNormalAttack = true;
                            }
                        }

                        if (isNormalAttack)
                        {
                            //Перенос карты на стол
                            player1.PlayerCards.Remove(player1.PlayerCards[chose - 1]);
                            System.DeckOnTable.Add(player1.PlayerCards[chose - 1]);
                        }
                    }
                    else
                    {
                        isEnd = true;
                    }
                }
                else
                {
                    isEnd = true;
                }
                #endregion

            } while (!isEnd);

        }
    }
}
