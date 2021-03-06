// <auto-generated />
using System;
using Lab1_UnitTest.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Models.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20210425100208_MigratData")]
    partial class MigratData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lab1_UnitTest.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Role");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RoleName = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            RoleName = "user"
                        });
                });

            modelBuilder.Entity("Lab1_UnitTest.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserName = "Salma"
                        },
                        new
                        {
                            Id = 2,
                            UserName = "Rehab"
                        });
                });

            modelBuilder.Entity("Lab1_UnitTest.Models.User_Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RId")
                        .HasColumnType("int");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<int>("UId")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("User_Role");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RId = 1,
                            UId = 2
                        },
                        new
                        {
                            Id = 2,
                            RId = 2,
                            UId = 1
                        });
                });

            modelBuilder.Entity("Lab1_UnitTest.Models.User_Role", b =>
                {
                    b.HasOne("Lab1_UnitTest.Models.Role", "Role")
                        .WithMany("User_Roles")
                        .HasForeignKey("RoleId");

                    b.HasOne("Lab1_UnitTest.Models.User", "User")
                        .WithMany("User_Roles")
                        .HasForeignKey("UserId");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Lab1_UnitTest.Models.Role", b =>
                {
                    b.Navigation("User_Roles");
                });

            modelBuilder.Entity("Lab1_UnitTest.Models.User", b =>
                {
                    b.Navigation("User_Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
