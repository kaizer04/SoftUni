namespace TaskOneProblem
{
    using Ads.Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.Entity;

    public class ShowData
    {
        public static void Main()
        {
            var db = new AdsEntities();
            using (db)
            {
                var ads = db.Ads;

                SlowWayShowData(ads);
                
                //FastWayShowData(ads);
            }
        }

        private static void FastWayShowData(DbSet<Ad> ads)
        {
            foreach (var ad in ads.Include("AdStatus").Include("Category").Include("Category").Include("Town").Include("AspNetUser"))
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}", ad.Title, ad.AdStatus.Status, ad.CategoryId, ad.TownId, ad.OwnerId);
            }
        }

        private static void SlowWayShowData(DbSet<Ad> ads)
        {
            foreach (var ad in ads)
            {
                Console.WriteLine("{0}, {1}, {2}, {3}, {4}", ad.Title, ad.AdStatus.Status, ad.Category, ad.TownId, ad.OwnerId);
            }
        }
    }
}
