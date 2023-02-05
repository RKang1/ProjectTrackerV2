using Microsoft.EntityFrameworkCore;

namespace Server.DataAccess
{
    public class ProjectTrackerDbContext : DbContext
    {
        public ProjectTrackerDbContext(DbContextOptions<ProjectTrackerDbContext> options) : base(options)
        {
        }
    }
}
