﻿// <auto-generated />
using MegaDesk.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MegaDesk.Migrations
{
    [DbContext(typeof(MegaDeskContext))]
    partial class MegaDeskContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MegaDesk.Models.Desk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("depth")
                        .HasColumnType("float");

                    b.Property<int>("drawers")
                        .HasColumnType("int");

                    b.Property<int>("surfaceMaterialid")
                        .HasColumnType("int");

                    b.Property<double>("width")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("surfaceMaterialid");

                    b.ToTable("Desk");
                });

            modelBuilder.Entity("MegaDesk.Models.DeskQuote", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("customerName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<int>("deskid")
                        .HasColumnType("int");

                    b.Property<int>("rushID")
                        .HasColumnType("int");

                    b.Property<double>("totalQuote")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("deskid");

                    b.ToTable("DeskQuote");
                });

            modelBuilder.Entity("MegaDesk.Models.RushType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("tier1Cost")
                        .HasColumnType("real");

                    b.Property<float>("tier2Cost")
                        .HasColumnType("real");

                    b.Property<float>("tier3Cost")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("RushType");
                });

            modelBuilder.Entity("MegaDesk.Models.SurfaceMaterial", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Cost")
                        .HasColumnType("real");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("ImageFile")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("SurfaceMaterial");
                });

            modelBuilder.Entity("MegaDesk.Models.Desk", b =>
                {
                    b.HasOne("MegaDesk.Models.SurfaceMaterial", "surfaceMaterial")
                        .WithMany()
                        .HasForeignKey("surfaceMaterialid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MegaDesk.Models.DeskQuote", b =>
                {
                    b.HasOne("MegaDesk.Models.Desk", "desk")
                        .WithMany()
                        .HasForeignKey("deskid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
