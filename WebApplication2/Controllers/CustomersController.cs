using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication2.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase {

        private readonly customerdbContext _context;
        public CustomersController(customerdbContext context) {
            _context = context;
        }

        // GET: api/<CustomersController>
        [HttpGet]
        public IActionResult Get() {
            try {
                var customers = _context.Customers.ToList();
                return Ok(customers);
            } catch (Exception ex) {
                return StatusCode(500, "An error occurred: " + ex.Message);
            }
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public string Get(int id) {
            return "value";
        }

        // POST api/<CustomersController>
        [HttpPost]
        public void Post([FromBody] string value) {
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) {
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id) {
        }
    }
}
