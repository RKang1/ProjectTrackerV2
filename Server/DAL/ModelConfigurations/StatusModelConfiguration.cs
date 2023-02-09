using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server.Enums;
using Server.Models;

namespace Server.DAL.ModelConfigurations
{
    public class StatusModelConfiguration : IEntityTypeConfiguration<StatusModel>
    {
        public void Configure(EntityTypeBuilder<StatusModel> builder)
        {
            builder.Property(p => p.StatusType).HasConversion(new EnumToNumberConverter<StatusType, int>());

            builder.HasData(
                new StatusModel
                {
                    StatusType = StatusType.ToDo,
                    DisplayName = "To Do"
                },
                new StatusModel
                {
                    StatusType = StatusType.InProgress,
                    DisplayName = "In Progress"
                },
                new StatusModel
                {
                    StatusType = StatusType.Waiting,
                    DisplayName = "Waiting"
                },
                new StatusModel
                {
                    StatusType = StatusType.Completed,
                    DisplayName = "Completed"
                }
            );
        }
    }
}
