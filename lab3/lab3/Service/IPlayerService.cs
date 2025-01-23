using System.Collections.Generic;

namespace Classes
{
    public interface IPlayerService
    {
        void CreatePlayer(BaseGameAccount player);
        List<BaseGameAccount> GetAllPlayers();
        BaseGameAccount GetPlayerById(int id);
        void UpdatePlayer(BaseGameAccount player);
        void DeletePlayer(int id);
    }
}
