using System;

namespace RPS
{

    class Program
    {
        private static void Main(string[] args)
        {
            
            int result = RockPaperScissors(args[0], args[1]);
              

            switch (result)
            {
                case 0:
                    Console.WriteLine("It's a draw!");
                    break;
                case 1:
                    Console.WriteLine("Player 1 wins!");
                    break;
                case 2:
                    Console.WriteLine("Player 2 wins!");
                    break;
            }
        }

        private static int RockPaperScissors(string player1, string player2)
        {
            GameItem P1Play = (GameItem)Enum.Parse(typeof(GameItem), player1);
            GameItem P2Play = (GameItem)Enum.Parse(typeof(GameItem), player2);

            GameStatus result = 0;

            if (P1Play == P2Play)
            {
                result = GameStatus.Draw;
                return (int)result;
            }
            else if (((P1Play == GameItem.Rock) && (P2Play == GameItem.Scissors)) ||
                ((P1Play == GameItem.Scissors) && (P2Play == GameItem.Paper)) ||
                ((P1Play == GameItem.Paper) && (P2Play == GameItem.Rock)))
            {
                result = GameStatus.Player1Wins;
                return (int)result;
            }
            else
            {
                result = GameStatus.Player2Wins;
                return (int)result;
            }
                
        }
    }
}
