using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durak
{
    class System
    {
        private string FirstPlayer;
        private string SecondPlayer;

        public void startGame(string firstPlayer,string secondPlayer)
        {
            FirstPlayer = firstPlayer;
            SecondPlayer = secondPlayer;
        }

        public List<Card> generateNewPack()
        {
            //пики (♠), червы (♥), бубны (♦) и трефы (♣).
            string cardType = "♠♥♦♣";
            for (int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 0; j++)
                {

                }
            }
        }

    }
}
