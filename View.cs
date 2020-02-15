using System;

namespace BattleShip
{
    class View
    {
        public static void WelcomeToGame()
        {
            Console.WriteLine("Welcome to Battleship game! Set your ships and try to shoot ships of your oponent. Good luck!");
            Console.WriteLine("Press any key to START...");
            Console.ReadLine();
        }
        public static void EmptyLine()
        {
            Console.WriteLine();
        }

        public static void PlayerChange()
        {
            Console.WriteLine("Press any key, to change the player.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Press any key, to start as other player.");
            Console.ReadKey();
        }
    }
}