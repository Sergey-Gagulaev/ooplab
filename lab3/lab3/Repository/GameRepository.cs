using System.Collections.Generic;
using System.Linq;

namespace Classes
{
    public class GameRepository : IGameRepository
    {
        private readonly DbContext _context;

        public GameRepository(DbContext context)
        {
            _context = context;
        }

        public void Create(Game game)
        {
            _context.Games.Add(game);
        }

        public Game ReadById(int id)
        {
            return _context.Games.ElementAtOrDefault(id);
        }

        public List<Game> ReadAll()
        {
            return _context.Games;
        }

        public List<Game> ReadByPlayer(string playerName)
        {
            return _context.Games.Where(g => g.OpponentName == playerName).ToList();
        }
    }
}
