using System;

namespace lr1
{
    public class Match
    {
        private int gameId { get; }
        private string opponentName { get; }
        private GameResult _result { get; }
        private int rating { get; }

        public Match(int gameId,string opponentName,GameResult _result,int rating)
        {
            this.gameId = gameId;
            this.opponentName = opponentName;
            this._result = _result;
            this.rating = rating;
        }

        public void printMatchInfo()
        {
            Console.WriteLine("Код гри: " + gameId + "\nПротивник: " + opponentName + "\nРейтинг: " + rating);
            if(_result == GameResult.Win) {Console.WriteLine("Виграв");}
            else {Console.WriteLine("Програв");}
        }
    }
}