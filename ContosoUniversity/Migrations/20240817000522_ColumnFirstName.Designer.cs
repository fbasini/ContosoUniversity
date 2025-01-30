﻿// <auto-generated />
using System;
using ContosoUniversity.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ContosoUniversity.Migrations
{
    [DbContext(typeof(SchoolContext))]
    [Migration("20240817000522_ColumnFirstName")]
    partial class ColumnFirstName
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ContosoUniversity.Models.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("Credits")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseID");

                    b.ToTable("Course", (string)null);

                    b.HasData(
                        new
                        {
                            CourseID = 1050,
                            Credits = 3,
                            Title = "Chemistry"
                        },
                        new
                        {
                            CourseID = 4022,
                            Credits = 3,
                            Title = "Microeconomics"
                        },
                        new
                        {
                            CourseID = 4041,
                            Credits = 3,
                            Title = "Macroeconomics"
                        },
                        new
                        {
                            CourseID = 1045,
                            Credits = 4,
                            Title = "Calculus"
                        },
                        new
                        {
                            CourseID = 3141,
                            Credits = 4,
                            Title = "Trigonometry"
                        },
                        new
                        {
                            CourseID = 2021,
                            Credits = 3,
                            Title = "Composition"
                        },
                        new
                        {
                            CourseID = 2042,
                            Credits = 4,
                            Title = "Literature"
                        });
                });

            modelBuilder.Entity("ContosoUniversity.Models.Enrollment", b =>
                {
                    b.Property<int>("EnrollmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnrollmentID"));

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.HasKey("EnrollmentID");

                    b.HasIndex("CourseID");

                    b.HasIndex("StudentID");

                    b.ToTable("Enrollment", (string)null);

                    b.HasData(
                        new
                        {
                            EnrollmentID = 1,
                            CourseID = 1050,
                            Grade = 0,
                            StudentID = 1
                        },
                        new
                        {
                            EnrollmentID = 2,
                            CourseID = 4022,
                            Grade = 2,
                            StudentID = 1
                        },
                        new
                        {
                            EnrollmentID = 3,
                            CourseID = 4041,
                            Grade = 1,
                            StudentID = 1
                        },
                        new
                        {
                            EnrollmentID = 4,
                            CourseID = 1045,
                            Grade = 1,
                            StudentID = 2
                        },
                        new
                        {
                            EnrollmentID = 5,
                            CourseID = 3141,
                            Grade = 4,
                            StudentID = 2
                        },
                        new
                        {
                            EnrollmentID = 6,
                            CourseID = 2021,
                            Grade = 4,
                            StudentID = 2
                        },
                        new
                        {
                            EnrollmentID = 7,
                            CourseID = 1050,
                            StudentID = 3
                        },
                        new
                        {
                            EnrollmentID = 8,
                            CourseID = 1050,
                            StudentID = 4
                        },
                        new
                        {
                            EnrollmentID = 9,
                            CourseID = 4022,
                            Grade = 4,
                            StudentID = 4
                        },
                        new
                        {
                            EnrollmentID = 10,
                            CourseID = 4041,
                            Grade = 2,
                            StudentID = 5
                        },
                        new
                        {
                            EnrollmentID = 11,
                            CourseID = 1045,
                            StudentID = 6
                        },
                        new
                        {
                            EnrollmentID = 12,
                            CourseID = 3141,
                            Grade = 0,
                            StudentID = 7
                        });
                });

            modelBuilder.Entity("ContosoUniversity.Models.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentID"));

                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstMidName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("FirstName");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("StudentID");

                    b.ToTable("Student", (string)null);

                    b.HasData(
                        new
                        {
                            StudentID = 1,
                            EnrollmentDate = new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstMidName = "Carson",
                            LastName = "Alexander"
                        },
                        new
                        {
                            StudentID = 2,
                            EnrollmentDate = new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstMidName = "Meredith",
                            LastName = "Alonso"
                        },
                        new
                        {
                            StudentID = 3,
                            EnrollmentDate = new DateTime(2003, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstMidName = "Arturo",
                            LastName = "Anand"
                        },
                        new
                        {
                            StudentID = 4,
                            EnrollmentDate = new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstMidName = "Gytis",
                            LastName = "Barzdukas"
                        },
                        new
                        {
                            StudentID = 5,
                            EnrollmentDate = new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstMidName = "Yan",
                            LastName = "Li"
                        },
                        new
                        {
                            StudentID = 6,
                            EnrollmentDate = new DateTime(2001, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstMidName = "Peggy",
                            LastName = "Justice"
                        },
                        new
                        {
                            StudentID = 7,
                            EnrollmentDate = new DateTime(2003, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstMidName = "Laura",
                            LastName = "Norman"
                        },
                        new
                        {
                            StudentID = 8,
                            EnrollmentDate = new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FirstMidName = "Nino",
                            LastName = "Olivetto"
                        });
                });

            modelBuilder.Entity("ContosoUniversity.Models.Enrollment", b =>
                {
                    b.HasOne("ContosoUniversity.Models.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ContosoUniversity.Models.Student", "Student")
                        .WithMany("Enrollments")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Course", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("ContosoUniversity.Models.Student", b =>
                {
                    b.Navigation("Enrollments");
                });
#pragma warning restore 612, 618
        }
    }
}
