namespace A_little_Extra.Models
{
	public class StudentAward
	{
		// foreign key : Award
		public int AwardId { get; set; }
		public Award Award { get; set; }

		// foreign key : Student
		public int UserId { get; set; }
		public Student Student { get; set; }

	}
}
