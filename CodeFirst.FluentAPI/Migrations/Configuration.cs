namespace CodeFirst.FluentAPI.Migrations
{
    using CodeFirst.FluentAPI.Models;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirst.FluentAPI.PlutoFluentAPIContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PlutoFluentAPIContext context)
        {
            #region Add Tags
          
            var tags = new Dictionary<string, Tag>
            {
                {"c#", new Tag {Name = "c#"}},
                {"angularjs", new Tag {Name = "angularjs"}},
                {"javascript", new Tag {Name = "javascript"}},
                {"nodejs", new Tag {Name = "nodejs"}},
                {"oop", new Tag {Name = "oop"}},
                {"linq", new Tag {Name = "linq"}},
            };

            foreach (var tag in tags.Values)
                context.Tags.AddOrUpdate(t => t.ID, tag);
           
            #endregion

            #region Add Authors

                var authors = new List<Author>
                {
                    new Author
                    {
                        Name = "Mosh Hamedani"
                    },
                    new Author
                    {
                        Name = "Anthony Alicea"
                    },
                    new Author
                    {
                        Name = "Eric Wise"
                    },
                    new Author
                    {
                        Name = "Tom Owsiak"
                    },
                    new Author
                    {
                        Name = "John Smith"
                    }
                };
                foreach (var author in authors)
                    context.Authors.AddOrUpdate(a => a.ID, author);
            
            #endregion

            #region Add Courses
          
                var courses = new List<Course>
                {
                    new Course
                    {
                        Title = "C# Basics",
                        AuthorID = 1,
                        FullPrice = 49,
                        Description = "Description for C# Basics",
                        Level = CourseLevel.Begineer,
                        Tags = new Collection<Tag>()
                        {
                            new Tag { Name = "c#" },
                            //tags["c#"]
                        }
                    },
                    new Course
                    {
                        Title = "C# Intermediate",
                        AuthorID = 1,
                        FullPrice = 49,
                        Description = "Description for C# Intermediate",
                        Level = CourseLevel.Intermediate,
                        Tags = new Collection<Tag>()
                        {
                            new Tag { Name = "c#" },
                            new Tag { Name = "oop" },
                            //tags["c#"],
                            //tags["oop"]
                        }
                    },
                    new Course
                    {
                        Title = "C# Advanced",
                        AuthorID = 1,
                        FullPrice = 69,
                        Description = "Description for C# Advanced",
                        Level = CourseLevel.Advanced,
                        Tags = new Collection<Tag>()
                        {
                            new Tag { Name = "c#" },
                            //tags["c#"]
                        }
                    },
                    new Course
                    {
                        Title = "Javascript: Understanding the Weird Parts",
                        AuthorID = 2,
                        FullPrice = 149,
                        Description = "Description for Javascript",
                        Level = CourseLevel.Intermediate,
                        Tags = new Collection<Tag>()
                        {
                            new Tag { Name = "javascript" },
                            //tags["javascript"]
                        }
                    },
                    new Course
                    {
                        Title = "Learn and Understand AngularJS",
                        AuthorID = 2,
                        FullPrice = 99,
                        Description = "Description for AngularJS",
                        Level = CourseLevel.Intermediate,
                        Tags = new Collection<Tag>()
                        {
                            new Tag { Name = "angularjs" },
                            //tags["angularjs"]
                        }
                    },
                    new Course
                    {
                        Id = 6,
                        Title = "Learn and Understand NodeJS",
                        AuthorID = 2,
                        FullPrice = 149,
                        Description = "Description for NodeJS",
                        Level = CourseLevel.Intermediate,
                        Tags = new Collection<Tag>()
                        {
                            new Tag { Name = "nodejs" },
                            //tags["nodejs"]
                        }
                    },
                    new Course
                    {
                        Title = "Programming for Complete Beginners",
                        AuthorID = 3,
                        FullPrice = 45,
                        Description = "Description for Programming for Beginners",
                        Level = CourseLevel.Begineer,
                        Tags = new Collection<Tag>()
                        {
                            new Tag { Name = "c#" },
                            //tags["c#"]
                        }
                    },
                    new Course
                    {
                        Title = "A 16 Hour C# Course with Visual Studio 2013",
                        AuthorID = 4,
                        FullPrice = 150,
                        Description = "Description 16 Hour Course",
                        Level = CourseLevel.Begineer,
                        Tags = new Collection<Tag>()
                        {
                            new Tag { Name = "c#" },
                            //tags["c#"]
                        }
                    },
                    new Course
                    {
                        Title = "Learn JavaScript Through Visual Studio 2013",
                        AuthorID = 4,
                        FullPrice = 20,
                        Description = "Description Learn Javascript",
                        Level = CourseLevel.Begineer,
                        Tags = new Collection<Tag>()
                        {
                            new Tag { Name = "javascript" },
                            //tags["javascript"]
                        }
                    }
                };

                foreach (var course in courses)
                    context.Courses.AddOrUpdate(c => c.Id, course);
            
                
            #endregion
        }

    }
}

