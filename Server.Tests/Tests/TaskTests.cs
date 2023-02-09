using Server.DAL.Context;
using Server.DAL.DAOs;
using Server.Models;
using Server.Tests.DAL;
using Server.Tests.Mocks;

namespace Server.Tests.Tests
{
    public class TaskTests
    {
        private readonly AppDbContext dbContext;

        public TaskTests()
        {
            dbContext = DbContextHelper.GetDbContext();
        }

        [Fact]
        public void CreateTaskAndGetById()
        {
            var transaction = dbContext.Database.BeginTransaction();

            TaskDao dao = new(dbContext);

            TaskModel task = TaskMock.MockTask();
            dao.Create(task);

            Assert.NotNull(dao.GetById(task.Id));

            transaction.Rollback();
        }

        [Fact]
        public void CreateMultipleTasksAndGetAll()
        {
            var transaction = dbContext.Database.BeginTransaction();

            TaskDao dao = new(dbContext);

            IEnumerable<TaskModel> mockTasks = TaskMock.MockMultipleTasks();
            dao.CreateMultiple(mockTasks);

            IEnumerable<TaskModel> tasks = dao.GetAll();

            Assert.True(tasks.Any());

            transaction.Rollback();
        }
    }
}
