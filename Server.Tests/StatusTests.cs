using Server.DataAccessObjects;
using Server.Enums;
using Server.Migrations.Context;

namespace Server.Tests
{
    public class StatusTests
    {
        private readonly ProjectTrackerDbContext dbContext;

        public StatusTests(ProjectTrackerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [Fact]
        public void GetAllStatuses()
        {
            StatusDao dao = new(dbContext);

            IEnumerable<StatusType> statuses = dao.GetAll();

            Assert.NotNull(statuses);
        }

        [Fact]
        public void CheckEnumExistsInDatabase()
        {
            StatusDao dao = new(dbContext);

            IEnumerable<StatusType> statuses = dao.GetAll();

            foreach (StatusType statusType in Enum.GetValues(typeof(StatusType)))
            {
                Assert.Contains(statusType, statuses);
            }
        }
    }
}
