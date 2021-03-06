﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPIMovies.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string ReviewText { get; set; }
        public int UserId { get; set; }

        public int MovieId { get; set; }
        [ForeignKey("MovieId")]
        public virtual Movie Movie { get; set; }


    }
}