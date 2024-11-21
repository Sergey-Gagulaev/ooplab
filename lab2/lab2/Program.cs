using System;

namespace Classes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Створення гравців
            BaseGameAccount player1 = new StandardAccount("Сергій");
            BaseGameAccount player2 = new HalfPenaltyAccount("Микита");
            BaseGameAccount player3 = new StreakBonusAccount("Ольга");

            // Створення ігор через фабрику
            BaseGame game1 = GameFactory.CreateGame("Standard", 30);
            BaseGame game2 = GameFactory.CreateGame("Training");
            BaseGame game3 = GameFactory.CreateGame("SoloRated", 50);

            // Створення ігрового двигуна
            GameEngine engine1 = new GameEngine(player1, player2);
            GameEngine engine2 = new GameEngine(player3, player1);

            // Проведення ігор
            engine1.PlayGame(game1, "Win");
            engine2.PlayGame(game2, "Lose");
            engine2.PlayGame(game3, "Win");

            // Виведення статистики
            player1.GetStats();
            player2.GetStats();
            player3.GetStats();
        }
    }

}
