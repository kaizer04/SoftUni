namespace SportSystem.Web.ViewModels
{
    using System;
    using System.Linq;
    using SportSystem.Common.Mappings;
    using SportSystem.Models;

    public class MatchViewModel : IMapFrom<Match>
    {
        public int Id { get; set; }

        public string HomeTeamName { get; set; }

        public string AwayTeamName { get; set; }

        public string DateTime { get; set; }

        //public decimal Bet { get; set; }

        //public void CreateMappings(AutoMapper.IConfiguration configuration)
        //{
        //    configuration.CreateMap<Match, MatchViewModel>()
        //        .ForMember(x => x.Bet, cnf => cnf.MapFrom(m => m.Bets.Any() ? m.Bets.Sum(s => s.AwayBet + s.HomeBet) : 0));
        //}
    }
}