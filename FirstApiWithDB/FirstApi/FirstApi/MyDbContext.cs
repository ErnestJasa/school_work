using FirstApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstApi
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) :base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }
    }
}