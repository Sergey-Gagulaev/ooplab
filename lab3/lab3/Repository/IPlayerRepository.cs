using System.Collections.Generic;

namespace Classes
{
    public interface IPlayerRepository
    {
        void Create(BaseGameAccount player);
        BaseGameAccount ReadById(int id);
        List<BaseGameAccount> ReadAll();
        void Update(BaseGameAccount player);
        void Delete(int id);
    }
}
