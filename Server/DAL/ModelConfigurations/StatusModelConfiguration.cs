using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server.Enums;
using Server.Models;

namespace Server.DAL.ModelConfigurations
{
    public class StatusModelConfiguration : IEntityTypeConfiguration<Status>
    {
        public void Configure(EntityTypeBuilder<Status> builder)
        {
            builder.Property(p => p.StatusType).HasConversion(new EnumToNumberConverter<StatusType, int>());

            builder.HasData(
                new Status
                {
                    StatusType = StatusType.ToDo,
                    DisplayName = "To Do"
                },
                new Status
                {
                    StatusType = StatusType.InProgress,
                    DisplayName = "In Progress"
                },
                new Status
                {
                    StatusType = StatusType.Waiting,
                    DisplayName = "Waiting"
                },
                new Status
                {
                    StatusType = StatusType.Completed,
                    DisplayName = "Completed"
                }
            );
        }
    }
}
