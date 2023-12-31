﻿using System.ComponentModel.DataAnnotations;

namespace ApiBook.Models
{
    public class Book
    {
        [Key]
        public int IdBook { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public int IdCategory { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public string? ImageUrl { get; set; }
    }
}
