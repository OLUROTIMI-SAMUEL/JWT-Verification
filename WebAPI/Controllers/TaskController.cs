using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        /*
        private readonly ITaskServices taskservice;

        public TaskController(ITaskServices taskservice)
        {
            this.taskservice = taskservice;
        }
        */
/*
        private readonly ITaskServices taskservice;

        public TaskController(ITaskServices taskservice)
        {
            this.taskservice = taskservice;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var tasks = await this.taskservice.GetAllAsync();
            return Ok(tasks);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var task = await this.taskservice.GetByIdAsync(id);
            if (task == null)
            {
                return NotFound();
            }
            return Ok(task);
        }

        [HttpPost]

        public async Task<IActionResult> Create(Tasks blog)
        {
            var createdTask = await this.taskservice.CreateAsync(blog);
            return CreatedAtAction(nameof(GetById), new { id = createdTask.Id }, createdTask);
        }

        [HttpPut("{id}")]

        public async Task<IActionResult> Update(int id, Tasks updatedTask)
        {
            int existingTask = await this.taskservice.UpdateAsync(id, updatedTask);
            if (existingTask == 0)
            {
                return BadRequest();
            }

            return NoContent();
        }

        [HttpDelete("id")]

        public async Task<IActionResult> Delete(int id)
        {
            int task = await this.taskservice.DeleteAsync(id);
            if(task == 0)
            {
                return BadRequest();
            }
            return NoContent();
        }

*/
    }
}
