using System;
using System.Collections.Generic;

namespace BattleShip
{
    public class BattleShipMain
    {  
        static void Main(string[] args)
        {
            bool allSunk = false;
            Ocean boardOnePlayerOne = new Ocean();
            Ocean boardOnePlayerTwo = new Ocean();
            Ocean boardTwoPlayerOne = new Ocean();
            Ocean boardTwoPlayerTwo = new Ocean();

            while (!allSunk)
            {
                boardOnePlayerOne.PrintGame();
                boardOnePlayerTwo.PrintGame();
                // here will be setting the ships of Player One, only in the first round
                // here will be the play of Player One (choosing coordinates), if ships are already set
                Console.WriteLine("Press any key, as you finished the round.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Press any key, to start the round.");
                Console.ReadKey();
                boardTwoPlayerOne.PrintGame();
                boardTwoPlayerTwo.PrintGame();
                // here will be setting the ships of Player Two, only in the first round
                // here will be the play of Player Two (choosing coordinates), if ships are already set
            }

        }
    }
}