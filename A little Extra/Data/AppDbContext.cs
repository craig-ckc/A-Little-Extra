using A_little_Extra.Models;
using Microsoft.EntityFrameworkCore;

namespace A_little_Extra.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Many-to-many Relationship: Activity and Student
            modelBuilder.Entity<ActivityParticipation>().HasKey(am => new { am.ActivityId, am.UserId });

            modelBuilder.Entity<ActivityParticipation>().HasOne(m => m.Activity).WithMany(am => am.ActivityParticipations).HasForeignKey(m => m.ActivityId);
            modelBuilder.Entity<ActivityParticipation>().HasOne(m => m.Student).WithMany(am => am.ActivityParticipations).HasForeignKey(m => m.UserId);

            // Many-to-many Relationship: Activity and DepartmentStaff
            modelBuilder.Entity<ActivitySupervision>().HasKey(am => new { am.ActivityId, am.UserId });

            modelBuilder.Entity<ActivitySupervision>().HasOne(m => m.Activity).WithMany(am => am.ActivitySupervisions).HasForeignKey(m => m.ActivityId);
            modelBuilder.Entity<ActivitySupervision>().HasOne(m => m.DepartmentStaff).WithMany(am => am.ActivitySupervisions).HasForeignKey(m => m.UserId);

            // Many-to-many Relationship: Activity and DepartmentStaff
            modelBuilder.Entity<StudentAward>().HasKey(am => new { am.AwardId, am.UserId });

            modelBuilder.Entity<StudentAward>().HasOne(m => m.Award).WithMany(am => am.StudentAwards).HasForeignKey(m => m.AwardId);
            modelBuilder.Entity<StudentAward>().HasOne(m => m.Student).WithMany(am => am.StudentAwards).HasForeignKey(m => m.UserId);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Student> Students { get; set; }

        public DbSet<DepartmentStaff> DepartmentStaffs { get; set; }

        public DbSet<UniversityPatner> UniversityPatners { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Activity> Activities { get; set; }

        public DbSet<Award> Awards { get; set; }

        public DbSet<StudentAward> StudentAwards { get; set; }

        public DbSet<ActivityParticipation> ActivityParticipations { get; set; }

        public DbSet<ActivitySupervision> ActivitySupervisions { get; set; }
    }
}
