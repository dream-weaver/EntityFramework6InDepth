using System;
using System.Data.Entity;
using CodeFirst.FluentAPI;
using CodeFirst.FluentAPI.Models;

namespace CodeFirst.Repository.Implementation
{
    public class CourseRepository : ICourseRepository
    {

        public void Add(Course course)
        {
            var context = new PlutoFluentAPIContext();
            context.Courses.Add(course);
            context.SaveChanges();
        }

        public void Remove(int courseID)
        {
            var context = new PlutoFluentAPIContext();

            var singleCourse = context.Courses.Find(courseID);
            context.Courses.Remove(singleCourse);

            context.SaveChanges();
        }

        public void Update(int courseID)
        {
            var context = new PlutoFluentAPIContext();

            var singleCourse = context.Courses.Find(courseID);
            singleCourse.Title = "A 16 Hour C# Course with Visual Studio 2013";
            singleCourse.Description = "ADO.Net with C# Windows Form along with SQL Server";
            singleCourse.AuthorID = 5;

            context.SaveChanges();

        }
    }
}
