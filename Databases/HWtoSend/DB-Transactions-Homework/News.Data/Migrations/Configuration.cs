namespace News.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<News.Data.NewsDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
            ContextKey = "News.Data.NewsDbContext";
        }

        protected override void Seed(NewsDbContext context)
        {
            this.SeedNews(context);
        }

        private void SeedNews(NewsDbContext context)
        {
            throw new NotImplementedException();
        }
    }
}
