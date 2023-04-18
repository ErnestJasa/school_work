using DataAccessLayer;
using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalServices 
{
    public class ProductsServices : IProductsService
    {
        private readonly EshopContext _db;
        public ProductsServices(EshopContext db)
        {
            _db = db;
        }

        public Product GetProductById(Guid id)
        {
           return _db.Products.FirstOrDefault(i=>i.Id == id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return _db.Products.Include(x=>x.Reviews);
        }
    }
}
