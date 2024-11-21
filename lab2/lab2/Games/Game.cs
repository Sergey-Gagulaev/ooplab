namespace Classes
{
    public class Game
    {
        public Guid GameId { get; }
        public string OpponentName { get; }
        public string Result { get; }
        public int Rating { get; private set; }

        public Game(string opponentName, string result, int rating)
        {
            GameId = Guid.NewGuid();
            OpponentName = opponentName;
            Result = result;
            Rating = rating;
        }
    }
}
