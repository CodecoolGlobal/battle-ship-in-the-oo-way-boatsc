using System;
using System.Collections.Generic;

namespace BattleShip
{
    public class BattleShipMain
    {  
        static void Main(string[] args)
        {
            Player playerOne = new Player("Player 1");
            Player playerTwo = new Player("Player 2");
            
            View.WelcomeToGame();
            
            playerOne.GetPlayerName();
            playerTwo.GetPlayerName();

            Ocean boardPlayerOne = new Ocean("Board", playerOne.PlayerName);
            Ocean guessingBoardPlayerOne = new Ocean("Shooting Board", playerOne.PlayerName);
            Ocean boardPlayerTwo = new Ocean("Board", playerTwo.PlayerName);
            Ocean guessingBoardPlayerTwo = new Ocean("Shooting Board", playerTwo.PlayerName);

            boardPlayerOne.PrintBoard();
            boardPlayerOne.SetShipsInBoard();
            View.PlayerChange();
            boardPlayerTwo.PrintBoard();
            boardPlayerTwo.SetShipsInBoard();
            bool allSunk = false;

            while (!allSunk)
            {
                // here will be the play of Player One (choosing coordinates), if ships are already set
                // here will be the play of Player Two (choosing coordinates), if ships are already set
            }

        }




    }
}