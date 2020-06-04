using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirst.Data;
using CodeFirst.Data.Models;

namespace DataAnnotations
{
    public class PlutoDataContext : DbContext
    {
        public PlutoDataContext()
            :base("name = PlutoDataContext")
        {
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Apply Configuration using Fluent API
           
        }
    }
}
