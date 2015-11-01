namespace SportSystem.Web.ViewModels
{
    using System.Linq;
    using System.Collections.Generic;

    using SportSystem.Common.Mappings;
    using SportSystem.Models;
    using System.ComponentModel.DataAnnotations;

    public class MatchDetailsViewModel : IMapFrom<Match>
    {
        public int Id { get; set; }

        [Display(Name = "Home Team")]
        public string HomeTeamName { get; set; }

        [Display(Name = "Away Team")]
        public string AwayTeamName { get; set; }

        public string DateTime { get; set; }

        public IEnumerable<CommentViewModel> Comments { get; set; }

        //public decimal HomeBet { get; set; }

        //public decimal AwayBet { get; set; }

        //public void CreateMappings(AutoMapper.IConfiguration configuration)
        //{
        //    configuration.CreateMap<Match, MatchDetailsViewModel>()
        //        .ForMember(x => x.HomeBet, cnf => cnf.MapFrom(m => m.Bets.Any() ? m.Bets.Sum(b => b.HomeBet) : 0));

        //    configuration.CreateMap<Match, MatchDetailsViewModel>()
        //        .ForMember(x => x.AwayBet, cnf => cnf.MapFrom(m => m.Bets.Any() ? m.Bets.Sum(b => b.AwayBet) : 0));
        //}
    }
}