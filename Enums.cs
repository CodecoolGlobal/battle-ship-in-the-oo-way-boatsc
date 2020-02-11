namespace BattleShip
{
    public enum SquareType
    {
        Empty,
        Hit,
        Miss,
        Carrier, //(occupies 5 squares)
        Battleship, // (4)
        Cruiser, // (3)
        Submarine, // (3)
        Destroyer // (2)
    }

    public enum ShipDirection
    {
        Vertical,
        Horizontal
    }
}