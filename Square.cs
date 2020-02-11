using System;

namespace BattleShip
{
    public class Square
    {
        public Coordinates Coordinates { get; set; }
        public SquareType SquareType { get; set; }

        public Square(int row, int column)
        {
            Coordinates = new Coordinates(row, column);
            SquareType = SquareType.Empty;
        }

        public override string ToString() {
            switch (SquareType)
            {
                case SquareType.Hit:
                    return "[X]";
                case SquareType.Miss:
                    return "[O]";
                case SquareType.Carrier:
                    return "[C]";
                case SquareType.Battleship:
                    return "[B]";
                case SquareType.Submarine:
                    return "[S]";
                case SquareType.Cruiser:
                    return "[R]";
                case SquareType.Destroyer:
                    return "[D]";
                case SquareType.Empty:
                default:
                    return "[ ]";
            }
        }

        // public String ConvertCoordinates(string addedCoordinates)
        // {
        //     string[] newCoordinates = addedCoordinates.Split();
        //     to be continued...

        // }
    }
}