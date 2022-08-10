using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_little_Extra.Models
{
    public class DepartmentStaff
    {
		[Key]
		public int UserId { get; set; }

		public string Password { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		[Display(Name = "Email")]
		public string Email { get; set; }

		[Display(Name = "Phone")]
		public string Phone { get; set; }

		public bool isActive { get; set; }

		// foreign key : Department
		public int DepartmentId { get; set; }
		[ForeignKey("DepartmentId")]
		public Department Department { get; set; }

		// Relationship with Activity (Assciation Entity)
		public List<Activity> Activities { get; set; }

		// Relationship with ActivitySupervision (Assciation Entity)
		public List<ActivitySupervision> ActivitySupervisions { get; set; }
	}
}
