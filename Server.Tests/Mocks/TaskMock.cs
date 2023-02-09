using Server.Models;

namespace Server.Tests.Mocks
{
    public class TaskMock
    {
        public static TaskModel MockTask(int id = -1)
        {
            return new TaskModel()
            {
                Id = id,
                Name = $"Test {id}",
                Description = $"Test {id} Description",
                Comments = $"Test {id} Comments",
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now,
            };
        }

        public static IEnumerable<TaskModel> MockMultipleTasks()
        {
            List<TaskModel> tasks = new();

            for(int i = -1; i > -3; i--)
            {
                tasks.Add(MockTask(i));
            }

            return tasks;
        }
    }
}
