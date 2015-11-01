namespace Bookmarks.Web.Controllers
{
    using Bookmarks.Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using AutoMapper.QueryableExtensions;
    using Bookmarks.Web.ViewModels;
    using Bookmarks.Common;
    using Bookmarks.Web.Infrastructure;

    public class HomeController : BaseController
    {
        private ICacheService cacheService;

        public HomeController(IBookmarksData data, ICacheService cacheService)
            : base(data)
        {
            this.cacheService = cacheService;
        }

        public ActionResult Index()
        {
            //var bookmarks = this.Data.Bookmarks
            //    .All()
            //    .OrderByDescending(x => x.Votes.Count())
            //    .Take(GlobalConstants.HomePageNumberOfBookmarks)
            //    .Project()
            //    .To<BookmarkViewModel>();
            var bookmarks = this.cacheService.Bookmarks;

            return this.View(bookmarks);
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