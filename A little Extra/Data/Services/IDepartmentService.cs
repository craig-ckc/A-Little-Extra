using A_little_Extra.Models;

namespace A_little_Extra.Data.Services
{
    public interface IDepartmentService
    {
        void Add(Department department);

        void Delete(int id);

        Task<IEnumerable<Department>> GetAll();

        Department GetById(int id);

        Department Update(int id, Department department);
    }
}
