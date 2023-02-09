using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.DAL.Context;
using Server.DAL.DAOs;
using Server.Models;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly AppDbContext context;
        private readonly TaskDao taskDao;

        public TasksController(AppDbContext context)
        {
            this.context = context;
            taskDao = new TaskDao(context);
        }

        // GET: api/Tasks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaskModel>>> GetTasks()
        {
            return Ok(await taskDao.GetAll());
        }

        // GET: api/Tasks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TaskModel>> GetTask(int id)
        {
            var taskModel = await taskDao.GetById(id);

            if (taskModel == null)
            {
                return NotFound();
            }

            return taskModel;
        }

        // PUT: api/Tasks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTaskModel(int id, TaskModel taskModel)
        {
            if (id != taskModel.Id)
            {
                return BadRequest();
            }

            context.Entry(taskModel).State = EntityState.Modified;

            try
            {
                await taskDao.Update(taskModel);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!taskDao.TaskExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Tasks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TaskModel>> PostTaskModel(TaskModel taskModel)
        {
            await taskDao.Create(taskModel);

            return CreatedAtAction("GetTaskModel", new { id = taskModel.Id }, taskModel);
        }

        // DELETE: api/Tasks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTaskModel(int id)
        {
            var taskModel = await taskDao.GetById(id);
            if (taskModel == null)
            {
                return NotFound();
            }

            await taskDao.Delete(taskModel);

            return NoContent();
        }
    }
}
