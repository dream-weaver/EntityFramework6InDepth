using CodeFirst.FluentAPI.EntityConfigurations;
using CodeFirst.FluentAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodeFirst.FluentAPI
{
    public class PlutoFluentAPIContext : DbContext
    {
        public PlutoFluentAPIContext()
            :base("name= PlutoFluentAPIContext")
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CourseConfiguration());   
        }
        
    }
}
