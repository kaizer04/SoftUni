namespace SportSystem.Data
{
    using System.Text.RegularExpressions;

    using SportSystem.Data.Repositories;
    using SportSystem.Models;

    public interface ISportSystemData
    {
        IRepository<User> Users { get; }

        IRepository<Bet> Bets { get; }
        
        IRepository<SportSystem.Models.Match> Matches { get; }

        IRepository<Comment> Comments { get; }

        IRepository<Player> Players { get; }

        IRepository<Team> Teams { get; }

        IRepository<Vote> Votes { get; }

        int SaveChanges();
    }
}
