namespace Bookmarks.Web.InputModels
{
    using Bookmarks.Common;
    using Bookmarks.Common.Mappings;
    using Bookmarks.Models;
    using System.ComponentModel.DataAnnotations;

    public class BookmarkInputModel : IMapTo<Bookmark>
    {
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = GlobalConstants.RequiredValidationMessage)]
        [StringLength(200)]
        public string Title { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = GlobalConstants.RequiredValidationMessage)]
        [StringLength(200, ErrorMessage = GlobalConstants.StringLengthValidationMessage)]
        [Url(ErrorMessage = "The {0} is invalid!")]
        public string Url { get; set; }

        public string Description { get; set; }

        [Display(Name = "Category")]
        public int CategoryId { get; set; }
    }
}