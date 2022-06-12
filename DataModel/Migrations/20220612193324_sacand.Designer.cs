﻿// <auto-generated />
using System;
using DataModel.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Batabase.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220612193324_sacand")]
    partial class sacand
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Batabase.Entities.Catogery", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Catogery");
                });

            modelBuilder.Entity("Batabase.Entities.Standard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Fk_SubCatogery")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Fk_SubCatogery");

                    b.ToTable("Standard");
                });

            modelBuilder.Entity("Batabase.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("user");
                });

            modelBuilder.Entity("Batabase.Entities.UserStanderFils", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Fk_UserStander")
                        .HasColumnType("int");

                    b.Property<int>("Ids")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Fk_UserStander");

                    b.ToTable("UserStanderFils");
                });

            modelBuilder.Entity("Batabase.Entities.User_Standerd", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ChosetoImprove")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DalilName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Fk_Standard")
                        .HasColumnType("int");

                    b.Property<int?>("Fk_Teacher")
                        .HasColumnType("int");

                    b.Property<int?>("Fk_User")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pointOfStrong")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Fk_Standard");

                    b.HasIndex("Fk_Teacher");

                    b.HasIndex("Fk_User");

                    b.ToTable("User_Standerd");
                });

            modelBuilder.Entity("Batabase.Entities.subCatogery", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Fk_Catogery")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Fk_Catogery");

                    b.ToTable("subCatogery");
                });

            modelBuilder.Entity("Batabase.Entities.Standard", b =>
                {
                    b.HasOne("Batabase.Entities.subCatogery", "subCatogery")
                        .WithMany()
                        .HasForeignKey("Fk_SubCatogery");

                    b.Navigation("subCatogery");
                });

            modelBuilder.Entity("Batabase.Entities.UserStanderFils", b =>
                {
                    b.HasOne("Batabase.Entities.User_Standerd", "User_Standerd")
                        .WithMany()
                        .HasForeignKey("Fk_UserStander");

                    b.Navigation("User_Standerd");
                });

            modelBuilder.Entity("Batabase.Entities.User_Standerd", b =>
                {
                    b.HasOne("Batabase.Entities.Standard", "Standard")
                        .WithMany()
                        .HasForeignKey("Fk_Standard");

                    b.HasOne("Batabase.Entities.User", "Users")
                        .WithMany()
                        .HasForeignKey("Fk_Teacher");

                    b.HasOne("Batabase.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("Fk_User");

                    b.Navigation("Standard");

                    b.Navigation("User");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Batabase.Entities.subCatogery", b =>
                {
                    b.HasOne("Batabase.Entities.Catogery", "Catogery")
                        .WithMany()
                        .HasForeignKey("Fk_Catogery");

                    b.Navigation("Catogery");
                });
#pragma warning restore 612, 618
        }
    }
}
