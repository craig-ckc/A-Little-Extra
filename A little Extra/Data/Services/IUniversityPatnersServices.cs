using A_little_Extra.Models;

namespace A_little_Extra.Data.Services
{
    public interface IUniversityPatnersServices
    {
        void Add(UniversityPatner patner);

        void Delete(int id);

        Task<IEnumerable<UniversityPatner>> GetAll();

        UniversityPatner GetById(int id);

        UniversityPatner Update(int id, UniversityPatner patner);
    }
}
