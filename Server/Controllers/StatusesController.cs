using Microsoft.AspNetCore.Mvc;
using Server.DAL.Context;
using Server.DAL.DAOs;
using Server.Models;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusesController : ControllerBase
    {
        private readonly AppDbContext context;
        private readonly StatusDao statusDao;

        public StatusesController(AppDbContext context)
        {
            this.context = context;
            this.statusDao = new StatusDao(context);
        }

        // GET: api/Statuses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StatusModel>>> GetStatusTypes()
        {
            return Ok(await statusDao.GetAll());
        }

        //// GET: api/Statuses/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<StatusModel>> GetStatusModel(StatusType id)
        //{
        //    var statusModel = await context.StatusTypes.FindAsync(id);

        //    if (statusModel == null)
        //    {
        //        return NotFound();
        //    }

        //    return statusModel;
        //}

        //// PUT: api/Statuses/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutStatusModel(StatusType id, StatusModel statusModel)
        //{
        //    if (id != statusModel.StatusType)
        //    {
        //        return BadRequest();
        //    }

        //    context.Entry(statusModel).State = EntityState.Modified;

        //    try
        //    {
        //        await context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!StatusModelExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Statuses
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<StatusModel>> PostStatusModel(StatusModel statusModel)
        //{
        //    context.StatusTypes.Add(statusModel);
        //    try
        //    {
        //        await context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (StatusModelExists(statusModel.StatusType))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtAction("GetStatusModel", new { id = statusModel.StatusType }, statusModel);
        //}

        //// DELETE: api/Statuses/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteStatusModel(StatusType id)
        //{
        //    var statusModel = await context.StatusTypes.FindAsync(id);
        //    if (statusModel == null)
        //    {
        //        return NotFound();
        //    }

        //    context.StatusTypes.Remove(statusModel);
        //    await context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool StatusModelExists(StatusType id)
        //{
        //    return context.StatusTypes.Any(e => e.StatusType == id);
        //}
    }
}
