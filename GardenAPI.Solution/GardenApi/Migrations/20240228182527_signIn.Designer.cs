﻿// <auto-generated />
using System;
using GardenApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GardenApi.Migrations
{
    [DbContext(typeof(GardenApiContext))]
    [Migration("20240228182527_signIn")]
    partial class signIn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("GardenApi.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("GardenApi.Models.Garden", b =>
                {
                    b.Property<int>("GardenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("GridQty")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Size")
                        .HasColumnType("longtext");

                    b.HasKey("GardenId");

                    b.ToTable("Gardens");
                });

            modelBuilder.Entity("GardenApi.Models.Grid", b =>
                {
                    b.Property<int>("GridId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("GardenId")
                        .HasColumnType("int");

                    b.Property<string>("LocationCode")
                        .HasColumnType("longtext");

                    b.HasKey("GridId");

                    b.HasIndex("GardenId");

                    b.ToTable("Grids");
                });

            modelBuilder.Entity("GardenApi.Models.GridSeed", b =>
                {
                    b.Property<int>("GridSeedId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("GridId")
                        .HasColumnType("int");

                    b.Property<int>("SeedId")
                        .HasColumnType("int");

                    b.HasKey("GridSeedId");

                    b.HasIndex("GridId");

                    b.HasIndex("SeedId");

                    b.ToTable("GridSeeds");
                });

            modelBuilder.Entity("GardenApi.Models.Seed", b =>
                {
                    b.Property<int>("SeedId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DatePlanted")
                        .HasColumnType("longtext");

                    b.Property<string>("DaysToGerminate")
                        .HasColumnType("longtext");

                    b.Property<int>("DaysToHarvest")
                        .HasColumnType("int");

                    b.Property<string>("DepthToSow")
                        .HasColumnType("longtext");

                    b.Property<string>("Information")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("PhotoUrl")
                        .HasColumnType("longtext");

                    b.Property<string>("PlantingDates")
                        .HasColumnType("longtext");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("Results")
                        .HasColumnType("longtext");

                    b.Property<string>("RowSpacing")
                        .HasColumnType("longtext");

                    b.Property<string>("SeedSpacing")
                        .HasColumnType("longtext");

                    b.Property<string>("Status")
                        .HasColumnType("longtext");

                    b.Property<string>("Type")
                        .HasColumnType("longtext");

                    b.Property<int>("Yield")
                        .HasColumnType("int");

                    b.HasKey("SeedId");

                    b.ToTable("Seeds");

                    b.HasData(
                        new
                        {
                            SeedId = 1,
                            DatePlanted = "2-14-2024",
                            DaysToGerminate = "5-10",
                            DaysToHarvest = 45,
                            DepthToSow = "1/4-1/2 in",
                            Information = "The Hakurei Turnip (a.k.a Tokyo Turnip) variety is usually stark white and has an unmatched crispness and tender sweetness. This turnip is commonly eaten raw which has led to it being given the nickname of 'Salad Turnip'.",
                            Name = "Hakurei Turnip",
                            PhotoUrl = "https://cdn.mos.cms.futurecdn.net/HMr9ceyW7Sc2kuz2S3dNF5.jpg",
                            PlantingDates = "spring, fall, winter",
                            Quantity = 10,
                            Results = "n/a",
                            RowSpacing = "12-24in",
                            SeedSpacing = "2 in",
                            Status = "planted",
                            Type = "vegetable",
                            Yield = 5
                        });
                });

            modelBuilder.Entity("GardenApi.Models.SeedTag", b =>
                {
                    b.Property<int>("SeedTagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("SeedId")
                        .HasColumnType("int");

                    b.Property<int>("TagId")
                        .HasColumnType("int");

                    b.HasKey("SeedTagId");

                    b.HasIndex("SeedId");

                    b.HasIndex("TagId");

                    b.ToTable("SeedTags");
                });

            modelBuilder.Entity("GardenApi.Models.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NameTag")
                        .HasColumnType("longtext");

                    b.HasKey("TagId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("GardenApi.Models.Grid", b =>
                {
                    b.HasOne("GardenApi.Models.Garden", "Garden")
                        .WithMany("Grids")
                        .HasForeignKey("GardenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Garden");
                });

            modelBuilder.Entity("GardenApi.Models.GridSeed", b =>
                {
                    b.HasOne("GardenApi.Models.Grid", "Grid")
                        .WithMany("GridSeeds")
                        .HasForeignKey("GridId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GardenApi.Models.Seed", "Seed")
                        .WithMany("GridSeeds")
                        .HasForeignKey("SeedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Grid");

                    b.Navigation("Seed");
                });

            modelBuilder.Entity("GardenApi.Models.SeedTag", b =>
                {
                    b.HasOne("GardenApi.Models.Seed", "Seed")
                        .WithMany("SeedTags")
                        .HasForeignKey("SeedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GardenApi.Models.Tag", "Tag")
                        .WithMany("SeedTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Seed");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("GardenApi.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("GardenApi.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GardenApi.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("GardenApi.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GardenApi.Models.Garden", b =>
                {
                    b.Navigation("Grids");
                });

            modelBuilder.Entity("GardenApi.Models.Grid", b =>
                {
                    b.Navigation("GridSeeds");
                });

            modelBuilder.Entity("GardenApi.Models.Seed", b =>
                {
                    b.Navigation("GridSeeds");

                    b.Navigation("SeedTags");
                });

            modelBuilder.Entity("GardenApi.Models.Tag", b =>
                {
                    b.Navigation("SeedTags");
                });
#pragma warning restore 612, 618
        }
    }
}
