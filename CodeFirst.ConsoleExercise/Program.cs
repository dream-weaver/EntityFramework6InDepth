using CodeFirst.ExerciseData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.ConsoleExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new VidzyContext();

            var actionMoviesSortedByNameQuerySyntax =
                from m in context.Videos
                where m.GenreId == 2
                orderby m.Name
                select m;

            var actionMoviesSortedByNameExtensionMethod =
                context.Videos
                .Where(m => m.GenreId == 2)
                .OrderBy(m => m.Name);

            //foreach (var a in actionMoviesSortedByNameExtensionMethod)
            //    Console.WriteLine(a.Name);

            var goldMoviesSortedByReleaseDateExtensionMethod =
                context.Videos
                .Where(m => m.Classification == ExerciseData.Models.Classification.Gold)
                .OrderByDescending(m => m.ReleaseDate);

            //foreach (var a in goldMoviesSortedByReleaseDateExtensionMethod)
            //    Console.WriteLine(a.Name);

            var projectedMovieWithGenre =
               context.Videos
               .OrderBy(v => v.Name)
               .Select(m => new { MovieName = m.Name, GenreName = m.Genre.Name });

            //foreach (var a in projectedMovieWithGenre)
            //    Console.WriteLine("{0} - {1}", a.MovieName, a.GenreName);

            var moviesGroupedClassification =
             from m in context.Videos
             group m by m.Classification
             into g
             select g;

            //foreach (var a in moviesGroupedClassification){

            //    Console.WriteLine(a.Key);
            //    foreach (var m in a)
            //        Console.WriteLine("\t" + m.Name);
            //}   

            var movieByClass =
            context.Videos
            .Select(c => new
            {
                Section = c.Classification,
                VideoName = c.Name

            }).GroupBy(c=>c.Section);

            //foreach (var item in movieByClass)
            //{
            //    Console.WriteLine("{0}-{1}", item.Key, item.Count());
            //}

            var genreWithVideo =
            context.Videos.Join(context.Genres, v => v.GenreId, g => g.Id, (videos, genres) => new { GenreName = genres.Name, VideoName = videos.Name }).GroupBy(m => m.GenreName);
            foreach (var item in genreWithVideo)
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Count());
            }

            Console.ReadLine();
        }
    }
}
