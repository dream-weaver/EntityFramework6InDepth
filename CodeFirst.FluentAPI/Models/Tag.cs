using System.Collections.Generic;

namespace CodeFirst.FluentAPI.Models
{
    public class Tag
    {
        public Tag()
        {
            Courses = new HashSet<Course>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Course> Courses { get; set; }

    }
}
