namespace SportSystem.Web.InputModels
{
    using SportSystem.Common.Mappings;
    using SportSystem.Models;

    public class CommentInputModel : IMapTo<Comment>
    {
        public int MatchId { get; set; }

        public string Content { get; set; }

        public string UserId { get; set; }
    }
}