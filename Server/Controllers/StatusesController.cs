using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.DAL.Context;
using Server.Models;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatusesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StatusesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Statuses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<StatusModel>>> GetStatusTypes()
        {
            return await _context.StatusTypes.ToListAsync();
        }

        // GET: api/Statuses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<StatusModel>> GetStatusModel(StatusType id)
        {
            var statusModel = await _context.StatusTypes.FindAsync(id);

            if (statusModel == null)
            {
                return NotFound();
            }

            return statusModel;
        }

        // PUT: api/Statuses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStatusModel(StatusType id, StatusModel statusModel)
        {
            if (id != statusModel.StatusType)
            {
                return BadRequest();
            }

            _context.Entry(statusModel).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StatusModelExists(id))
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

        // POST: api/Statuses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<StatusModel>> PostStatusModel(StatusModel statusModel)
        {
            _context.StatusTypes.Add(statusModel);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (StatusModelExists(statusModel.StatusType))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetStatusModel", new { id = statusModel.StatusType }, statusModel);
        }

        // DELETE: api/Statuses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStatusModel(StatusType id)
        {
            var statusModel = await _context.StatusTypes.FindAsync(id);
            if (statusModel == null)
            {
                return NotFound();
            }

            _context.StatusTypes.Remove(statusModel);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StatusModelExists(StatusType id)
        {
            return _context.StatusTypes.Any(e => e.StatusType == id);
        }
    }
}
