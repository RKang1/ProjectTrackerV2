using Microsoft.EntityFrameworkCore;
using Server.DAL.Context;
using Server.Models;

namespace Server.DAL.DAOs
{
    public class TaskDao
    {
        private readonly AppDbContext context;

        public TaskDao(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<TaskModel>> GetTasks()
        {
            return await context.Tasks.ToListAsync();
        }

        public async Task<TaskModel?> GetTask(int id)
        {
            return await context.Tasks.FindAsync(id);
        }

        public void Create(TaskModel task)
        {
            context.Tasks.Add(task);
            context.SaveChanges();
        }

        public void CreateMultiple(IEnumerable<TaskModel> tasks)
        {
            context.Tasks.AddRange(tasks);
            context.SaveChanges();
        }
    }
}