﻿// <auto-generated />
using System;
using AppointmentContact.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppointmentContact.Migrations
{
    [DbContext(typeof(AppointmentDbContext))]
    partial class AppointmentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AppointmentContact.Models.Appointment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime>("dob")
                        .HasColumnType("datetime");

                    b.Property<string>("email_addr")
                        .IsRequired()
                        .HasColumnType("varchar(320)");

                    b.Property<string>("first_nm")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("last_nm")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("parish")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("phone_nbr")
                        .IsRequired()
                        .HasColumnType("varchar(13)");

                    b.HasKey("id");

                    b.ToTable("Appointments");
                });
#pragma warning restore 612, 618
        }
    }
}
