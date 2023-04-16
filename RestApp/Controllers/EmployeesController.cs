using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        // GET: api/<EmployeesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<EmployeesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "This is the get call for id: "+id;
        }

        // POST api/<EmployeesController>
        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            if (employee != null)
            {
                employee.Id += 2;
            }
            return Ok(employee);
        }

        // PUT api/<EmployeesController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] string value)
        {
            return "This is the put call and your input is :" + value;
        }

        // DELETE api/<EmployeesController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "This is the delete call and your id is :" + id;
        }
    }
}
