namespace CreateDAO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CreateDbContext;
    using Homework_Entity_Framework;
    using System.Data.Entity;
    
    public class DAOCustomer
    {
        public static void AddEmployee(string firstName, string lastName, string jobTitle, int departmentID, 
                                        DateTime hireDate, decimal salary)
        {
            var db = new SoftUniEntities();
            using(db)
            {
                var newEmployee = new Employee()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    JobTitle = jobTitle,
                    DepartmentID = departmentID,
                    HireDate = hireDate,
                    Salary = salary
                };

                db.Employees.Add(newEmployee);
                db.SaveChanges();

                Console.WriteLine("{0} {1} recorded Successfully", firstName, lastName);
            }
        }

        public static void ModifyEmployee(string firstName, string lastName, decimal salary)
        {
            var db = new SoftUniEntities();
            using (db)
            {
                var modifyEmployee = SearchEmployeeByFirstAndLastName(firstName, lastName);
                db.Entry(modifyEmployee).State = EntityState.Modified;
                modifyEmployee.Salary = salary;
                db.SaveChanges();

                Console.WriteLine("Customer {0} {1} Modified Successfully", firstName, lastName);
            }
        }

        public static void DeleteEmployee(string firstName, string lastName)
        {
            var db = new SoftUniEntities();
            using (db)
            {
                var deleteEmployee = SearchEmployeeByFirstAndLastName(firstName, lastName);
                db.Entry(deleteEmployee).State = EntityState.Deleted;
                db.Employees.Remove(deleteEmployee);
                db.SaveChanges();

                Console.WriteLine("{0} {1} Deleted Successfully", firstName, lastName);
            }
        }

        private static Employee SearchEmployeeByFirstAndLastName(string firstName, string lastName)
        {
            var db = new SoftUniEntities();
            using (db)
            {
                var searchEmployee = db.Employees
                                        .Where(e => e.FirstName == firstName && e.LastName == lastName)
                                        .FirstOrDefault();

                return searchEmployee;
            }

        }

        
    }
}
