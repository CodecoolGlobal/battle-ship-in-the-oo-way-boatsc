using System;
using System.Collections.Generic;

namespace BattleShip
{
    public class Ship
    {
        // public List<Square> Squares { get; set; }
        public string ShipName { get; set; }
        public ShipDirection Direction { get; set; }
        public SquareType SquareType { get; set; }
        public int Size { get; set; }
        public bool IsSunk;

        public Ship(ShipDirection direction, SquareType shipType)
        {
            ShipName = shipType.ToString();
            Direction = direction;
            SquareType = shipType;
            IsSunk = false;
            Size = ShipSize();
        }

        public int ShipSize()
        {
            switch (SquareType)
            {
                case SquareType.Carrier:
                    return 5;
                case SquareType.Battleship:
                    return 4;
                case SquareType.Destroyer:
                    return 2;
                case SquareType.Cruiser:
                case SquareType.Submarine:
                default:
                    return 3;
            }
        }

    }
}