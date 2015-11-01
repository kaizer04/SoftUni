namespace LinkedIn.Web.Controllers
{
    using LinkedIn.Data;
    using System.Web.Mvc;
    using System.Linq;
    using LinkedIn.Web.ViewModels;

    public class UsersController : BaseController
    {
        public UsersController(ILinkedInData data) 
            : base(data)
        {
        }

        public ActionResult Index(string username)
        {
            var user = this.Data.Users
                .All()
                .FirstOrDefault(x => x.UserName == username);

            if (user == null)
            {
                return this.HttpNotFound("User does not exist!");
            }

            var userViewModel = new UserViewModel()
            {
                UserName = user.UserName,
                Email = user.Email,
                AvatarUrl = user.AvatarUrl,
                ContactInfo = user.ContactInfo,
                FullName = user.FullName,
                Summary = user.Summary
            };

            return this.View(userViewModel);
        }
    }
}