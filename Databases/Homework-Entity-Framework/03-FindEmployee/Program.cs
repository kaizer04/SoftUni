namespace FindEmployee
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Homework_Entity_Framework;
    
    public class Program
    {
        static void Main()
        {
            //FindEmployeeWithStartDateProject(2002);
            //FindEmployeeWithStartDateProjectBySQL();
            FindEmployeesByDepartmentAndManager("Finance", "Roberto", "Tamburello");
        }

        public static void FindEmployeeWithStartDateProject(int startYear)
        {
            var db = new SoftUniEntities();
            using (db)
            {
                var findEmployees = db.Employees
                                    .Where(
                                    e => e.Projects
                                        .Any(p => p.StartDate.Year == startYear)
                                    );

                foreach (var employee in findEmployees)
                {
                    Console.WriteLine(employee.FirstName + " " + employee.LastName);
                }
            }
        }

        public static void FindEmployeeWithStartDateProjectBySQL()
        {
            var db = new SoftUniEntities();
            using (db)
            {
                var query = @"SELECT DISTINCT CONCAT(e.FirstName + ' ', e.LastName)
                            FROM Employees e
	                            JOIN EmployeesProjects ep
		                            ON e.EmployeeID = ep.EmployeeId
	                            JOIN Projects p
		                            ON ep.ProjectId = p.ProjectID
                            WHERE YEAR(p.StartDate) = 2002";

                var results = db.Database.SqlQuery<string>(query);

                foreach (var employee in results)
                {
                    Console.WriteLine(employee);
                }
            }
        }

        public static void FindEmployeesByDepartmentAndManager(string departmentName, string firstName, string lastName)
        {
            var db = new SoftUniEntities();
            using (db)
            { 
                var managerId = SearchEmployeeIdByFirstAndLastName(firstName, lastName);

                var findEmployees = db.Employees
                                    .Where(
                                        e => e.Department.Name == departmentName 
                                                && e.Department.ManagerID == managerId
                                    );

                foreach (var employee in findEmployees)
                {
                    Console.WriteLine(employee.FirstName + " " + employee.LastName);
                }
            }
        }

        private static int SearchEmployeeIdByFirstAndLastName(string firstName, string lastName)
        {
            var db = new SoftUniEntities();
            using (db)
            {
                var searchEmployee = db.Employees
                                        .Where(e => e.FirstName == firstName && e.LastName == lastName)
                                        .FirstOrDefault();

                return searchEmployee.EmployeeID;
            }

        }
    }
}
