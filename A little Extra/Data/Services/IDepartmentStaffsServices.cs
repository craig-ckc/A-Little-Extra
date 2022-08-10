using A_little_Extra.Models;

namespace A_little_Extra.Data.Services
{
    public interface IDepartmentStaffsServices
    {
        void Add(DepartmentStaff staff);

        void Delete(int id);

        Task<IEnumerable<DepartmentStaff>> GetAll();

        DepartmentStaff GetById(int id);

        DepartmentStaff Update(int id, DepartmentStaff staff);
    }
}
