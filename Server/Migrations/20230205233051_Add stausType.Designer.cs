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
    [Migration("20230205233051_Add stausType")]
    partial class AddstausType
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Server.Enums.StatusType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DisplayName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("StatusTypes");
                });
#pragma warning restore 612, 618
        }
    }
}
