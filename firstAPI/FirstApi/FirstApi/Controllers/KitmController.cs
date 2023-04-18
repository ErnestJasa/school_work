using FirstApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KitmController : ControllerBase
    {
        private static IList<Car> _cars = new List<Car> {
            new Car() {Id =1, Make = "Opel", Model = "Ascona"},
            new Car() {Id =2, Make = "Ferrari", Model = "F10"},
            new Car() {Id =3, Make = "BMW", Model = "5"}
        };

        public IActionResult Get()
        {
            return Ok(_cars);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            foreach (var car in _cars)
            {
                if(car.Id == id)
                {
                    return Ok(car);
                }           //_cars.First(c=>c.Id == id)
            }
            return new StatusCodeResult((int)HttpStatusCode.NotFound);   
        }
        [HttpPost]
        public IActionResult Post([FromBody]Car car)
        {
            _cars.Add(car);
            return Ok();
        }
   
        //public IActionResult Get(string id)
        //{
        //    string[] myStrings = new string[] { "test", "test2" };
        //    return Ok(myStrings);
        //}

    }
}
