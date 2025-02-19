﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ibreca_data_access.Contexts.IbrecaDB;

namespace ibreca_data_access.Migrations
{
    [DbContext(typeof(IbrecaDBContext))]
    [Migration("20211216203321_change_table_name")]
    partial class change_table_name
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("ibreca_data_access.Contexts.IbrecaDB.Models.BlogEntry", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Body")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CoverUrl")
                        .HasColumnType("varchar(256)");

                    b.Property<string>("HeaderUrl")
                        .HasColumnType("varchar(256)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id")
                        .HasName("pk_blogentries");

                    b.ToTable("blogentries");
                });
#pragma warning restore 612, 618
        }
    }
}
