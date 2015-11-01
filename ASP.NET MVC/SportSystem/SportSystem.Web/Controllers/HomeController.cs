namespace SportSystem.Web.Controllers
{
    using SportSystem.Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using AutoMapper.QueryableExtensions;
    using SportSystem.Common;
    using SportSystem.Web.ViewModels;

    public class HomeController : BaseController
    {
        public HomeController(ISportSystemData data)
            : base(data)
        {
            
        } 

        public ActionResult Index()
        {
            
            //var bookmarks = this.Data.Bookmarks
            //    .All()
            //    .OrderByDescending(x => x.Votes.Count())
            //    .Take(GlobalConstants.HomePageNumberOfBookmarks)
            //    .Project()
            //    .To<BookmarkViewModel>();



            var matches = this.Data.Matches
                .All()
                .OrderByDescending(x => x.Bets.Sum(b => b.HomeBet + b.AwayBet))
                .Take(GlobalConstants.HomePageNumberOfMatches)
                .Project()
                .To<MatchViewModel>();

            return View(matches);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}