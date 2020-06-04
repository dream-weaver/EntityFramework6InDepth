using CodeFirst.FluentAPI;
using CodeFirst.FluentAPI.Models;
using CodeFirst.Repository;
using CodeFirst.Repository.Implementation;
using System;
using System.Linq;

namespace CodeFirst.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //var context = new PlutoFluentAPIContext();

            //// LINQ syntax :~:
            //var query = from c in context.Courses
            //            where c.Title.Contains("c#")
            //            orderby c.Title
            //            select c;

            //var queryA = from c in context.Courses
            //            where c.Level == CourseLevel.Begineer && c.AuthorID == 1
            //            select c;

            //var queryC = from c in context.Courses
            //             where c.AuthorID == 1
            //             orderby c.Title
            //             select new { Name = c.Title, Author = c.Author.Name };

            //var queryD = from c in context.Courses
            //             group c by c.Level 
            //             into g
            //             select g;

            //var queryE = from c in context.Courses
            //             select new { CourseName = c.Title, AuthorName = c.Author.Name };

            //var queryF = from c in context.Courses
            //             join a in context.Authors on c.AuthorID equals a.ID
            //             select new { CourseName = c.Title, AuthorName = a.Name };

            //var queryG = from a in context.Authors
            //             join c in context.Courses on a.ID equals c.AuthorID
            //             into g
            //             select new { AuthorName = a.Name, ListCourse = g };

            //var queryH = from a in context.Authors
            //             from c in context.Courses
            //             select new { AuthorName = a.Name, Courses = c.Title };



            //  // Extension methods :~:
            //var courses = context.Courses
            //    .Where(c => c.Title.Contains("c#"))
            //    .OrderBy(c => c.Title);

            //var courseList = context.Courses.Where(a => a.Level == CourseLevel.Intermediate);

            //var courseOrder = context.Courses.Where(a => a.Level == CourseLevel.Begineer)
            //                 .OrderByDescending(a => a.Title)
            //                 .ThenByDescending(a => a.Level)
            //                 //.Select( a => new { CourseName = a.Title, AuthorName = a.Author.Name });
            //                 .SelectMany(a => a.Tags)
            //                 .Distinct();

            //var courseByLevel = context.Courses.GroupBy(c => c.Level);
            ////foreach (var level in courseByLevel)
            ////{
            ////    Console.WriteLine(level.Key);
            ////    foreach (var course in level)
            ////        Console.WriteLine("\t" + course.Title);
            ////}

            //var courseNav = context.Courses
            //.Select(c => new
            //{
            //    CourseName = c.Title,
            //    AuthorName = c.Author.Name
            //});

            //var courseJoin = context.Courses.Join(context.Authors,
            //c => c.AuthorID,
            //a => a.ID,
            //(course, author) => new
            //{
            //    CourseName = course.Title,
            //    AuthorName = author.Name
            //});
            //foreach (var course in courseNav)
            //    Console.WriteLine("{0}, {1}", course.CourseName, course.AuthorName);

            ////var authorGroupJoin = context.Authors.GroupJoin(context.Courses,
            ////    a => a.ID,
            ////    c => c.AuthorID, (author, coursess) => new
            ////    {
            ////        AuthorName = author,
            ////        Courses = coursess.Count()
            ////    });

            ////var coursePage = context.Courses.Skip(10).Take(10);

            ////foreach (var item in authorGroupJoin)
            ////{
            ////    Console.WriteLine(item.AuthorName.Name, item.Courses);
            ////}

            ////foreach (var item in queryD)
            ////{
            ////    Console.WriteLine("{0}-{1}", item.Key, item.Count());
            ////    //foreach (var course in item)
            ////    //{
            ////    //    Console.WriteLine("\t{0}", course.Title);
            ////    //}
            ////}

            ////foreach (var item in queryG)
            ////{
            ////    Console.WriteLine(item.AuthorName);
            ////    foreach (var c in item.ListCourse)
            ////    {
            ////        Console.WriteLine(c.Title);
            ////    }
            ////}

            ////foreach (var i in queryH)
            ////    Console.WriteLine("{0}-{1}", i.AuthorName, i.Courses);
            ////foreach (var x in courseOrder)
            ////    Console.WriteLine("{0} - {1}", x.CourseName, x.AuthorName);

            ////foreach (var item in courseOrder)
            ////    Console.WriteLine(item.Name);
            ///

            Console.WriteLine(" Please specify which Database Operation you would like to do ?  Add, Update or Remove");
            string databaseOperation = Console.ReadLine();
            Console.WriteLine("Entered  = " + databaseOperation);

            var _repo = new CourseRepository();

            switch (databaseOperation)
            {
                case "Add":

                    var course = new Course
                    {
                        Title = "C#",
                        Description = "Entity Framework in Depth",
                        Level = CourseLevel.Begineer,
                        FullPrice = 14.99F,
                        Author = new Author { Name = "Julia Lerman" }
                    };

                    _repo.Add(course);

                    Console.WriteLine("Course added successfully!");
                    break;

                case "Update":

                    _repo.Update(7);
                    Console.WriteLine("Course updated successfully!");
                    break;

                case "Remove":

                    _repo.Remove(10);
                    Console.WriteLine("Course removed successfully!");
                    break;
            }


            Console.ReadLine();
        }

    }
}
