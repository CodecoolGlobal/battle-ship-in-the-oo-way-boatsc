using System;
using System.Collections.Generic;

namespace BattleShip
{
    public class Ocean
    {
        public Square[,] Board {get; set;}
        
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
        }

        public void PrintGame()
        {
            String[] alphas = new String[] {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J"};
            String[] nums = new String[] {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"};
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
        }
    }
}