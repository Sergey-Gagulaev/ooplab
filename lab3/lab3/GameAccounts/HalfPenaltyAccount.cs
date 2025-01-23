namespace Classes
{
    // Аккаунт із зменшеним штрафом за поразку
    public class HalfPenaltyAccount : BaseGameAccount
    {
        public HalfPenaltyAccount(string userName) : base(userName) { }

        // Перевизначення методу LoseGame для зменшення штрафу вдвічі
        public override void LoseGame(BaseGame game, string opponentName)
        {
            int rating = game.CalculateRating() / 2; // Половина штрафу
            CurrentRating -= rating;
            if (CurrentRating < 0) CurrentRating = 0;
            gameHistory.Add(new Game(opponentName, "Lose", rating)); // Рейтинг відображає зменшений штраф
        }
    }
}
