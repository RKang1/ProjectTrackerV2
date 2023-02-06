using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySql.EntityFrameworkCore.Extensions;
using Server.Models;

namespace Server.ModelConfigurations
{
    public class StatusTypeConfiguration : IEntityTypeConfiguration<StatusType>
    {
        public void Configure(EntityTypeBuilder<StatusType> builder)
        {
            builder.Property(p => p.Id).UseMySQLAutoIncrementColumn("int");

            builder.HasData(
                new StatusType
                {
                    Id= 1,
                    DisplayName = "To Do"
                },
                new StatusType
                {
                    Id= 2,
                    DisplayName = "In Progress"
                },
                new StatusType
                {
                    Id= 3,
                    DisplayName = "Waiting"
                },
                new StatusType
                {
                    Id= 4,
                    DisplayName = "Completed"
                }
            );
        }
    }
}
