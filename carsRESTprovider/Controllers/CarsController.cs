using System.Collections.Generic;
using System.Linq;
using carsRESTprovider.model;
using Microsoft.AspNetCore.Mvc;

namespace carsRESTprovider.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private static readonly List<Car> Cars = new List<Car>
        {
            new Car {Id=1, Model = "Amazon", Vendor = "Volvo", Price = 12345},
            new Car {Id=2, Model = "A8", Vendor = "Audi", Price = 2222222},
            new Car {Id=3, Model = "Punto", Vendor = "Fiat", Price = 102022}
        };

        private static int _nextId = 4;

        // GET: api/Cars
        [HttpGet]
        public IEnumerable<Car> GetAll()
        {
            return Cars;
        }

        // GET: api/Cars/5
        [HttpGet]
        [Route("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(204)] // no content
        public ActionResult<Car> GetById(int id)
        {
            Car car = Cars.FirstOrDefault(c => c.Id == id);
            if (car == null) return NoContent();
            else return car;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(204)] // no content
        [Route("vendor/{vendor}")]
        public List<Car> GetByVendor(string vendor)
        {
            return Cars.FindAll(car => car.Vendor.StartsWith(vendor));
        }

        [HttpGet]
        [Route("model/{model}")]
        public IEnumerable<Car> GetBymodel(string model)
        {
            return Cars.FindAll(car => car.Model.StartsWith(model));
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(204)] // no content
        [ProducesResponseType(400)]
        [Route("price/{fromPrice:int}/{toPrice:int}")]
        public ActionResult<IEnumerable<Car>> GetByPriceRange(int fromPrice, int toPrice)
        {
            if (fromPrice > toPrice) return BadRequest();

            List<Car> cars =  Cars.FindAll(car => fromPrice <= car.Price && car.Price <= toPrice);
            if (cars.Count == 0) return NoContent();
            return cars;
        }

        // POST: api/Cars
        [HttpPost]
        public int Post([FromBody] Car car)
        {
            car.Id = _nextId++;
            Cars.Add(car);
            return car.Id;
        }

        // PUT: api/Cars/5
        [HttpPut("{id}")]
        public ActionResult<Car> Put(int id, [FromBody] Car car)
        {
            Car c = Cars.FirstOrDefault(c1 => c1.Id == id);
            if (c == null) { return NoContent(); }
            c.Vendor = car.Vendor;
            c.Model = car.Model;
            c.Price = car.Price;
            return c;
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public int Delete(int id)
        {
            return Cars.RemoveAll(car => car.Id == id);
        }
    }
}
