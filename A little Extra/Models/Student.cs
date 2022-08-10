using System.ComponentModel.DataAnnotations;

namespace A_little_Extra.Models
{
    public class Student
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

		[Display(Name = "Points")]
		public string Points { get; set; }

		public bool isActive { get; set; }

		// Relationship with Activity (Assciation Entity)
		public List<Activity> Activities { get; set; }

		// Relationship with ActivityParticipation (Assciation Entity)
		public List<ActivityParticipation> ActivityParticipations { get; set; }

		// Relationship with StudentAward (Assciation Entity)
		public List<StudentAward> StudentAwards { get; set; }
	}
}
