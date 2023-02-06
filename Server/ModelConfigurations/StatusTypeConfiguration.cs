using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySql.EntityFrameworkCore.Extensions;
using TaskStatus = Server.Models.TaskStatus;

namespace Server.ModelConfigurations
{
    public class StatusTypeConfiguration : IEntityTypeConfiguration<Models.TaskStatus>
    {
        public void Configure(EntityTypeBuilder<Models.TaskStatus> builder)
        {
            builder.Property(p => p.Id).UseMySQLAutoIncrementColumn("int");

            builder.HasData(
                new TaskStatus
                {
                    Id= 1,
                    DisplayName = "To Do"
                },
                new TaskStatus
                {
                    Id= 2,
                    DisplayName = "In Progress"
                },
                new TaskStatus
                {
                    Id= 3,
                    DisplayName = "Waiting"
                },
                new TaskStatus
                {
                    Id= 4,
                    DisplayName = "Completed"
                }
            );
        }
    }
}
