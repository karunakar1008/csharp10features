using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase, IAsyncDisposable
    {
        private Utf8JsonWriter? _jsonWriter;
        private readonly ILogger<EmployeesController> _logger;

        public EmployeesController(ILogger<EmployeesController> logger)
        {
            _logger = logger;
            _jsonWriter = new Utf8JsonWriter(new MemoryStream());
        }

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

        public async ValueTask DisposeAsync()
        {
            if (_jsonWriter is not null)
            {
                await _jsonWriter.DisposeAsync();
            }

            _jsonWriter = null;
        }
    }
}
