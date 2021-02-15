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
    public class CarRentController : ControllerBase
    {
        private ICarRentRepository _rentRepository;
        public CarRentController(ICarRentRepository rentRepository)
        {
            _rentRepository = rentRepository;
        }
        // GET: api/<CarRentController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CarRentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<CarRentController>
        [HttpPost]
        public void Post([FromBody] CarRental value)
        {
            _rentRepository.Add(value);
        }

        // PUT api/<CarRentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] CarRental value)
        {
            _rentRepository.Update(value);
        }

        // DELETE api/<CarRentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _rentRepository.Remove(id);
        }
    }
}
