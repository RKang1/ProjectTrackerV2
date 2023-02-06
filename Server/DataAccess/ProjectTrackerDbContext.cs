using Microsoft.EntityFrameworkCore;
using Server.ModelConfigurations;
using TaskStatusModel = Server.Models.TaskStatusModel;
using TaskModel = Server.Models.TaskModel;

namespace Server.DataAccess
{
    public class ProjectTrackerDbContext : DbContext
    {
        public ProjectTrackerDbContext(DbContextOptions<ProjectTrackerDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TaskStatusModelConfiguration());
        }

        public DbSet<TaskStatusModel> TaskStatuses { get; set; }
        public DbSet<TaskModel> Tasks { get; set; }
    }
}
