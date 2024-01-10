using DAL.Data;
using DAL.Interface;
using Microsoft.AspNetCore.Mvc;
using Models.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserData _user;

        public UserController(UserData user)
        {
            _user = user;
        }
        // GET: api/<UserController>
        [HttpGet]
        [Route("/userget")]
        public async Task<ActionResult<List<User>>> Get()
        {
            var res = await _user.getAllUsers();
            if (res.Count == 0)
                return Ok(res);
            return BadRequest();
        }

        // GET api/<UserController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<UserController>
        [HttpPost]
        [Route("/userpost")]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<UserController>/5
        [HttpPut]
        [Route("/userput{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete]
        [Route("/deleteput{id}")]
        public void Delete(int id)
        {
        }
    }
}
