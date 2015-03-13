namespace InsertProject
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Homework_Entity_Framework;

    public class Transactions
    {
        public static void Main()
        {
            int[] idEmployees = new int[]{4, 48};

            AddProject("The NEW project448", DateTime.Now, idEmployees);
        }

        public static Project AddProject(string projectName,
                                        DateTime startDate,
                                        int[] idEmployees)
        {
            var db = new SoftUniEntities();
            using (db)
            {
                using (var newProjectTransaction = db.Database.BeginTransaction())
                {
                    var addProject = new Project()
                    {
                        Name = projectName,
                        StartDate = startDate
                    };

                    for (int i = 0; i < idEmployees.Length; i++)
                    {
                        addProject.Employees = db.Employees.Where(e => e.EmployeeID == i).ToList();
                    }
                    

                    addProject = db.Projects.Add(addProject);

                    try
                    {
                        db.SaveChanges();
                        Console.WriteLine("Project added successfully");
                    }
                    catch (Exception)
                    {
                        newProjectTransaction.Rollback();
                    }

                    newProjectTransaction.Commit();

                    return addProject;
                }
            }
        }
    }
}
