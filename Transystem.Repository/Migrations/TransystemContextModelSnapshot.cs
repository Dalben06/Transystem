﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Transystem.Repository.Datas;

namespace Transystem.Repository.Migrations
{
    [DbContext(typeof(TransystemContext))]
    partial class TransystemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("Transystem.Domain.Entitys.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ClientId");

                    b.Property<string>("Complement");

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime?>("DeleteDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Number");

                    b.Property<string>("Street");

                    b.Property<DateTime>("UpdateDate");

                    b.Property<string>("ZipCode");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Transystem.Domain.Entitys.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime?>("DeleteDate");

                    b.Property<string>("DocumentNumber");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsTypePerson");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Transystem.Domain.Entitys.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BirthDate");

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime?>("DeleteDate");

                    b.Property<string>("DocumentNumber");

                    b.Property<string>("DriverLicense");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("Driver");
                });

            modelBuilder.Entity("Transystem.Domain.Entitys.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClientId");

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime?>("DeleteDate");

                    b.Property<int>("DriverId");

                    b.Property<DateTime>("EndDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("StartDate");

                    b.Property<int?>("TypeId");

                    b.Property<DateTime>("UpdateDate");

                    b.HasKey("Id");

                    b.HasIndex("TypeId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Transystem.Domain.Entitys.Trailer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime?>("DeleteDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<int>("TruckId");

                    b.Property<DateTime>("UpdateDate");

                    b.HasKey("Id");

                    b.HasIndex("TruckId");

                    b.ToTable("Trailer");
                });

            modelBuilder.Entity("Transystem.Domain.Entitys.Truck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime?>("DeleteDate");

                    b.Property<int>("DriverId");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ModelTruck");

                    b.Property<string>("PlaceTruck");

                    b.Property<DateTime>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("Truck");
                });

            modelBuilder.Entity("Transystem.Domain.Entitys.TypeOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime?>("DeleteDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<DateTime>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("TypeOrder");
                });

            modelBuilder.Entity("Transystem.Domain.Entitys.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateDate");

                    b.Property<DateTime?>("DeleteDate");

                    b.Property<string>("DocumentNumber");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Login");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<DateTime>("UpdateDate");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Transystem.Domain.Entitys.Address", b =>
                {
                    b.HasOne("Transystem.Domain.Entitys.Client")
                        .WithMany("Addresses")
                        .HasForeignKey("ClientId");
                });

            modelBuilder.Entity("Transystem.Domain.Entitys.Order", b =>
                {
                    b.HasOne("Transystem.Domain.Entitys.TypeOrder", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");
                });

            modelBuilder.Entity("Transystem.Domain.Entitys.Trailer", b =>
                {
                    b.HasOne("Transystem.Domain.Entitys.Truck")
                        .WithMany("Trailers")
                        .HasForeignKey("TruckId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
