using System;
using System.Collections.Generic;

namespace BattleShip
{
    public class Ocean
    {
        public string BoardName {get; set;}
        public string BoardOwner { get; set; }
        public Square[,] Board {get; set;}
        public List<string> Ships {get; set;}

        public String[] alphas = new String[] {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J"};
        public String[] nums = new String[] {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};
        
        public Ocean(string name, string boardOwner)
        {
            BoardName = name;
            BoardOwner = boardOwner;
            Board = new Square[10,10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Board[i, j] = new Square(i, j);
                }
            }
            Ships = new List<string>();
            BoardOwner = boardOwner;
        }

        public void PrintBoard()
        {
            View.EmptyLine();
            Console.WriteLine($"{BoardName} of {BoardOwner}:".ToUpper());
            View.EmptyLine();
            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("  {0}", string.Join("  ", nums));
                }
                string newLine = alphas[i] + ""; 
                for (int j = 0; j < 10; j++)
                {
                    newLine += Board[i, j];
                }
                Console.WriteLine(newLine);
            }
            View.EmptyLine();
        }

        public void AddShip(Coordinates coordinates, ShipDirection direction, SquareType squareType)
        {
            Ship ship = new Ship(direction, squareType);
            BuildShip(coordinates, direction, squareType, ship);
            Ships.Add(ship.ShipName);
        }

        private void BuildShip(Coordinates coordinates, ShipDirection direction, SquareType squareType, Ship ship)
        {
            for (int i = 0; i < ship.Size; i++)
            {
                Board[coordinates.Row, coordinates.Col].SquareType = squareType;
                if (direction == ShipDirection.Horizontal)
                {
                    coordinates.Col++;
                }
                else
                {
                    coordinates.Row++;
                }
            }
        }

        public bool SpaceEmpty(Coordinates coordinates)
        {
            if (Board[coordinates.Row , coordinates.Col].SquareType == SquareType.Empty)
            {
                return true;
            }
        return false;
        // add check if potential ship fits in the board
        }

        public Coordinates GetCoordinates(SquareType shipType)
        {
            Console.WriteLine($"{BoardOwner}, insert coordinates of {shipType} (one letter, one digit - e.g. D5): ");
            string inputCoordinates = Console.ReadLine();
            while (!CorrectCoordinates(inputCoordinates))
            {
                Console.Write($"{BoardOwner}, insert coordinates (one letter, one digit - e.g. D5): ");
                inputCoordinates = Console.ReadLine();
            }
            Coordinates convertedCoordinates = ConvertCoordinates(inputCoordinates);
            return convertedCoordinates;
        }

        public bool CorrectCoordinates(string inputCoordinates)
        {
            //check if 2 chars, first must be a letter, second - a one digit number
            bool ifCorrect = true;
            if (inputCoordinates.Length > 2)
            {
                ifCorrect = false;
                Console.WriteLine("Coordinates can be only 2 digits.");
            }
            if (LetterAToJ(inputCoordinates) || char.IsNumber((char)inputCoordinates[0]))
            {
                ifCorrect = false;
                Console.WriteLine("First character of coordinates must be a letter (A-J), and second - a number (0-9).");
            }

            return ifCorrect;
        }

        private bool LetterAToJ(string inputCoordinates)
        {
            return Array.IndexOf(alphas, char.ToUpper(inputCoordinates[0]).ToString()) == -1;
        }

        public Coordinates ConvertCoordinates(string inputCoordinates)
        {
            int row = Array.IndexOf(alphas, char.ToUpper(inputCoordinates[0]).ToString());
            int col = Convert.ToInt32(inputCoordinates[1].ToString());
            Coordinates coordinates = new Coordinates(row, col);
            return coordinates;
        }

        public ShipDirection GetShipDirection(SquareType shipType)
        {
            Console.WriteLine($"{BoardOwner}, insert {shipType} direction (h - horizontal, v - vertical): ");
            string inputDirection = Console.ReadLine();
            switch (inputDirection)
            {
                case "h": 
                    return ShipDirection.Horizontal;
                case "v": 
                default: 
                    return ShipDirection.Vertical;
            }
        }
    
        public bool FiveShipsSet()
        {
            if (Ships.Count < 5)
            {
                return false;
            }
            return true;
        }

        public void SetShipsInBoard()
        {
            var shipTypes = Enum.GetValues(typeof(SquareType));
            for (int i = 3; i < shipTypes.Length; i++)
            {
                SquareType shipType = (SquareType)shipTypes.GetValue(i);
                GetDataForShip(shipType);

                if (FiveShipsSet())
                {
                    break;
                }
            }
        }

        private void GetDataForShip(SquareType shipType) {
            
            Coordinates coordinates = GetCoordinates(shipType);
            ShipDirection direction = GetShipDirection(shipType);

            if (SpaceEmpty(coordinates))
            {
                AddShip(coordinates, direction, shipType);
                PrintBoard();
            }
            else
            {
                Console.WriteLine("There is already ship in this place!");
                GetDataForShip(shipType);
            }
        }
    }
}