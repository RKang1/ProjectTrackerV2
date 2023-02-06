using Server.Enums;
using Server.Migrations.Context;

namespace Server.DataAccessObjects
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