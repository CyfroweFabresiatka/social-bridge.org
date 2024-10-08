﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SocialBridge.Main.Data;

#nullable disable

namespace SocialBridge.Main.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240928173652_MakeReferencesNullable")]
    partial class MakeReferencesNullable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SocialBridge.Main.Models.Application", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Comment")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("comment");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("company_name");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<Guid?>("GrantId")
                        .HasColumnType("uuid")
                        .HasColumnName("grant_id");

                    b.Property<Guid?>("ProjectId")
                        .HasColumnType("uuid")
                        .HasColumnName("project_id");

                    b.HasKey("Id");

                    b.HasIndex("GrantId");

                    b.HasIndex("ProjectId");

                    b.ToTable("applications");
                });

            modelBuilder.Entity("SocialBridge.Main.Models.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("companies");
                });

            modelBuilder.Entity("SocialBridge.Main.Models.Grant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("uuid")
                        .HasColumnName("company_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.ToTable("grants");
                });

            modelBuilder.Entity("SocialBridge.Main.Models.Ngo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("ngos");
                });

            modelBuilder.Entity("SocialBridge.Main.Models.Project", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<Guid>("NgoId")
                        .HasColumnType("uuid")
                        .HasColumnName("ngo_id");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.HasKey("Id");

                    b.HasIndex("NgoId");

                    b.ToTable("projects");
                });

            modelBuilder.Entity("SocialBridge.Main.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid?>("CompanyId")
                        .HasColumnType("uuid")
                        .HasColumnName("company_id");

                    b.Property<string>("HackYeahPassword")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("hack_yeah_password");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<Guid?>("NgoId")
                        .HasColumnType("uuid")
                        .HasColumnName("ngo_id");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("surname");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("NgoId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("SocialBridge.Main.Models.Application", b =>
                {
                    b.HasOne("SocialBridge.Main.Models.Grant", "Grant")
                        .WithMany()
                        .HasForeignKey("GrantId");

                    b.HasOne("SocialBridge.Main.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId");

                    b.Navigation("Grant");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("SocialBridge.Main.Models.Grant", b =>
                {
                    b.HasOne("SocialBridge.Main.Models.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("SocialBridge.Main.Models.Project", b =>
                {
                    b.HasOne("SocialBridge.Main.Models.Ngo", "Ngo")
                        .WithMany()
                        .HasForeignKey("NgoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ngo");
                });

            modelBuilder.Entity("SocialBridge.Main.Models.User", b =>
                {
                    b.HasOne("SocialBridge.Main.Models.Company", "Company")
                        .WithMany("Users")
                        .HasForeignKey("CompanyId");

                    b.HasOne("SocialBridge.Main.Models.Ngo", "Ngo")
                        .WithMany("Users")
                        .HasForeignKey("NgoId");

                    b.Navigation("Company");

                    b.Navigation("Ngo");
                });

            modelBuilder.Entity("SocialBridge.Main.Models.Company", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("SocialBridge.Main.Models.Ngo", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
