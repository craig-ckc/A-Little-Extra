using A_little_Extra.Models;

namespace A_little_Extra.Data.Services
{
    public interface IStudentsService
    {
        void Add(Student student);

        void Delete(int id);

        Task<IEnumerable<Student>> GetAll();

        Student GetById(int id);

        Student Update(int id, Student student);
    }
}
