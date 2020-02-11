using System;

namespace BattleShip
{
    public class Coordinates
    {
        public int Row {get; set;}
        public int Column { get; set;}

        public Coordinates(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}