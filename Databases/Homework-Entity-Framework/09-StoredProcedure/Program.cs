namespace StoredProcedure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data;
    using System.Data.Entity;

    using Homework_Entity_Framework;

    public class Program
    {
        public static void Main()
        {
            FindProjectsByEmployee("Pavlova", "sadsa");
        }

        public static void FindProjectsByEmployee(string firstName, string lastName)
        {
            var db = new SoftUniEntities();

            var projects = db.usp_FindAllProjectsForEmployee(firstName, lastName).ToList();
            Console.WriteLine("Project names:");
            
            if (projects.Count != 0)
            {
                foreach (var project in projects)
                {
                    Console.WriteLine(project);
                }
            }
            else
            {
                Console.WriteLine("This employee either does not exists, either he has no projects");
            }
        }
    }
}
