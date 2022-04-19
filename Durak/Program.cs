using System;

namespace Durak
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] playernames = new string[2];
            Console.Write("Имя первого игрока: ");
            playernames[0] = Console.ReadLine();

            Console.Write("Имя второго игрока: ");
            playernames[1] = Console.ReadLine();

            System sys = new System();
            sys.startGame(new Player(playernames[0]), new Player(playernames[1]));
        }
    }
}
