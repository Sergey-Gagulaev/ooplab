using System.Collections.Generic;

namespace Classes
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _repository;

        public PlayerService(IPlayerRepository repository)
        {
            _repository = repository;
        }

        public void CreatePlayer(BaseGameAccount player)
        {
            _repository.Create(player);
        }

        public List<BaseGameAccount> GetAllPlayers()
        {
            return _repository.ReadAll();
        }

        public BaseGameAccount GetPlayerById(int id)
        {
            return _repository.ReadById(id);
        }

        public void UpdatePlayer(BaseGameAccount player)
        {
            _repository.Update(player);
        }

        public void DeletePlayer(int id)
        {
            _repository.Delete(id);
        }
    }
}
