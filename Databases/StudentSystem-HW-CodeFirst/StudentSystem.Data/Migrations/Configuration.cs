namespace StudentSystem.Data.Migrations
{
    using StudentSystem.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<StudentSystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            this.ContextKey = "StudentSystem.Data.StudentSystemDbContext";
        }

        protected override void Seed(StudentSystemDbContext context)
        {
            if (context.Students.Any())
            {
                return;
            }

            context.Students.Add(new Student
            {
                Name = "Student1",
                PhoneNumber = "35988888888",
                Birthday = new DateTime(1968, 1, 1),
                RegistrationDate = new DateTime(2015, 1, 28)
            });

            context.Students.AddOrUpdate(new Student
            {
                Name = "Student2",
                PhoneNumber = "3592122222",
                Birthday = new DateTime(1952, 1, 28),
                RegistrationDate = new DateTime(2015, 2, 1)
            });

            //context.Students.AddOrUpdate(new Student
            //{
            //    Name = "Student3",
            //    PhoneNumber = "359456456",
            //    Birthday = new DateTime(1988, 1, 1),
            //    RegistrationDate = new DateTime(2014, 1, 2)
            //});

            //context.Students.AddOrUpdate(new Student
            //{
            //    Name = "Student4",
            //    PhoneNumber = "359789456",
            //    Birthday = new DateTime(1990, 1, 1),
            //    RegistrationDate = new DateTime(2015, 12, 3)
            //});
            
            //var resource1 = new Resource
            //{
            //    Name = "Resource 1",
            //    TypeOfResource = TypeOfResource.Video,
            //    Link = "www.youtube.com"
            //};

            //context.Resources.AddOrUpdate(resource1);
            //var resource2 = new Resource
            //{
            //    Name = "Resource 2",
            //    TypeOfResource = TypeOfResource.Document,
            //};

            //context.Resources.AddOrUpdate(resource2);

            //var course = new Course
            //{
            //    Name = "Course 1",
            //    Description = "jgds gldsldjf dgj dgf g ",
            //    StartDate = new DateTime(2014, 1, 1),
            //    EndDate = new DateTime(2014, 1, 30),
            //    Price = 100
            //};

            //course.Resources.Add(resource1);
            //course.Resources.Add(resource2);

            //context.Courses.AddOrUpdate(course);

            //course = new Course
            //{
            //    Name = "Course 2",
            //    Description = "The best course ever",
            //    StartDate = new DateTime(2015, 2, 1),
            //    EndDate = new DateTime(2015, 2, 25),
            //    Price = 200
            //};

            //context.Courses.AddOrUpdate();

            //course.Resources.Add(resource2);

            //context.Courses.AddOrUpdate(course);

            //context.SaveChanges();

            //var student = context.Students.Find(1);

            //var course1 = context.Courses.Find(1);

            //context.Homeworks.AddOrUpdate(new Homework
            //{
            //    Content = "Homework 1",
            //    Course = course1,
            //    Student = student,
            //    DateTime = new DateTime(2015, 3, 30, 23, 59, 59),
            //});

            //context.SaveChanges();
        }
    }
}
