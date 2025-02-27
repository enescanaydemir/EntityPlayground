﻿// <auto-generated />
using System;
using EntityPlayground.src.TutorialProject.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EntityPlayground.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EntityPlayground.src.TutorialProject.Domain.Entities.ApplicationRoles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ApplicationRoles");
                });

            modelBuilder.Entity("EntityPlayground.src.TutorialProject.Domain.Entities.ApplicationUsers", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("ApplicationUsers");
                });

            modelBuilder.Entity("EntityPlayground.src.TutorialProject.Domain.Entities.Companies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("ApplicationUsersId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Industry")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Size")
                        .HasColumnType("text");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUsersId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("EntityPlayground.src.TutorialProject.Domain.Entities.CompanyKPIs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("integer");

                    b.Property<int>("KPIId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("MeasurementDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Notes")
                        .HasColumnType("text");

                    b.Property<decimal>("Value")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("KPIId");

                    b.ToTable("CompanyKPIs");
                });

            modelBuilder.Entity("EntityPlayground.src.TutorialProject.Domain.Entities.KPIs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CalculationMethod")
                        .HasColumnType("text");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsStandard")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Unit")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("KPIs");
                });

            modelBuilder.Entity("EntityPlayground.src.TutorialProject.Domain.Entities.KPIsCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("KPIsCategory");
                });

            modelBuilder.Entity("EntityPlayground.src.TutorialProject.Domain.Entities.ApplicationUsers", b =>
                {
                    b.HasOne("EntityPlayground.src.TutorialProject.Domain.Entities.ApplicationRoles", "Role")
                        .WithMany("ApplicationUsers")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("EntityPlayground.src.TutorialProject.Domain.Entities.Companies", b =>
                {
                    b.HasOne("EntityPlayground.src.TutorialProject.Domain.Entities.ApplicationUsers", null)
                        .WithMany("Companies")
                        .HasForeignKey("ApplicationUsersId");
                });

            modelBuilder.Entity("EntityPlayground.src.TutorialProject.Domain.Entities.CompanyKPIs", b =>
                {
                    b.HasOne("EntityPlayground.src.TutorialProject.Domain.Entities.Companies", "Companies")
                        .WithMany("CompanyKPIs")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityPlayground.src.TutorialProject.Domain.Entities.KPIs", "KPIs")
                        .WithMany("CompanyKPIs")
                        .HasForeignKey("KPIId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Companies");

                    b.Navigation("KPIs");
                });

            modelBuilder.Entity("EntityPlayground.src.TutorialProject.Domain.Entities.KPIs", b =>
                {
                    b.HasOne("EntityPlayground.src.TutorialProject.Domain.Entities.KPIsCategory", "Category")
                        .WithMany("KPIs")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EntityPlayground.src.TutorialProject.Domain.Entities.ApplicationRoles", b =>
                {
                    b.Navigation("ApplicationUsers");
                });

            modelBuilder.Entity("EntityPlayground.src.TutorialProject.Domain.Entities.ApplicationUsers", b =>
                {
                    b.Navigation("Companies");
                });

            modelBuilder.Entity("EntityPlayground.src.TutorialProject.Domain.Entities.Companies", b =>
                {
                    b.Navigation("CompanyKPIs");
                });

            modelBuilder.Entity("EntityPlayground.src.TutorialProject.Domain.Entities.KPIs", b =>
                {
                    b.Navigation("CompanyKPIs");
                });

            modelBuilder.Entity("EntityPlayground.src.TutorialProject.Domain.Entities.KPIsCategory", b =>
                {
                    b.Navigation("KPIs");
                });
#pragma warning restore 612, 618
        }
    }
}
