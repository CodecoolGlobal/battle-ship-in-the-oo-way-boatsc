using System;

namespace BattleShip
{
    public class Player
    {
        public string PlayerName { get; set; }

        public Player(string playerName)
        {
            PlayerName = playerName;
        }

        public void GetPlayerName()
        {
            Console.Write($"Insert the name of {PlayerName}: ");
            PlayerName = Console.ReadLine();
        }
    }

    
}