using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KitmEshop.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public ProductCategory Category { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public List<Review> Reviews { get; set; }

    }
}
