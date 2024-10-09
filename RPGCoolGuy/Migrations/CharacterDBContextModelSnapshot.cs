﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RPGCoolGuy.Models;

#nullable disable

namespace RPGCoolGuy.Migrations
{
    [DbContext(typeof(CharacterDBContext))]
    partial class CharacterDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RPGCoolGuy.Models.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("Attack")
                        .HasColumnType("int");

                    b.Property<int?>("Defense")
                        .HasColumnType("int");

                    b.Property<int?>("HP")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Characters");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Attack = 20,
                            Defense = 20,
                            HP = 5,
                            Name = "Dave"
                        },
                        new
                        {
                            Id = 2,
                            Attack = 30,
                            Defense = 30,
                            HP = 1,
                            Name = "Tony"
                        },
                        new
                        {
                            Id = 3,
                            Attack = 99,
                            Defense = 99,
                            HP = 9999,
                            Name = "Peter Griffin"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
