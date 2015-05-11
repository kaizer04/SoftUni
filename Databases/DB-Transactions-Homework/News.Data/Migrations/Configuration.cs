namespace News.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    using News.Model;

    public sealed class Configuration : DbMigrationsConfiguration<NewsDbContext>
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
            if (context.News.Any())
            {
                return;
            }

            var news = new List<News>
            {
                new News
                {
                    Content = @"Problem 1. News Database (Code First)"
                },
                new News
                {
                    Content = "Problem 2. Updates (Console App)"
                },
                new News
                {
                    Content = "Problem 3. * Concurrent Updates (GUI App)"
                },
                new News
                {
                    Content = "Problem 4. ATM Database"
                },
                new News
                {
                    Content = "Problem 5. Transactional ATM Withdrawal"
                }
            };

            foreach (var item in news)
            {
                context.News.Add(item);
            }
            
        }
    }
}
