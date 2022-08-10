using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace A_little_Extra.Models
{
    public class Award
    {
		[Key]
		public int AwardId { get; set; }

		[Display(Name = "Name")]
		public string Name { get; set; }

		[Display(Name = "Description")]
		public string Description { get; set; }

		// foreign key : Activity
		public int ActivityId { get; set; }
		[ForeignKey("ActivityId")]
		public Activity Activity { get; set; }

		// Relationship with StudentAward (Assciation Entity)
		public List<StudentAward> StudentAwards { get; set; }
	}
}
