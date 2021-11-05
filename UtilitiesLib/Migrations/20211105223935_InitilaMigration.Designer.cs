﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UtilitiesLib.DB;

namespace UtilitiesLib.Migrations
{
    [DbContext(typeof(GameDbContext))]
    [Migration("20211105223935_InitilaMigration")]
    partial class InitilaMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UtilitiesLib.DB.PlayerRound", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("gameID")
                        .HasColumnType("int");

                    b.Property<string>("playerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("score")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("PlayerRounds");
                });

            modelBuilder.Entity("UtilitiesLib.DB.Round", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("amountOfPlayers")
                        .HasColumnType("int");

                    b.Property<int>("gameID")
                        .HasColumnType("int");

                    b.Property<int>("highestScore")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Rounds");
                });
#pragma warning restore 612, 618
        }
    }
}
