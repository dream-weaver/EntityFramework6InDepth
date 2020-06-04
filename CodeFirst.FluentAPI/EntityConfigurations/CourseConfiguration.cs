using CodeFirst.FluentAPI.Models;
using System.Data.Entity.ModelConfiguration;

namespace CodeFirst.FluentAPI.EntityConfigurations
{
    public class CourseConfiguration : EntityTypeConfiguration<Course>
    {
        public CourseConfiguration()
        {
            //ToTable("tbl_Course");
            //HasKey(c => c.Id);

            Property(c => c.Description)
               .IsRequired()
               .IsMaxLength();

            Property(c => c.Title)
                .IsRequired()
                .HasMaxLength(255);         

            HasRequired(c => c.Author)
            .WithMany(a => a.Courses)
            .HasForeignKey(c => c.AuthorID)
            .WillCascadeOnDelete(false);

            HasRequired(c => c.Cover)
            .WithRequiredPrincipal(c => c.Course);

            HasMany(c => c.Tags)
            .WithMany(t => t.Courses)
            .Map(m =>
            {
                m.ToTable("CourseTags");
                m.MapLeftKey("CourseId");
                m.MapRightKey("TagId");
            });
        }
    }
}
