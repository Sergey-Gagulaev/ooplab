namespace Classes
{
    // Аккаунт із бонусом за серію перемог
    public class StreakBonusAccount : BaseGameAccount
    {
        private int winStreak; // Лічильник серії перемог

        public StreakBonusAccount(string userName) : base(userName)
        {
            winStreak = 0;
        }

        // Перевизначення методу WinGame для додавання бонусів за серію перемог
        public override void WinGame(BaseGame game, string opponentName)
        {
            winStreak++;
            int bonus = winStreak > 2 ? 10 : 0; // Бонус за серію перемог
            int rating = game.CalculateRating() + bonus;

            CurrentRating += rating;
            gameHistory.Add(new Game(opponentName, "Win", rating));
        }

        // Скидання серії перемог у разі поразки
        public override void LoseGame(BaseGame game, string opponentName)
        {
            winStreak = 0; 
            base.LoseGame(game, opponentName); 
        }
    }
}
