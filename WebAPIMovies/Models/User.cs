﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPIMovies.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Profession { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }
}