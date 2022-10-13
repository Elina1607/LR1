using System;

namespace lr1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Гра почалась \n");
            GameAccount player1 = new GameAccount("Гравець 1");
            GameAccount player2 = new GameAccount("Гравець 2");
            Game simple_game = new Game(player1, player2);
            simple_game.Play();
            simple_game.Play();
            simple_game.Play();
            simple_game.Play();
            
            
            player1.GetStats();
            Console.WriteLine();
            player2.GetStats();
        }
    }
}