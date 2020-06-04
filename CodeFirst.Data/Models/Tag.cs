using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Data.Models
{
    public class Tag
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public IList<Course> Courses { get; set; }
    }
}
