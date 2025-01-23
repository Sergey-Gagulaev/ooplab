using System.Collections.Generic;

namespace Classes
{
    public interface IGameService
    {
        void CreateGame(Game game);
        List<Game> GetAllGames();
        Game GetGameById(int id);
        List<Game> GetGamesByPlayer(string playerName);
    }
}
