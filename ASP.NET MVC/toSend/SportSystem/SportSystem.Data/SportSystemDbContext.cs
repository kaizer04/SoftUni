namespace SportSystem.Data
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using SportSystem.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.Entity;
    using SportSystem.Data.Migrations;

    public class SportSystemDbContext : IdentityDbContext<User>, ISportSystemDbContext
    {
        public SportSystemDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SportSystemDbContext, Configuration>());
        }

        public static SportSystemDbContext Create()
        {
            return new SportSystemDbContext();
        }

        public IDbSet<Bet> Bets { get; set; }

        public IDbSet<Comment> Comments { get; set; }

        public IDbSet<Match> Matches { get; set; }

        public IDbSet<Player> Players { get; set; }

        public IDbSet<Team> Teams { get; set; }

        public IDbSet<Vote> Votes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Match>()
            //    .HasRequired(x => x.AwayTeam)
            //    .WithOptional()
            //    .WillCascadeOnDelete(false);
            modelBuilder.Entity<Match>()
                .HasRequired(x => x.AwayTeam)
                .WithMany(x => x.Matches)
                .WillCascadeOnDelete(false);
            //modelBuilder.Entity<Match>()
            //    .HasRequired(x => x.HomeTeam)
            //    .WithMany(x => x.Matches)
            //    .WillCascadeOnDelete(true);

            base.OnModelCreating(modelBuilder);
        }
    }
}
