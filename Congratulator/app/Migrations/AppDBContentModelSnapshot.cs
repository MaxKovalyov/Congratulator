﻿// <auto-generated />
using Congratulator.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Congratulator.Migrations
{
    [DbContext(typeof(AppDBContent))]
    partial class AppDBContentModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Congratulator.Models.Person", b =>
                {
                    b.Property<string>("name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("dayBirth")
                        .HasColumnType("int");

                    b.Property<int>("monthBirth")
                        .HasColumnType("int");

                    b.Property<string>("urlImg")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("name");

                    b.ToTable("Person");
                });
#pragma warning restore 612, 618
        }
    }
}
