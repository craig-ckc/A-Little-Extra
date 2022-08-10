using A_little_Extra.Models;

namespace A_little_Extra.Data.Services
{
    public interface IAwardsServices
    {
        void Add(Award award);

        void Delete(int id);

        Task<IEnumerable<Award>> GetAll();

        Award GetById(int id);

        Award Update(int id, Award award);
    }
}
