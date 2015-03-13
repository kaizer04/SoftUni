namespace StudentSystem.ConsoleClient
{
    using System;
    using System.Linq;
    using System.Data.Entity;

    using StudentSystem.Data;
    using StudentSystem.Model;
    using StudentSystem.Data.Migrations;
    
    public class StudentSystemConsoleClient
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<StudentSystemDbContext, Configuration>());
            var db = new StudentSystemDbContext();

            //var student = new Student
            //{
            //    Name = "Pesho Goshov",
            //    PhoneNumber = "00359888676767",
            //    Birthday = new DateTime(1980, 1, 1),
            //    RegistrationDate = new DateTime(2015, 2, 1)
            //};

            //db.Students.Add(student);
            //db.SaveChanges();

            //var savedStudent = db.Students.First();

            //Console.WriteLine(savedStudent.Id + ": " + savedStudent.Name);

            //Add new student

            db.Students.Add(new Student
            {
                Name = "Nakov",
                Birthday = new DateTime(1980, 1, 1),
                RegistrationDate = new DateTime(2015, 2, 1)
            });

            // Add new resource
            var resource1 = new Resource
            {
                Name = "Nakov video",
                TypeOfResource = TypeOfResource.Video,
                Link = "www.youtube.com"
            };

            var resource2 = new Resource
            {
                Name = "Link",
                Link = "www.dir.bg",
                TypeOfResource = TypeOfResource.Other,
            };

            db.Resources.Add(resource1);
            db.Resources.Add(resource2);

            // Add new courses
            var course1 = new Course
            {
                Name = "C# Intro",
                Description = "C# the best",
                StartDate = new DateTime(2014, 1, 1),
                EndDate = new DateTime(2014, 1, 30),
                Price = 180
            };
            var course2 = new Course
            {
                Name = "Seminar 1",
                Description = "jgds gldsldjf dgj dgf g ",
                StartDate = new DateTime(2015, 2, 1),
                EndDate = new DateTime(2015, 2, 25),
                Price = 0
            };

            course1.Resources.Add(resource1);
            course2.Resources.Add(resource2);
            db.Courses.Add(course1);
            db.Courses.Add(course2);
            db.SaveChanges();
            // Lists all students and their homework submissions
            Console.WriteLine(" * Lists all students and their homework submissions");
            var students = db.Students
            .Include(s => s.Homeworks)
            .Select(s => new
            {
                s.Name,
                s.Homeworks
            });
            foreach (var student in students)
            {
                Console.WriteLine(student.Name);
                var homeworks = student.Homeworks;
                if (homeworks.Count == 0)
                {
                    Console.WriteLine(" no homeworks");
                }
                else
                {
                    foreach (var homework in homeworks)
                    {
                        Console.WriteLine(" - " + homework.DateTime);
                    }
                }
            }
            Console.WriteLine();
            // List all course and their resources
            Console.WriteLine(" * List all course and their resources");
            var courses = db.Courses
            .Include(c => c.Resources)
            .Select(c => new
            {
                c.Name,
                c.Resources
            });
            foreach (var course in courses)
            {
                Console.WriteLine(course.Name);
                var resourses = course.Resources;
                if (resourses.Count == 0)
                {
                    Console.WriteLine(" no resourses");
                }
                else
                {
                    foreach (var resourse in resourses)
                    {
                        Console.WriteLine(" {0}; {1}", resourse.Name, resourse.Link);
                    }
                }
            }

        }
    }
}
