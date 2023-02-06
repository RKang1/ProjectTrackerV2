using Server.DAL.Context;
using Server.Enums;

namespace Server.DAL.DAOs
{
    public class StatusDao
    {
        private readonly ProjectTrackerDbContext dbContext;

        public StatusDao(ProjectTrackerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<StatusType> GetAll()
        {
            return (IEnumerable<StatusType>)dbContext.StatusTypes.ToList();
        }
    }
}