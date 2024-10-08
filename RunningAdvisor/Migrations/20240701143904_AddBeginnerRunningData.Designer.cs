﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RunningAdvisor.Data;

#nullable disable

namespace RunningAdvisor.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240701143904_AddBeginnerRunningData")]
    partial class AddBeginnerRunningData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RunningAdvisor.Models.Entities.BeginnerRunningData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AvgHeartRate10k")
                        .HasColumnType("int");

                    b.Property<int>("AvgHeartRate3k")
                        .HasColumnType("int");

                    b.Property<int>("AvgHeartRate5k")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Time10k")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("Time3k")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("Time5k")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("BeginnerRunningData");
                });

            modelBuilder.Entity("RunningAdvisor.Models.Entities.RunningData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AvgHeartRate10k")
                        .HasColumnType("int");

                    b.Property<int>("AvgHeartRate21k")
                        .HasColumnType("int");

                    b.Property<int>("AvgHeartRate42k")
                        .HasColumnType("int");

                    b.Property<int>("Cadence")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Time10k")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("Time21k")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("Time42k")
                        .HasColumnType("time");

                    b.HasKey("Id");

                    b.ToTable("RunningData");
                });
#pragma warning restore 612, 618
        }
    }
}
