﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment___12.Models
{
    public class Post
    {
        public int Id { get; set; } 
        public string Title { get; set; } 
        public string Content { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Author { get; set; }
         
    }
}