﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieRater.Models
{
    public class MovieCreate
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        [Required]
        public string MaturityRating { get; set; }
        public string Awards { get; set; }
        [Required]
        public string FamilyFriendly { get; set; }
        [Required]
        public string Educational { get; set; }
    }
}
