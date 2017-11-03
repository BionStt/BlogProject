﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlogProject.Models
{
    public class Post
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage ="Max Title Length is 100 Characters"), MinLength(10, ErrorMessage = "Min Title Length is 10 Characters")]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime PublishedTime { get; set; }

        [Required]
        public User Author { get; set; }
    }
}