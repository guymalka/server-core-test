using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class CarController : ControllerBase
    {

        private ICarRepository _carRepository;
        public CarController(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        // GET: api/<CarController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CarController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// create new car
        /// </summary>
        /// <param name="value"></param>
        // POST api/<CarController>
        [HttpPost]
        public void Post([FromBody] Car value)
        {
            _carRepository.Add(value);
        }

        /// <summary>
        /// update new car
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        // PUT api/<CarController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Car value)
        {
            _carRepository.Update(value);
        }


        /// <summary>
        /// remove car by id
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/<CarController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _carRepository.Remove(id);
        }
    }
}
