﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5_McKennaTrussel_BookStore.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string AuthorFirstName { get; set; }
        public string AuthorMiddleName { get; set; }
        [Required]
        public string AuthorLastName { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Classification { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public decimal Price { get; set; }


    }
}
