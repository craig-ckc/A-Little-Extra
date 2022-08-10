using System.ComponentModel.DataAnnotations;

namespace A_little_Extra.Models
{
    public class UniversityPatner
    {
		[Key]
		public int UserId { get; set; }

		public string Password { get; set; }

		public string Name { get; set; }

		[Display(Name = "Email")]
		public string Email { get; set; }

		[Display(Name = "Phone")]
		public string Phone { get; set; }

		public bool isActive { get; set; }

		// Relationship with Activity (Assciation Entity)
		public List<Activity> Activities { get; set; }
	}
}
