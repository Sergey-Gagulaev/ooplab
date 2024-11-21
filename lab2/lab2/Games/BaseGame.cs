using System;

namespace Classes
{
    // Базовий абстрактний клас для гри
    public abstract class BaseGame
    {
        // Абстрактний метод для розрахунку рейтингу
        public abstract int CalculateRating();
    }

    // Стандартна гра
    public class StandardGame : BaseGame
    {
        private int rating;

        public StandardGame(int rating)
        {
            this.rating = rating;
        }

        // Рейтинг стандартної гри
        public override int CalculateRating()
        {
            return rating;
        }
    }

    // Тренувальна гра (без рейтингу)
    public class TrainingGame : BaseGame
    {
        // Рейтинг тренувальної гри завжди 0
        public override int CalculateRating()
        {
            return 0;
        }
    }

    // Гра, де рейтинг нараховується лише одному гравцеві
    public class SoloRatedGame : BaseGame
    {
        private int rating;

        public SoloRatedGame(int rating)
        {
            this.rating = rating;
        }

        // Рейтинг гри лише для одного гравця
        public override int CalculateRating()
        {
            return rating;
        }
    }
}
