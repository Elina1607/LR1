using System;

namespace lr1
{
    public class Game
    {
        private int rating;
        private int gameId;
        
        private GameAccount player1;
        private GameAccount player2;
        private GameResult player1_result;
        private GameResult player2_result;
        
        private Random rand = new Random();

        public Game(GameAccount player1, GameAccount player2)
        {
            gameId = rand.Next(0, 9999);
            this.player1 = player1;
            this.player2 = player2;
        }
        
        public void Play()
        {
            gameId++;
            rating = rand.Next(1, 5);
            if (rating < 0) throw new Exception("Rating is out of range");
            if (rand.Next(2) == 0)
            {
                player1_result = GameResult.Win;
                player2_result = GameResult.Lose;
                player1.WinGame(player2.userName,rating,gameId);
                player2.LoseGame(player1.userName,rating,gameId);
            }
            else
            {
                player1_result = GameResult.Lose;
                player2_result = GameResult.Win;
                player2.WinGame(player1.userName,rating,gameId);
                player1.LoseGame(player2.userName,rating,gameId);
            }
        }
    }
}