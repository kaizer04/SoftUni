namespace CreateDAO
{
    using Homework_Entity_Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            var db = new SoftUniEntities();
            using (db)
            {
                //DAOCustomer.AddEmployee("Ivan", "Stoyanov", "Cleaner", 2, DateTime.Now, 2000);

                //DAOCustomer.ModifyEmployee("Ivan", "Stoyanov", 6000);

                DAOCustomer.DeleteEmployee("Ivan", "Stoyanov");
            }
        }
    }
}
