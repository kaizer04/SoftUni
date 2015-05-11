namespace News.Data
{
    using System.Data.Entity;

    using News.Model;
    using News.Data.Migrations;

    public class NewsDbContext : DbContext
    {
        public NewsDbContext()
            : base("NewsDB")
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<NewsDbContext, Configuration>());
            //this.Database.Initialize(true);
        }

        public IDbSet<News> News { get; set; }  
    }


}
