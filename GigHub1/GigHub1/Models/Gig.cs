using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GigHub1.Models
{
    public class Gig
    {
        public byte id { get; set; }

        [Required]
        public ApplicationUser Artiste { get; set; }

        public DateTime DateTime { get; set; }

        [Required]
        [StringLength(255)]
        public string  Venue { get; set; }      

        [Required]
        public Genre Genre { get; set; }


    }
}