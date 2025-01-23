using System;

namespace Classes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Ініціалізація бази даних, репозиторіїв та сервісів
            DbContext dbContext = new DbContext();
            PlayerRepository playerRepo = new PlayerRepository(dbContext);
            GameRepository gameRepo = new GameRepository(dbContext);
            PlayerService playerService = new PlayerService(playerRepo);
            GameService gameService = new GameService(gameRepo);

            // Отримання гравців
            BaseGameAccount player1 = playerService.GetAllPlayers()[0]; // Сергій
            BaseGameAccount player2 = playerService.GetAllPlayers()[1]; // Микита

            // Створення гри
            BaseGame game = new StandardGame(30);
            GameEngine engine = new GameEngine(player1, player2);

            // Проведення гри
            engine.PlayGame(game, "Win", gameService);

            // Виведення всіх гравців
            Console.WriteLine("Список усіх гравців:");
            foreach (var player in playerService.GetAllPlayers())
            {
                player.GetStats();
            }

            // Виведення всіх ігор
            Console.WriteLine("Список усіх ігор:");
            foreach (var g in gameService.GetAllGames())
            {
                Console.WriteLine($"{g.OpponentName} - {g.Result}, {g.Rating} рейтинг.");
            }
        }
    }
}
