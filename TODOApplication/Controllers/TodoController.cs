using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TODOApplication.Models;
using TODOApplication.Services;

namespace TODOApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : Controller
    {
        private readonly TodoService _todoService;

        public TodoController(TodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Json(await _todoService.Get());
        }

        [HttpPost]
        public async Task<IActionResult> Post(TaskTodo tasktodo)
        {
            return Json(await _todoService.Create(tasktodo));
        }

        [HttpPut]
        public async Task<IActionResult> Put(TaskTodo tasktodo)
        {
            //if id not specified return 404 bad request
            if(tasktodo.Id == 0)
            {
                return BadRequest();
            }

            return Json(await _todoService.Update(tasktodo));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                await _todoService.Delete(id.Value);

                return Ok();
            }

            //if id was not specified
            return NotFound();
        }
    }
}
