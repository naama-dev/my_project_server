using DAL.Interface;
using Microsoft.AspNetCore.Mvc;
using Models.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhotoController : ControllerBase
    {
        private readonly IPhoto _photo;
        public PhotoController(IPhoto photo)
        {
            _photo = photo;
        }
        // GET: api/<PhotoController>
        [HttpGet]
        [Route("/photoget")]
        public async Task<ActionResult<List<Photo>>> Get()
        {
            var res = await _photo.getAllPhotos();
            if (res.Count == 0)
                return Ok(res);
            return BadRequest();
        }
        
  

        // GET api/<PhotoController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<PhotoController>
        [HttpPost]
        [Route("/photopost")]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PhotoController>/5
        [HttpPut]
        [Route("/photoput{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PhotoController>/5
        [HttpDelete]
        [Route("/photodelete{id}")]
        public void Delete(int id)
        {
        }
    }
}
