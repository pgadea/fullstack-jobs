// <auto-generated />
using System;
using FullStackJobs.GraphQL.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FullStackJobs.GraphQL.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FullStackJobs.GraphQL.Core.Domain.Entities.Applicant", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Applicants");
                });

            modelBuilder.Entity("FullStackJobs.GraphQL.Core.Domain.Entities.Employer", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Employers");
                });

            modelBuilder.Entity("FullStackJobs.GraphQL.Core.Domain.Entities.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AnnualBaseSalary")
                        .HasColumnType("int");

                    b.Property<string>("ApplicationInstructions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Company")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Icon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Requirements")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Responsibilities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("Draft");

                    b.HasKey("Id");

                    b.HasIndex("EmployerId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("FullStackJobs.GraphQL.Core.Domain.Entities.JobApplicant", b =>
                {
                    b.Property<int>("JobId")
                        .HasColumnType("int");

                    b.Property<string>("ApplicantId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("JobId", "ApplicantId");

                    b.HasIndex("ApplicantId");

                    b.ToTable("JobApplicants");
                });

            modelBuilder.Entity("FullStackJobs.GraphQL.Core.Domain.Values.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int?>("JobId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("JobId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("FullStackJobs.GraphQL.Core.Domain.Entities.Job", b =>
                {
                    b.HasOne("FullStackJobs.GraphQL.Core.Domain.Entities.Employer", "Employer")
                        .WithMany()
                        .HasForeignKey("EmployerId");
                });

            modelBuilder.Entity("FullStackJobs.GraphQL.Core.Domain.Entities.JobApplicant", b =>
                {
                    b.HasOne("FullStackJobs.GraphQL.Core.Domain.Entities.Applicant", "Applicant")
                        .WithMany("JobApplicants")
                        .HasForeignKey("ApplicantId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FullStackJobs.GraphQL.Core.Domain.Entities.Job", "Job")
                        .WithMany("JobApplicants")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FullStackJobs.GraphQL.Core.Domain.Values.Tag", b =>
                {
                    b.HasOne("FullStackJobs.GraphQL.Core.Domain.Entities.Job", "Job")
                        .WithMany("Tags")
                        .HasForeignKey("JobId");
                });
#pragma warning restore 612, 618
        }
    }
}
