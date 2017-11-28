﻿// <auto-generated />
using Birthday.EntityFrameworkCore;
using Birthday.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Birthday.Migrations
{
    [DbContext(typeof(BirthdayDbContext))]
    partial class BirthdayDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("Birthday.Persons.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Birthday_Lunar");

                    b.Property<DateTime>("Birthday_Solar");

                    b.Property<DateTime>("CreationTime");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.Property<string>("PhoneNum");

                    b.Property<string>("RelationShip")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("Birthday.Users.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Astro");

                    b.Property<DateTime>("CreationTime");

                    b.Property<long?>("CreatorUserId");

                    b.Property<long?>("DeleterUserId");

                    b.Property<DateTime?>("DeletionTime");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("LastModificationTime");

                    b.Property<long?>("LastModifierUserId");

                    b.Property<string>("Nickname");

                    b.Property<Guid?>("PersonId");

                    b.Property<string>("PhoneNum")
                        .IsRequired();

                    b.Property<string>("Pwd")
                        .IsRequired();

                    b.Property<int>("Sex");

                    b.HasKey("Id");

                    b.HasIndex("PersonId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Birthday.Users.User", b =>
                {
                    b.HasOne("Birthday.Persons.Person", "DetailInfo")
                        .WithMany()
                        .HasForeignKey("PersonId");
                });
#pragma warning restore 612, 618
        }
    }
}
