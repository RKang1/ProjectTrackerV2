using Microsoft.EntityFrameworkCore;
using Server.DAL.Context;
using Server.Models;

namespace Server.DAL.DAOs
{
    public class StatusDao
    {
        private readonly AppDbContext context;

        public StatusDao(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<StatusModel>> GetAll()
        {
            return await context.StatusTypes.ToListAsync();
        }
    }
}