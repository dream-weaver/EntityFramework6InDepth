using CodeFirst.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Data
{
    public class Course
    {
        public int Id { get; set; }
        [Required, MaxLength(255)]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public CourseLevel Level { get; set; }
        public float FullPrice { get; set; }
        [ForeignKey("Author")]
        public int AuthorID { get; set; }
        public Author Author { get; set; }
        public IList<Tag> Tags { get; set; }
    }
}
