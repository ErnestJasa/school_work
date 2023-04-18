using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalServices
{
   public interface IProductsService
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(Guid id);
    }
}
