using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Server.DAL.Context;
using Server.DAL.DAOs;
using Server.Enums;
using Server.Models;
using Server.Tests.DAL;

namespace Server.Tests.Tests
{
    public class StatusTests
    {
        private readonly AppDbContext dbContext;

        public StatusTests()
        {
            dbContext = DbContextHelper.GetDbContext();
        }

        [Fact]
        public void GetAllStatusTypes()
        {
            StatusDao dao = new(dbContext);

            IEnumerable<StatusModel> statuses = dao.GetAll();

            Assert.NotNull(statuses);
        }

        [Fact]
        public void CheckStatusTypeEnumExistsInDatabase()
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
