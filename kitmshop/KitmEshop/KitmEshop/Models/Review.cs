using System;
using System.ComponentModel.DataAnnotations;

namespace KitmEshop.Models
{
    public class Review
    {
        [Key]
        public Guid Id { get; set; }
        public string AuthorName { get; set; }
        public string ReviewText { get; set; }
        public int StarRating { get; set; }
        public DateTime ReviewCreated { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}


