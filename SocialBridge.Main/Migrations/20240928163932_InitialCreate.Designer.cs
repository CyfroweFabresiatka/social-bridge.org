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
    [Migration("20240928163932_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SocialBridge.Main.Data.Models.Company", b =>
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

            modelBuilder.Entity("SocialBridge.Main.Data.Models.Ngo", b =>
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

            modelBuilder.Entity("SocialBridge.Main.Data.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("CompanyId")
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

                    b.Property<Guid>("NgoId")
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

            modelBuilder.Entity("SocialBridge.Main.Data.Models.User", b =>
                {
                    b.HasOne("SocialBridge.Main.Data.Models.Company", "Company")
                        .WithMany("Users")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SocialBridge.Main.Data.Models.Ngo", "Ngo")
                        .WithMany("Users")
                        .HasForeignKey("NgoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Ngo");
                });

            modelBuilder.Entity("SocialBridge.Main.Data.Models.Company", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("SocialBridge.Main.Data.Models.Ngo", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
