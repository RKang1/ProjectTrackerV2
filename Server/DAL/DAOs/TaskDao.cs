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

        public void Create(Models.Task task)
        {
            dbContext.Tasks.Add(task);
            dbContext.SaveChanges();
        }

        public void CreateMultiple(IEnumerable<Models.Task> tasks)
        {
            dbContext.Tasks.AddRange(tasks);
            dbContext.SaveChanges();
        }

        public IEnumerable<Models.Task> GetAll()
        {
            return dbContext.Tasks;
        }

        public Models.Task? GetById(int id)
        {
            return dbContext.Tasks.SingleOrDefault(t => t.Id == id);
        }
    }
}