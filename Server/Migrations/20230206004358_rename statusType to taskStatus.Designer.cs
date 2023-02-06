﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Server.DataAccess;

#nullable disable

namespace Server.Migrations
{
    [DbContext(typeof(ProjectTrackerDbContext))]
    [Migration("20230206004358_rename statusType to taskStatus")]
    partial class renamestatusTypetotaskStatus
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Server.Models.TaskStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DisplayName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("TaskStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayName = "To Do"
                        },
                        new
                        {
                            Id = 2,
                            DisplayName = "In Progress"
                        },
                        new
                        {
                            Id = 3,
                            DisplayName = "Waiting"
                        },
                        new
                        {
                            Id = 4,
                            DisplayName = "Completed"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
