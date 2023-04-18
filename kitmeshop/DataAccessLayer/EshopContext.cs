using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using VisioForge.Libs.MediaFoundation.OPM;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace DataAccessLayer
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



