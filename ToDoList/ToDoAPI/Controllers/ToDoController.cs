using Microsoft.AspNetCore.Mvc;
using ToDoListModel.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        // GET: api/<ToDoController>
        [HttpGet]
        public List<ToDoTask> Get()
        {
            List<ToDoTask> tasks = ToDoTask.ReadAll();
            return tasks;
        }

        // GET api/<ToDoController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            ToDoTask task = ToDoTask.Read(id);
            if (task == null)
            {
                return NotFound();
            }
            return Ok(task);
        }

        // POST api/<ToDoController>
        [HttpPost]
        public void Post([FromBody] ToDoTask task)
        {
            task.Create();
        }

        // PUT api/<ToDoController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] ToDoTask task)
        {

        }

        // DELETE api/<ToDoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
