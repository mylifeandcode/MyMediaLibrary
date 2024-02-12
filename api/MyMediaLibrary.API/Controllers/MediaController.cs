using Microsoft.AspNetCore.Mvc;
using MyMediaLibrary.Domain.Media;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyMediaLibrary.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaController : ControllerBase
    {
        // GET: api/<MediaController>
        [HttpGet]
        public IEnumerable<Medium> Get()
        {
            throw new NotImplementedException();
        }

        // GET api/<MediaController>/GUID
        [HttpGet("{id}")]
        public string Get(Guid id)
        {
            throw new NotImplementedException();
        }

        // POST api/<MediaController>
        [HttpPost]
        public void Post([FromBody] Medium value)
        {
        }

        // PUT api/<MediaController>/GUID
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Medium value)
        {
        }

        // DELETE api/<MediaController>/GUID
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
        }
    }
}
