﻿namespace SportSystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Match
    {
        private ICollection<Comment> comments;
        private ICollection<Bet> bets;

        public Match()
        {
            this.comments = new HashSet<Comment>();
            this.bets = new HashSet<Bet>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public int HomeTeamId { get; set; }

        public Team HomeTeam { get; set; }

        [Required]
        public int AwayTeamId { get; set; }

        public Team AwayTeam { get; set; }

        [Required]
        public DateTime DateTime { get; set; }

        public virtual ICollection<Comment> Comments
        {
            get { return this.comments; }
            set { this.comments = value; }
        }

        public virtual ICollection<Bet> Bets
        {
            get { return this.bets; }
            set { this.bets = value; }
        }
    }
}
