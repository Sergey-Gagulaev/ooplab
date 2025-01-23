using System.Collections.Generic;
using System.Linq;

namespace Classes
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly DbContext _context;

        public PlayerRepository(DbContext context)
        {
            _context = context;
        }

        public void Create(BaseGameAccount player)
        {
            _context.Players.Add(player);
        }

        public BaseGameAccount ReadById(int id)
        {
            return _context.Players.ElementAtOrDefault(id);
        }

        public List<BaseGameAccount> ReadAll()
        {
            return _context.Players;
        }

        public void Update(BaseGameAccount player)
        {
            var existingPlayer = _context.Players.FirstOrDefault(p => p.UserName == player.UserName);
            if (existingPlayer != null)
            {
                existingPlayer.CurrentRating = player.CurrentRating;
            }
        }

        public void Delete(int id)
        {
            if (id >= 0 && id < _context.Players.Count)
            {
                _context.Players.RemoveAt(id);
            }
        }
    }
}
