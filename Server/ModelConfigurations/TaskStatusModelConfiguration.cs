using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySql.EntityFrameworkCore.Extensions;
using Server.Models;

namespace Server.ModelConfigurations
{
    public class TaskStatusModelConfiguration : IEntityTypeConfiguration<Models.TaskStatusModel>
    {
        public void Configure(EntityTypeBuilder<Models.TaskStatusModel> builder)
        {
            builder.Property(p => p.Id).UseMySQLAutoIncrementColumn("int");

            builder.HasData(
                new TaskStatusModel
                {
                    Id = 1,
                    DisplayName = "To Do"
                },
                new TaskStatusModel
                {
                    Id = 2,
                    DisplayName = "In Progress"
                },
                new TaskStatusModel
                {
                    Id = 3,
                    DisplayName = "Waiting"
                },
                new TaskStatusModel
                {
                    Id = 4,
                    DisplayName = "Completed"
                }
            );
        }
    }
}
