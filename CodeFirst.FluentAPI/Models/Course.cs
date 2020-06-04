﻿using System.Collections.Generic;

namespace CodeFirst.FluentAPI.Models
{
    public class Course
    {
        public Course()
        {
            Tags = new HashSet<Tag>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public CourseLevel Level { get; set; }
        public float FullPrice { get; set; }
        public Author Author { get; set; }
        public int AuthorID { get; set; }
        public Cover Cover { get; set; }
        public virtual ICollection<Tag> Tags { get; set; }
    }
}
