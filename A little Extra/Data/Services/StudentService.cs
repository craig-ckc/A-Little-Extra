using A_little_Extra.Models;
using Microsoft.EntityFrameworkCore;

namespace A_little_Extra.Data.Services
{
    public class StudentService : IStudentsService
    {
        private readonly AppDbContext context;

        public StudentService(AppDbContext context)
        {
            this.context = context;
        }

        public void Add(Student student)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            var result = await context.Students.ToListAsync();

            return result;
        }

        public Student GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Student Update(int id, Student student)
        {
            throw new NotImplementedException();
        }
    }
}
