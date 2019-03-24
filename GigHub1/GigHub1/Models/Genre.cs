using System;
using System.ComponentModel.DataAnnotations;

namespace GigHub1.Models
{
    public class Genre
    {
        public byte GenreID { get; set; }

        [Required]
        [StringLength(255)]
        public String Name { get; set; }
    }
}