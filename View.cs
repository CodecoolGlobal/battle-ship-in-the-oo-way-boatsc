using System;

namespace BattleShip
{
    class View
    {
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