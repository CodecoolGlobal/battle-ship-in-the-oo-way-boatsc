using System;
using System.Collections.Generic;

namespace BattleShip
{
    public class BattleShipMain
    {  
        static void Main(string[] args)
        {
            Ocean ocean = new Ocean();
            ocean.PrintGame();
            Console.Read();
            ocean.Board[2, 4].SquareType = SquareType.Battleship;
            ocean.PrintGame();
        }
    }
}