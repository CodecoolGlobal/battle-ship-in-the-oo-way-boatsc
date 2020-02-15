using System;
using System.Collections.Generic;

namespace BattleShip
{
    public class BattleShipMain
    {  
        static void Main(string[] args)
        {
            bool allSunk = false;

            Player playerOne = new Player("Player 1");
            Player playerTwo = new Player("Player 2");
            
            WelcomeToGame();
            
            playerOne.GetPlayerName();
            playerTwo.GetPlayerName();

            Ocean boardPlayerOne = new Ocean("Board", playerOne.PlayerName);
            Ocean guessingBoardPlayerOne = new Ocean("Shooting Board", playerOne.PlayerName);
            Ocean boardPlayerTwo = new Ocean("Board", playerTwo.PlayerName);
            Ocean guessingBoardPlayerTwo = new Ocean("Shooting Board", playerTwo.PlayerName);

            while (!allSunk)
            {
                boardPlayerOne.PrintBoard();
                boardPlayerOne.SetShipsInBoard();
                View.PlayerChange();
                boardPlayerTwo.PrintBoard();
                boardPlayerTwo.SetShipsInBoard();

                // here will be the play of Player One (choosing coordinates), if ships are already set
                // here will be the play of Player Two (choosing coordinates), if ships are already set
            }

        }

        public static void WelcomeToGame()
        {
            Console.WriteLine("Welcome to Battleship game! Set your ships and try to shoot ships of your oponent. Good luck!");
            Console.WriteLine("Press any key to START...");
            Console.ReadLine();
        }


    }
}