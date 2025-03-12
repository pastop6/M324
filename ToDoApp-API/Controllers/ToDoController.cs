using Microsoft.AspNetCore.Mvc;

namespace ToDoApp_API.Controllers {
  [Route("api/[controller]")]
  [ApiController]
  public class ToDoController : ControllerBase {
    // GET: api/<ToDoController>
    [HttpGet]
    public ActionResult<string[]> GetToDos() {
      return Ok(ToDo_App_M324.Program.LoadTasks());
    }

    // GET api/<ToDoController>/5
    [HttpGet("{id}")]
    public string Get(int id) {
      return "value";
    }

    // POST api/<ToDoController>
    [HttpPost]
    public void Post([FromBody] string value) {
    }

    // PUT api/<ToDoController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value) {
    }

    // DELETE api/<ToDoController>/5
    [HttpDelete("{id}")]
    public void Delete(int id) {
    }
  }
}
