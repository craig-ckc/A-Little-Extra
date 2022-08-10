using System.ComponentModel.DataAnnotations;

namespace A_little_Extra.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; }

        // Relationship with DepartmentStaff (Assciation Entity)
        public List<DepartmentStaff> DepartmentStaffs { get; set; }
    }
}
