using Microsoft.EntityFrameworkCore;
using Server.DAL.ModelConfigurations;
using Server.Models;
using System.Runtime.CompilerServices;

namespace Server.DAL.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StatusModelConfiguration());
        }

        public DbSet<Status> StatusTypes { get; set; }
        public DbSet<Models.Task> Tasks { get; set; }
    }
}
