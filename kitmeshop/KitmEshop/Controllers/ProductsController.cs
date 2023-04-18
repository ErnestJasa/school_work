using DataAccessLayer;
using InternalServices;
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
        private readonly IProductsService _service;
        public ProductsController(IProductsService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            //  var result = _db.Products.Include(r => r.Reviews).ToList();
            var result = _service.GetProducts();
            return Ok(result);
        }
    }
}
