using Server.DAL.Context;
using Server.DAL.DAOs;
using Server.Enums;
using Server.Models;

namespace Server.Tests
{
    public class StatusTests
    {
        private readonly AppDbContext dbContext;

        public StatusTests(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [Fact]
        public void GetAllStatuses()
        {
            StatusDao dao = new(dbContext);

            IEnumerable<StatusModel> statuses = dao.GetAll();

            Assert.NotNull(statuses);
        }

        [Fact]
        public void CheckEnumExistsInDatabase()
        {
            StatusDao dao = new(dbContext);

            IEnumerable<StatusModel> statuses = dao.GetAll();

            foreach (StatusType statusType in Enum.GetValues(typeof(StatusType)))
            {
                Assert.Contains(statusType, statuses.Select(s => s.StatusType));
            }
        }
    }
}
