using System.Collections.Generic;

namespace Classes
{
    public class GameService : IGameService
    {
        private readonly IGameRepository _repository;

        public GameService(IGameRepository repository)
        {
            _repository = repository;
        }

        public void CreateGame(Game game)
        {
            _repository.Create(game);
        }

        public List<Game> GetAllGames()
        {
            return _repository.ReadAll();
        }

        public Game GetGameById(int id)
        {
            return _repository.ReadById(id);
        }

        public List<Game> GetGamesByPlayer(string playerName)
        {
            return _repository.ReadByPlayer(playerName);
        }
    }
}
