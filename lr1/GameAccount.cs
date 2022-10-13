using System;
using System.Collections.Generic;


namespace lr1
{
    public class GameAccount
    {
        public string userName { get; }
        private int currentRating = 1;
        private int gamesCount;
        
        public List<Match> Matches = new List<Match>(); 

        public GameAccount(String userName)
        {
            this.userName = userName;
        }
        
        public void WinGame(string opponentName, int rating, int gameId)
        {
            currentRating += rating;
            gamesCount++;
            Matches.Add(new Match(gameId, opponentName,GameResult.Win,rating));
        }
        
        public void LoseGame(string opponentName, int rating, int gameId)
        {
            currentRating -= rating;
            if (currentRating < 1) currentRating = 1;
            gamesCount++;
            Matches.Add(new Match(gameId, opponentName,GameResult.Lose,rating));
        }

        public void GetStats()
        {
            foreach (var Match in Matches)
            {
                Match.printMatchInfo();
                Console.WriteLine("--------------------------");
            }
        }
    }
}