namespace News.Data
{
    using System.Data.Entity;

    using News.Model;

    public class NewsDbContext : DbContext
    {
        public NewsDbContext()
            : base("NewsDB")
        { 
        }

        public IDbSet<News> News { get; set; }  
    }


}
