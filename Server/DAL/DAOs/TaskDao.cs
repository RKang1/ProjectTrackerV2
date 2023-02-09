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

        public async Task<IEnumerable<TaskModel>> GetAll()
        {
            return await context.Tasks.ToListAsync();
        }

        public async Task<TaskModel?> GetById(int id)
        {
            return await context.Tasks.FindAsync(id);
        }

        public async Task<int> Update(TaskModel task)
        {
            context.Entry(task).State = EntityState.Modified;

            return await context.SaveChangesAsync();
        }

        public async Task<int> Create(TaskModel task)
        {
            context.Tasks.Add(task);
            return await context.SaveChangesAsync();
        }

        public async Task<int> Delete(TaskModel task)
        {
            context.Tasks.Remove(task);
            return await context.SaveChangesAsync();
        }

        public bool TaskExists(int id)
        {
            return context.Tasks.Any(e => e.Id == id);
        }

        public void CreateMultiple(IEnumerable<TaskModel> tasks)
        {
            context.Tasks.AddRange(tasks);
            context.SaveChanges();
        }
    }
}