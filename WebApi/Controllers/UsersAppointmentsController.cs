using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UsersAppointmentsController : ControllerBase
    {
        public Appointments _appointments;  
        public UsersAppointmentsController()
        {
            _appointments = Appointments.Instance;
        }
        // GET: api/<UsersAppointmentsController>
        [HttpGet]
        public List<AppointmentTimeFrame> Get()
        {
            return   _appointments.appointments  ;
            //return new string[] { "value1", "value2" };
        }

        // GET api/<UsersAppointmentsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsersAppointmentsController>
        [HttpPost]
        public void Post([FromBody] usertime value)
        {
            if (value.end <= value.start)
                throw new ArgumentException("not valid input");

            var frameItems = _appointments.appointments.Where(m => m.start == value.start);
            foreach (var item in frameItems)
            {
                if (value.end <= item.end)
                item.names.Add(value.username);
            }

        }

        // PUT api/<UsersAppointmentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersAppointmentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
