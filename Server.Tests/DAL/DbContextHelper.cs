using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Server.DAL.Context;

namespace Server.Tests.DAL
{
    public class DbContextHelper
    {
        public static AppDbContext GetDbContext()
        {
            var builder = new ConfigurationBuilder().AddUserSecrets<DbContextHelper>().Build();
            return new AppDbContext(new DbContextOptionsBuilder<AppDbContext>().UseMySQL(builder.GetConnectionString("ProjectTrackerDb") ?? string.Empty).Options);
        }
    }
}
