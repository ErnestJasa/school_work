using FirstApi.Dto;
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
            new Car() {Make = "Opel", Model = "Ascona"},
            new Car() {Make = "Ferrari", Model = "F10"},
            new Car() {Make = "BMW", Model = "5"}
        };

        private readonly MyDbContext _db;
        public KitmController(MyDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_db.Cars);
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
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
        public IActionResult Post([FromBody]CarDto car)
        {
            if (!string.IsNullOrEmpty(car.Make) && !string.IsNullOrEmpty(car.Model))
            {
                
                if(_cars.Any(c=> c.Make == car.Make && c.Model == car.Model))              
                    return new StatusCodeResult((int)StatusCodes.Status409Conflict);          
                
            Car newCar = new Car()
            {
                Model = car.Model,
                Make = car.Make
            };
            _db.Cars.Add(newCar);
                _db.SaveChanges();
            return Ok(newCar);
                
               
                //foreach (var c in _cars)
                //{
                //    if(c.Make != car.Make && c.Model != car.Model)                        //  Tas pats kas auksciau, tik ilga versija
                //    {
                //        Car newCar = new Car()
                //        {
                //            Model = car.Model,
                //            Make = car.Make
                //        };
                //        _cars.Add(newCar);
                //        return Ok(newCar);
                //    }
                //    else
                //    {
                //        return new StatusCodeResult((int)StatusCodes.Status409Conflict);
                //    } 
                //}                 
            }
            return BadRequest();            
        }
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] CarDto model)
        {
            if(!_cars.Any(c=>c.Id == id))
            {
                return NotFound();
            }
            if (!string.IsNullOrEmpty(model.Make) && !string.IsNullOrEmpty(model.Model))
            {
                var editCar = _cars.First(c => c.Id == id);
                editCar.Make = model.Make;
                editCar.Model = model.Model;
                return Accepted(editCar);
            }
            return BadRequest();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            if(!_cars.Any(c=> c.Id == id))
            {
                return NotFound();
            }
            else
            {
                var carToDelete = _cars.First(c => c.Id == id);
                _cars.Remove(carToDelete);
                return new StatusCodeResult((int)StatusCodes.Status204NoContent);
            }
        }

        //public IActionResult Get(string id)
        //{
        //    string[] myStrings = new string[] { "test", "test2" };
        //    return Ok(myStrings);
        //}

    }
}
