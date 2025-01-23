using System.Collections.Generic;

namespace Classes
{
    public interface IGameRepository
    {
        void Create(Game game);
        Game ReadById(int id);
        List<Game> ReadAll();
        List<Game> ReadByPlayer(string playerName);
    }
}
