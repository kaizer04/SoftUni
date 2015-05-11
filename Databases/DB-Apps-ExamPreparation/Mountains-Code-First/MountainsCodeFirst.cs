using Mountains_Code_First.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mountains_Code_First
{
    public class MountainsCodeFirst
    {
        static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MountainsContext, MountainsDatabaseMigrationConfiguration>());

            var context = new MountainsContext();
            var query = context.Mountains.Select(m => new 
            {
                m.Name,
                Countries = m.Countries.Select(c => c.Name),
                Peaks = m.Peaks.Select(p => p.Name)    
            });
            foreach (var m in query)
            {
                Console.WriteLine("{0} ; {1} ; {2}", m.Name, String.Join(", ", m.Countries), String.Join(", ", m.Peaks));
            }
        }
    }
}
