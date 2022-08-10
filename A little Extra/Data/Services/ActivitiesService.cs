using A_little_Extra.Models;
using Microsoft.EntityFrameworkCore;

namespace A_little_Extra.Data.Services
{
    public class ActivitiesService : IActivitiesService
    {
        private readonly AppDbContext context;

        public ActivitiesService(AppDbContext context)
        {
            this.context = context;
        }
        public async Task AddAsync(Activity activity)
        {
            await context.Activities.AddAsync(activity);
            await context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Activity>> GetAllAysnc()
        {
            var result = await context.Activities.ToListAsync();

            return result;
        }

        public async Task<Activity> GetByIdAysnc(int id)
        {
            var activity = await context.Activities.FirstOrDefaultAsync(n => n.UserId == id);

            return activity;
        }

        public Task<Activity> UpdateAsync(int id, Activity activity)
        {
            throw new NotImplementedException();
        }
    }
}
