namespace Bookmarks.Web.Areas.Admin.ViewModels
{
    using Bookmarks.Common.Mappings;
    using Bookmarks.Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Web;

    public class CategoryAdminViewModel : IMapFrom<Category>, IMapTo<Category >
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}