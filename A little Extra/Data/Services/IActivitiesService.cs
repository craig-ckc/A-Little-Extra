using A_little_Extra.Models;

namespace A_little_Extra.Data.Services
{
    public interface IActivitiesService
    {
        Task AddAsync(Activity activity);

        void Delete(int id);

        Task<IEnumerable<Activity>> GetAllAysnc();

        Task<Activity> GetByIdAysnc(int id);

        Task<Activity> UpdateAsync(int id, Activity activity);
    }
}
