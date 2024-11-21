namespace Classes
{
    // Фабрика для створення об'єктів ігор
    public class GameFactory
    {
        public static BaseGame CreateGame(string gameType, int rating = 0)
        {
            return gameType switch
            {
                "Standard" => new StandardGame(rating), // Стандартна гра
                "Training" => new TrainingGame(), // Тренувальна гра
                "SoloRated" => new SoloRatedGame(rating), // Гра лише для одного гравця
                _ => throw new ArgumentException("Unknown game type") // Обробка невідомого типу
            };
        }
    }
}
