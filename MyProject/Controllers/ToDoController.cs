using Microsoft.AspNetCore.Mvc;
using Models.Models;
using DAL.Interface;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly IToDo _toDo;
        public ToDoController(IToDo toDo)
        {
            _toDo = toDo;
        }
        // GET: api/<ToDoController>
        [HttpGet]
        [Route("/todoget")]
        public async Task<ActionResult<List<ToDo>>> Get()
        {
            var res = await _toDo.getAllToDo();
            if (res.Count == 0)
                return Ok(res);
            return BadRequest();
        }

        //// GET api/<ToDoController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<ToDoController>
        [HttpPost]
        [Route("/todopost")]
        public void Post([FromBody] string value)
        {
        
           
        }

        // PUT api/<ToDoController>/5
        [HttpPut]
        [Route("/todoput{id}")]
        public void Put(int id, [FromBody] string value)
        {
           
        }

        // DELETE api/<ToDoController>/5
        [HttpDelete]
        [Route("/tododelete{id}")]
        public void Delete(int id)
        {
           
        }
    }
}
