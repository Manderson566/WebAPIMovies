﻿

using System.Collections;
using System.Collections.Generic;

namespace WebAPIMovies.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
    
}