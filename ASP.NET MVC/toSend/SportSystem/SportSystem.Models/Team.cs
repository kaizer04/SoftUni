namespace SportSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
   
    public class Team
    {
        private ICollection<Player> players;
        private ICollection<Match> matches;
        private ICollection<Vote> votes;

        public Team()
        {
            this.players = new HashSet<Player>();
            this.matches = new HashSet<Match>();
            this.votes = new HashSet<Vote>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string NickName { get; set; }

        public string WebSite { get; set; }

        public DateTime?  DateFounded { get; set; }

        public virtual ICollection<Player> Players
        {
            get { return this.players; }
            set { this.players = value; }
        }

        public virtual ICollection<Match> Matches
        {
            get { return this.matches; }
            set { this.matches = value; }
        }

        public virtual ICollection<Vote> Votes
        {
            get { return this.votes; }
            set { this.votes = value; }
        }
    }
}
