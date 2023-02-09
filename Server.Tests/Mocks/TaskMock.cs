using Server.Models;

namespace Server.Tests.Mocks
{
    public class TaskMock
    {
        public static Models.Task MockTask(int id = -1)
        {
            return new Models.Task()
            {
                Id = id,
                Name = $"Test {id}",
                Description = $"Test {id} Description",
                Comments = $"Test {id} Comments",
                CreatedAt = DateTime.Now,
                ModifiedAt = DateTime.Now,
            };
        }

        public static IEnumerable<Models.Task> MockMultipleTasks()
        {
            List<Models.Task> tasks = new();

            for(int i = -1; i > -3; i--)
            {
                tasks.Add(MockTask(i));
            }

            return tasks;
        }
    }
}
