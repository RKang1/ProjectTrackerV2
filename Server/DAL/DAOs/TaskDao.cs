using Server.DAL.Context;
using Server.Models;

namespace Server.DAL.DAOs
{
    public class TaskDao
    {
        private readonly AppDbContext dbContext;

        public TaskDao(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public void Create(TaskModel task)
        {
            dbContext.Tasks.Add(task);
            dbContext.SaveChanges();
        }

        public void CreateMultiple(IEnumerable<TaskModel> tasks)
        {
            dbContext.Tasks.AddRange(tasks);
            dbContext.SaveChanges();
        }

        public IEnumerable<TaskModel> GetAll()
        {
            return dbContext.Tasks;
        }

        public TaskModel? GetById(int id)
        {
            return dbContext.Tasks.SingleOrDefault(t => t.Id == id);
        }
    }
}