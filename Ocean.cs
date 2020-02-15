using System;
using System.Collections.Generic;

namespace BattleShip
{
    public class Ocean
    {
        public Square[,] Board {get; set;}
        public List<Ship> Ships {get; set;}

        public String[] alphas = new String[] {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J"};
        public String[] nums = new String[] {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};
        
        public Ocean()
        {
            Board = new Square[10,10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Board[i, j] = new Square(i, j);
                }
            }
            Ships = new List<Ship>();
        }

        public void PrintGame()
        {
            Console.WriteLine();
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
            Console.WriteLine();
        }

        public void AddShip(Coordinates coordinates, ShipDirection direction, SquareType squareType)
        {
            if (SpaceEmpty(Board, coordinates))
            {
                Ship ship = new Ship(direction, squareType);
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
                Ships.Add(ship);
            }
            else
            {
                Console.WriteLine("There is already ship in this place!");
            }
        }

        public bool SpaceEmpty(Square[,] board, Coordinates coordinates)
        {
            if (board[coordinates.Row , coordinates.Col].SquareType == SquareType.Empty)
            {
                return true;
            }
        return false;
        // add check if potential ship fits in the board
        }
        public Coordinates GetCoordinates()
        {
            Console.WriteLine("Insert coordinates (one letter, one digit - e.g. D5): ");
            string inputCoordinates = Console.ReadLine();
            while (!CorrectCoordinates(inputCoordinates))
            {
                Console.Write("Insert coordinates (one letter, one digit - e.g. D5): ");
                inputCoordinates = Console.ReadLine();
            }
            Coordinates convertedCoordinates = ConvertCoordinates(inputCoordinates);
            return convertedCoordinates;
        }

        public bool CorrectCoordinates(string inputCoordinates)
        {
            //check if 2 chars, first must be a letter, second - a one digit number
            
            return true;
        }
        public Coordinates ConvertCoordinates(string inputCoordinates)
        {
            int row = Array.IndexOf(alphas, char.ToUpper(inputCoordinates[0]).ToString());
            int col = Convert.ToInt32(inputCoordinates[1].ToString());
            Coordinates coordinates = new Coordinates(row, col);
            return coordinates;
        }
    }
}