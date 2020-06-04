using CodeFirst.ExerciseData.Models;
using System.Collections.Generic;
using System;

namespace CodeFirst.ExerciseData
{
    public class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }    
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }
        public Classification Classification { get; set; }
        public IList<Tag> Tags { get; set; }
    }
}
