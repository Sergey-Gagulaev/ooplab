using System.Collections.Generic;

namespace Classes
{
    public class DbContext
    {
        public List<BaseGameAccount> Players { get; set; }
        public List<Game> Games { get; set; }

        public DbContext()
        {
            Players = new List<BaseGameAccount>
            {
                new StandardAccount("Сергій"),
                new HalfPenaltyAccount("Микита"),
                new StreakBonusAccount("Ольга")
            };

            Games = new List<Game>();
        }
    }
}
