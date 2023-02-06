using Microsoft.EntityFrameworkCore;
using Server.DAL.Context;
using Server.Models;

namespace Server.DAL.DAOs
{
    public class StatusDao
    {
        private readonly AppDbContext dbContext;

        public StatusDao(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<StatusModel> GetAll()
        {
            return dbContext.StatusTypes.AsNoTracking().ToList();
        }
    }
}