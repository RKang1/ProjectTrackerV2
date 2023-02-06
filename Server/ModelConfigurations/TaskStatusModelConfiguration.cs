using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Server.Enums;
using Server.Models;

namespace Server.ModelConfigurations
{
    public class TaskStatusModelConfiguration : IEntityTypeConfiguration<Models.TaskStatusModel>
    {
        public void Configure(EntityTypeBuilder<Models.TaskStatusModel> builder)
        {
            builder.HasData(
                new TaskStatusModel
                {
                    Id = (int)StatusType.ToDo,
                    Status = StatusType.ToDo,
                    DisplayName = "To Do"
                },
                new TaskStatusModel
                {
                    Id = (int)StatusType.InProgress,
                    Status = StatusType.InProgress,
                    DisplayName = "In Progress"
                },
                new TaskStatusModel
                {
                    Id = (int)StatusType.Waiting,
                    Status = StatusType.Waiting,
                    DisplayName = "Waiting"
                },
                new TaskStatusModel
                {
                    Id = (int)StatusType.Completed,
                    Status = StatusType.Completed,
                    DisplayName = "Completed"
                }
            );
        }
    }
}
