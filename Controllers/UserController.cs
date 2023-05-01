using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<UsersModel> Get()
        {
            List<UsersModel> usersModel = new List<UsersModel>();
            usersModel.Add(new UsersModel() { Id = 1, Name = "Acir", Email = "acir@acir.com" });
            return usersModel;
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public UsersModel Get(int id)
        {
            UsersModel usersModel = new UsersModel() { Id = 1, Name = "Acir", Email = "acir@acir.com" };
            return usersModel;
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] UsersModel user)
        {
            
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] UsersModel user)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
