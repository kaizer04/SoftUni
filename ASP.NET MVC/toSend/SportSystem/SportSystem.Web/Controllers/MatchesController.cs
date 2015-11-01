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
    using Microsoft.AspNet.Identity;

    using PagedList;
    using AutoMapper;
    using SportSystem.Web.InputModels;
    using SportSystem.Models;

    [Authorize]
    public class MatchesController : BaseController
    {
        public MatchesController(ISportSystemData data)
            : base(data)
        {

        }

        [AllowAnonymous]
        public ActionResult Index(int? page)
        {
            var matches = this.Data.Matches
                .All()
                .OrderByDescending(x => x.DateTime)
                .Project()
                .To<MatchViewModel>()
                .ToPagedList(page ?? GlobalConstants.DefaultStartPage, GlobalConstants.DefaultPageSize);

            return this.View(matches);
        }


        // GET: Matches
        public ActionResult Details(int id)
        {
            var match = this.Data.Matches
                .All()
                .Where(x => x.Id == id)
                .Project()
                .To<MatchDetailsViewModel>()
                .FirstOrDefault();


            //var matchViewModel = Mapper.Map<MatchDetailsViewModel>(match);

            //var userId = this.User.Identity.GetUserId();
            //matchViewModel.UserHasVoted = bookmark.Votes.Any(x => x.UserId == userId);

            return this.View(match);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddComment(CommentInputModel model)
        {
            if (model != null && this.ModelState.IsValid)
            {
                model.UserId = this.User.Identity.GetUserId();
                var comment = Mapper.Map<Comment>(model);
                this.Data.Comments.Add(comment);
                this.Data.SaveChanges();

                var commentDb = this.Data.Comments
                    .All()
                    .Where(x => x.Id == comment.Id)
                    .Project()
                    .To<CommentViewModel>()
                    .FirstOrDefault();

                return this.PartialView("DisplayTemplates/CommentViewModel", commentDb);
            }

            return this.Json("Error");
        }
    }
}