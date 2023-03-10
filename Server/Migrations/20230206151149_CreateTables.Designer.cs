// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server.DAL.Context;

#nullable disable

namespace Server.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230206151149_CreateTables")]
    partial class CreateTables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Server.Models.StatusModel", b =>
                {
                    b.Property<int>("StatusType")
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.Property<string>("DisplayName")
                        .HasColumnType("longtext");

                    b.HasKey("StatusType");

                    b.ToTable("StatusTypes");

                    b.HasData(
                        new
                        {
                            StatusType = 1,
                            DisplayName = "To Do"
                        },
                        new
                        {
                            StatusType = 2,
                            DisplayName = "In Progress"
                        },
                        new
                        {
                            StatusType = 3,
                            DisplayName = "Waiting"
                        },
                        new
                        {
                            StatusType = 4,
                            DisplayName = "Completed"
                        });
                });

            modelBuilder.Entity("Server.Models.TaskModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Comments")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<DateTime?>("ModifiedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int?>("StatusType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StatusType");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("Server.Models.TaskModel", b =>
                {
                    b.HasOne("Server.Models.StatusModel", "Status")
                        .WithMany()
                        .HasForeignKey("StatusType");

                    b.Navigation("Status");
                });
#pragma warning restore 612, 618
        }
    }
}
