﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace DataAccess
{
    public class EshopContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public EshopContext(DbContextOptions<EshopContext> options) : base(options)
        {
        }
    }
}
