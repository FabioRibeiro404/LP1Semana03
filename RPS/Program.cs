using System;

namespace RPS
{
    
    enum GameItem
    {
        Rock = 0,
        Paper = 1,
        Scissors = 2
    };

    
    enum GameStatus
    {
        Draw = 0,
        Player1Wins = 1,
        Player2Wins = 2
    };
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
            else if ((P1Play > P2Play))
            {
                result = GameStatus.Player1Wins;
                return (int)result;
            }
            else
            {
                result = GameStatus.Player2Wins;
                return (int)result;
            }
                

            
            
            /*
            if (player1 == player2)
            {
                return 0; // Draw
            }
            if (((player1 == "Rock") && (player2 == "Scissors")) ||
                ((player1 == "Scissors") && (player2 == "Paper")) ||
                ((player1 == "Paper") && (player2 == "Rock")))
            {
                return 1; // Player 1 wins
            }
            else
            {
                return 2; // Player 2 wins
            }*/
        }
    }
}
