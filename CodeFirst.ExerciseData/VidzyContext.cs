using CodeFirst.ExerciseData.EntityConfigurations;
using System.Data.Entity;

namespace CodeFirst.ExerciseData
{
    public class VidzyContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public VidzyContext()
            :base("name = VidzyCodeFirst")
        {           
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Configurations.Add(new VideoConfiguration());
            modelBuilder.Configurations.Add(new GenreConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
