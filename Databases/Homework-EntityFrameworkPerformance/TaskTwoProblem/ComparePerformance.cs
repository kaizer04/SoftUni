namespace TaskTwoProblem
{
    using Ads.Data;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Diagnostics;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ComparePerformance
    {
        public static void Main()
        {
            var db = new AdsEntities();
            using (db)
            {
                var ads = db.Ads;
                
                var timer = new Stopwatch();
                
                timer.Restart();
                SlowVersion(ads);
                Console.WriteLine("Elapsed time: {0}", timer.Elapsed);

                timer.Restart();
                FastVersion(ads);
                Console.WriteLine("Elapsed time: {0}", timer.Elapsed);

                timer.Stop();
            }
        }

        private static void FastVersion(DbSet<Ad> ads)
        {
            var publishedAds = ads.Where(a => a.AdStatus.Status == "Published")
                                .OrderBy(a => a.Date)
                                .Select(a => new
                                {
                                    a.Title,
                                    a.Category,
                                    a.Town
                                })
                                .ToList();
        }

        private static void SlowVersion(DbSet<Ad> ads)
        {
            var publishedAds = ads.ToList()
                                .Where(a => a.AdStatus.Status == "Published")
                                .Select(a => new
                                {
                                    a.Title,
                                    a.Category,
                                    a.Town,
                                    a.Date
                                })
                                .ToList()
                                .OrderBy(a => a.Date);
        }
    }
}
