using System;
using System.Collections.Generic;

namespace Classes
{
    // Базовий клас для ігрового аккаунта
    public abstract class BaseGameAccount
    {
        public string UserName { get; } // Ім'я гравця
        public int CurrentRating { get; set; } // Поточний рейтинг
        public int GamesCount => gameHistory.Count; // Кількість ігор
        protected List<Game> gameHistory; // Історія ігор

        public BaseGameAccount(string userName)
        {
            UserName = userName;
            CurrentRating = 0;
            gameHistory = new List<Game>();
        }

        // Метод для обробки перемоги (віртуальний)
        public virtual void WinGame(BaseGame game, string opponentName)
        {
            int rating = game.CalculateRating();
            CurrentRating += rating;
            gameHistory.Add(new Game(opponentName, "Win", rating));
        }

        // Метод для обробки поразки (віртуальний)
        public virtual void LoseGame(BaseGame game, string opponentName)
        {
            int rating = game.CalculateRating();
            CurrentRating -= rating;
            if (CurrentRating < 0) CurrentRating = 0;
            gameHistory.Add(new Game(opponentName, "Lose", rating));
        }

        // Метод для виведення статистики
        public void GetStats()
        {
            Console.WriteLine($"Гравець: {UserName}, Поточний рейтинг: {CurrentRating}, Кількість ігор: {GamesCount}");
            Console.WriteLine("Історія ігор:");
            Console.WriteLine("Індекс гри | Проти кого | Результат | Рейтинг");

            for (int i = 0; i < gameHistory.Count; i++)
            {
                var game = gameHistory[i];
                Console.WriteLine($"{i + 1}          | {game.OpponentName}    | {game.Result}      | {game.Rating}");
            }
        }
    }
}
