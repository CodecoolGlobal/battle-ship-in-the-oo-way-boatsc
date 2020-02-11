using System;

namespace BattleShip
{
    public class Ship
    {
        public String Direction { get; set; }
        public Int32 Size { get; set; }
        public Boolean IsSunk;

        public Ship(string direction, int size)
        {
            Direction = direction;
            Size = size;
            IsSunk = false;
        }

    }
}