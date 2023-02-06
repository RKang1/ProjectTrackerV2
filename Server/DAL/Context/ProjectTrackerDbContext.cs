using Microsoft.EntityFrameworkCore;
using Server.DAL.ModelConfigurations;
using Server.Models;

namespace Server.DAL.Context
{
    public class ProjectTrackerDbContext : DbContext
    {
        public ProjectTrackerDbContext(DbContextOptions<ProjectTrackerDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StatusModelConfiguration());
        }

        public DbSet<StatusModel> StatusTypes { get; set; }
        public DbSet<TaskModel> Tasks { get; set; }
    }
}
