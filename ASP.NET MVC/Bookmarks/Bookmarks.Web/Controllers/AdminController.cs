namespace Bookmarks.Web.Controllers
{
    using Bookmarks.Data;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Web.Mvc;

    [Authorize(Roles = "Admin")]
    public abstract class AdminController : BaseController
    {
        protected AdminController(IBookmarksData data) 
            : base(data)
        {

        }
    }
}
