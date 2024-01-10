using DAL.Interface;
using Microsoft.AspNetCore.Mvc;
using Models.Models;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPost _post;
        public PostController(IPost post)
        {
            _post = post;
        }
        // GET: api/<PostController>
        [HttpGet]
        [Route("/postget")]
        public async Task<ActionResult<List<Post>>> Get()
        {
            var res = await _post.getAllPosts();
            if (res.Count == 0)
                return Ok(res);
            return BadRequest();
        }

        // GET api/<PostController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<PostController>
        [HttpPost]
        [Route("/post-post")]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PostController>/5
        [HttpPut]
        [Route("/post-put{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PostController>/5
        [HttpDelete]
        [Route("/post-delete{id}")]
        public void Delete(int id)
        {
        }
    }
}
