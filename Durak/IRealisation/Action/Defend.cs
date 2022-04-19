using Durak.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak.IRealisation.Action
{
    class Defend : IAttack
    {
        public void action(Player player1, Player player2)
        {
            Console.WriteLine($"На вас напал {player2.Name}");
            System.showDeckOnTable();


        }
    }
}
