using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Mountains_Code_First
{
    public class Mountain
    {
        public Mountain()
        {
            this.Countries = new HashSet<Country>();
        }
        
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public virtual ICollection<Country> Countries { get; set; }

        public virtual ICollection<Peak> Peaks { get; set; }
    }
}
