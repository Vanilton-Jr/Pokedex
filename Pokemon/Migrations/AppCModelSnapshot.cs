﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pokemon.Data;

#nullable disable

namespace Pokemon.Migrations
{
    [DbContext(typeof(AppC))]
    partial class AppCModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Pokemon.Models.Pokedex", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("Default")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Descr")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Peso")
                        .HasColumnType("float");

                    b.Property<byte[]>("Shiny")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Tipo1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tipo2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("altura")
                        .HasColumnType("float");

                    b.Property<int?>("atk")
                        .HasColumnType("int");

                    b.Property<int?>("atkE")
                        .HasColumnType("int");

                    b.Property<int?>("dfs")
                        .HasColumnType("int");

                    b.Property<int?>("dfsE")
                        .HasColumnType("int");

                    b.Property<int?>("hp")
                        .HasColumnType("int");

                    b.Property<byte[]>("mega")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("move1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("move2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("move3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("move4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("move5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("move6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("move7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("move8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("num")
                        .HasColumnType("int");

                    b.Property<string>("sp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("vel")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Pokedex");
                });
#pragma warning restore 612, 618
        }
    }
}
