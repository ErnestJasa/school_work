using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitmEshop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private EshopContext _db;
        public ProductsController(EshopContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _db.Products.Include(r => r.Reviews).ToList();
            return Ok(result);
        }
    }
}
