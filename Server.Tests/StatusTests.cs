using Server.DataAccessObjects;
using Server.Enums;

namespace Server.Tests
{
    public class StatusTests
    {
        [Fact]
        public void GetAllStatuses()
        {
            StatusDao dao = new();

            IEnumerable<StatusType> statuses = dao.GetAll();

            Assert.NotNull(statuses);
        }

        [Fact]
        public void CheckEnumExistsInDatabase()
        {
            StatusDao dao = new();

            IEnumerable<StatusType> statuses = dao.GetAll();

            foreach (StatusType statusType in Enum.GetValues(typeof(StatusType)))
            {
                Assert.Contains(statusType, statuses);
            }
        }
    }
}
