namespace LinkedIn.Web.ViewModels
{
    using LinkedIn.Models;
    using System.Collections.Generic;

    public class UserViewModel
    {
        public string UserName { get; set; }

        public string Email { get; set; }

        public string FullName { get; set; }

        public string AvatarUrl { get; set; }

        public string Summary { get; set; }

        public ContactInfo ContactInfo { get; set; }

        public IEnumerable<CertificationViewModel> Certifications { get; set; }
    }
}