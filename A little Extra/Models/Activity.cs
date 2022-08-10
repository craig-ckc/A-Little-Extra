using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_little_Extra.Models
{
    public class Activity
    {
		[Key]
		public int ActivityId { get; set; }

		[Display(Name = "Name")]
        [Required(ErrorMessage = "Activity name is required")]
		public string Name { get; set; }

		[Display(Name = "Description")]
		[Required(ErrorMessage = "Activity description is required")]
		public string Description { get; set; }

		[Display(Name = "Start date")]
		[Required(ErrorMessage = "Activity end date is required")]
		public DateTime StartDate { get; set; }

		[Display(Name = "End date")]
		[Required(ErrorMessage = "Activity start date is required")]
		public DateTime EndDate { get; set; }

		[Display(Name = "Points")]
		[Required(ErrorMessage = "Activity points are required")]
		public int Points { get; set; }

		// foreign key : Activity
		public int UserId { get; set; }
		[ForeignKey("UserId")]
		// public User User { get; set; }

		// Relationship with ActivityParticipation (Assciation Entity)
		public List<ActivityParticipation> ActivityParticipations { get; set; }

		// Relationship with ActivitySupervision (Assciation Entity)
		public List<ActivitySupervision> ActivitySupervisions { get; set; }

		// Relationship with Award 
		public List<Award> Awards { get; set; }
	}
}
