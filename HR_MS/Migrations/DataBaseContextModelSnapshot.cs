﻿// <auto-generated />
using HR_MS.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HR_MS.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HR_MS.Model.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("describtion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("place")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("epartments");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            EmployeeId = 0,
                            Name = "Badr",
                            describtion = "jdklajsflkhflkahsfa",
                            place = "Online",
                            type = "Partial"
                        },
                        new
                        {
                            ID = 2,
                            EmployeeId = 0,
                            Name = "Badr",
                            describtion = "jdklajsflkhflkahsfa",
                            place = "Online",
                            type = "Partial"
                        },
                        new
                        {
                            ID = 3,
                            EmployeeId = 0,
                            Name = "Badr",
                            describtion = "jdklajsflkhflkahsfa",
                            place = "Online",
                            type = "Partial"
                        },
                        new
                        {
                            ID = 4,
                            EmployeeId = 0,
                            Name = "Badr",
                            describtion = "jdklajsflkhflkahsfa",
                            place = "Online",
                            type = "Partial"
                        },
                        new
                        {
                            ID = 5,
                            EmployeeId = 0,
                            Name = "Badr",
                            describtion = "jdklajsflkhflkahsfa",
                            place = "Online",
                            type = "Partial"
                        });
                });

            modelBuilder.Entity("HR_MS.Model.Employee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Address = "Sana'a",
                            Emial = "aa405716@gmail.com",
                            Name = "Badr",
                            PhoneNumber = "775010762"
                        },
                        new
                        {
                            ID = 2,
                            Address = "Sana'a",
                            Emial = "aa405716@gmail.com",
                            Name = "Badr",
                            PhoneNumber = "775010762"
                        },
                        new
                        {
                            ID = 3,
                            Address = "Sana'a",
                            Emial = "aa405716@gmail.com",
                            Name = "Badr",
                            PhoneNumber = "775010762"
                        },
                        new
                        {
                            ID = 4,
                            Address = "Sana'a",
                            Emial = "aa405716@gmail.com",
                            Name = "Badr",
                            PhoneNumber = "775010762"
                        },
                        new
                        {
                            ID = 5,
                            Address = "Sana'a",
                            Emial = "aa405716@gmail.com",
                            Name = "Badr",
                            PhoneNumber = "775010762"
                        });
                });

            modelBuilder.Entity("HR_MS.Model.Salary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("amt")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId")
                        .IsUnique();

                    b.ToTable("Salari");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EmployeeId = 0,
                            amt = "Badr",
                            type = "Manager"
                        },
                        new
                        {
                            Id = 3,
                            EmployeeId = 0,
                            amt = "Badr",
                            type = "Manager"
                        },
                        new
                        {
                            Id = 4,
                            EmployeeId = 0,
                            amt = "Badr",
                            type = "Manager"
                        },
                        new
                        {
                            Id = 5,
                            EmployeeId = 0,
                            amt = "Badr",
                            type = "Manager"
                        });
                });

            modelBuilder.Entity("HR_MS.Model.Department", b =>
                {
                    b.HasOne("HR_MS.Model.Employee", "Employee")
                        .WithOne("Department")
                        .HasForeignKey("HR_MS.Model.Department", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("HR_MS.Model.Salary", b =>
                {
                    b.HasOne("HR_MS.Model.Employee", "Employee")
                        .WithOne("Salary")
                        .HasForeignKey("HR_MS.Model.Salary", "EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("HR_MS.Model.Employee", b =>
                {
                    b.Navigation("Department")
                        .IsRequired();

                    b.Navigation("Salary")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
