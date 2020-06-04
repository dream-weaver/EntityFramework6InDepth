using DatabaseFirst.ExerciseData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press any key to add video on the database..");
            var dbContext = new VidzyEntities();
            var video = new Video()
            {
                Name = "Van Helsing",
                ReleaseDate = DateTime.Now, 
                Classification = Classification.Silver
            };
            var genre = new Genre()
            {
                Name = "Action"
            };
            dbContext.AddVideo(video.Name, video.ReleaseDate, genre.Name, Convert.ToByte(video.Classification));
            dbContext.SaveChanges();
            Console.WriteLine("Video has been added to the database!");
            Console.ReadLine();
        }
    }
}
