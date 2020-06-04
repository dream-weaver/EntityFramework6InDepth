using System.Collections.Generic;

namespace CodeFirst.FluentAPI.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public IList<Course> Courses { get; set; }
    }
}
