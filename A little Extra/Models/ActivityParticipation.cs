namespace A_little_Extra.Models
{
    public class ActivityParticipation
    {
		// foreign key : Activity
		public int ActivityId { get; set; }
		public Activity Activity { get; set; }

		// foreign key : Student
		public int UserId { get; set; }
		public Student Student { get; set; }
	}
}
