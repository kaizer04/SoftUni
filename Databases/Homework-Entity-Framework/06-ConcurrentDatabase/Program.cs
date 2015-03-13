namespace ConcurrentDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Homework_Entity_Framework;

    public class Program
    {
        public static void Main()
        {
            using (var dbFirst = new SoftUniEntities())
            {
                using (var dbSecond = new SoftUniEntities())
                {
                    dbFirst.Employees.Add(new Employee()
                                            {
                                                FirstName = "Stoy",
                                                LastName = "Cholakov",
                                                JobTitle = "Cleaner",
                                                DepartmentID = 3,
                                                HireDate = DateTime.Now,
                                                Salary = 3000
                                            });
                    dbSecond.Employees.Add(new Employee()
                                            {
                                                FirstName = "Gancho",
                                                LastName = "Ganchev",
                                                JobTitle = "Cleaner",
                                                DepartmentID = 3,
                                                HireDate = DateTime.Now,
                                                Salary = 3000
                                            });
                    dbSecond.SaveChanges();
                    dbFirst.SaveChanges();
                    dbSecond.SaveChanges();
                }
            }
        }
    }
}
