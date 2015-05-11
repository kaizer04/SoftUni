namespace News.ConsoleClient
{
    using System;
    using System.Linq;
    using System.Data.Entity;

    using News.Data;
    using News.Model;
    using News.Data.Migrations;

    public class NewsConsoleClient
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<NewsDbContext, Configuration>());

            var db = new NewsDbContext();

            db.Database.Initialize(true);

            var news = new News
            {
                Content = "The best news are here"
            };

            db.News.Add(news);
            db.SaveChanges();

            var firstNews = db.News.FirstOrDefault();

            System.Console.WriteLine(firstNews.Content);
        }
    }
}
