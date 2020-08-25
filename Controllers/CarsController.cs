using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TestApi.Models;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController : ControllerBase
    {
        public static List<Car> CarsList = new List<Car>();

        [HttpGet]
        public ActionResult<List<Car>> Get() {
            return Ok(CarsList);
        }

        [HttpPost]
        public ActionResult AddCar([FromBody] Car newCar) {
            CarsList.Add(newCar);

            return Ok($"Car with Rego {newCar.Rego} added");
        }

    }
}