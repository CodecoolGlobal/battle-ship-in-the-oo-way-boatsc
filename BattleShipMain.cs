using System;
using System.Collections.Generic;

namespace BattleShip
{
    public class BattleShipMain
    {  
        static void Main(string[] args)
        {
            bool allSunk = false;
            Ocean boardPlayerOne = new Ocean();
            Ocean guessingBoardPlayerOne = new Ocean();
            Ocean boardPlayerTwo = new Ocean();
            Ocean guessingBoardPlayerTwo = new Ocean();

            while (!allSunk)
            {
                boardPlayerOne.PrintGame();
                guessingBoardPlayerOne.PrintGame();
                // here will be setting the ships of Player One, only in the first round
                Coordinates coordinates = boardPlayerOne.GetCoordinates();
                boardPlayerOne.AddShip(coordinates, ShipDirection.Horizontal, SquareType.Battleship);
                boardPlayerOne.PrintGame();
                Console.ReadLine();

                // here will be the play of Player One (choosing coordinates), if ships are already set
                // Console.WriteLine("Press any key, as you finished the round.");
                // Console.ReadKey();
                // Console.Clear();
                // Console.WriteLine("Press any key, to start the round.");
                // Console.ReadKey();
                // boardPlayerTwo.PrintGame();
                // guessingBoardPlayerTwo.PrintGame();
                // here will be setting the ships of Player Two, only in the first round
                // here will be the play of Player Two (choosing coordinates), if ships are already set
            }

        }
    }
}