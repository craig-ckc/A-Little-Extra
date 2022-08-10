namespace A_little_Extra.Models
{
    public class ActivitySupervision
    {
		// foreign key : Activity
		public int ActivityId { get; set; }
		public Activity Activity { get; set; }

		// foreign key : DepartmentStaff
		public int UserId { get; set; }
		public DepartmentStaff DepartmentStaff { get; set; }

		public bool Accepted { get; set; }
	}
}
