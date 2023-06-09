﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using backend.Data;

#nullable disable

namespace backend.Migrations
{
    [DbContext(typeof(WattAppDBContext))]
    [Migration("20230527134833_new_table")]
    partial class new_table
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("backend.Models.AutoTurnOnOff", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("dateOff")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("dateOn")
                        .HasColumnType("TEXT");

                    b.Property<int>("linkerId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("timeOff")
                        .HasColumnType("INTEGER");

                    b.Property<int>("timeOn")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("autoTurnOnOffs");
                });

            modelBuilder.Entity("backend.Models.Device", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<double>("consumption")
                        .HasColumnType("REAL");

                    b.Property<string>("manufacturer")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("model")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("subType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("devices");
                });

            modelBuilder.Entity("backend.Models.Dso", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("companyName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ownerFirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ownerLastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("role")
                        .HasColumnType("INTEGER");

                    b.Property<string>("token")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("dsos");
                });

            modelBuilder.Entity("backend.Models.Linker", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("access")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("control")
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("deviceId")
                        .HasColumnType("TEXT");

                    b.Property<string>("prosumerDeviceName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("prosumerId")
                        .HasColumnType("TEXT");

                    b.Property<bool>("simulation")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("work")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("linkers");
                });

            modelBuilder.Entity("backend.Models.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<Guid>("dsoId")
                        .HasColumnType("TEXT");

                    b.Property<string>("notificationType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("prosumerId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("notifications");
                });

            modelBuilder.Entity("backend.Models.Prosumer", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("city")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("idDso")
                        .HasColumnType("TEXT");

                    b.Property<string>("image")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("phoneNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("role")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("simulation")
                        .HasColumnType("INTEGER");

                    b.Property<string>("token")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("x")
                        .HasColumnType("REAL");

                    b.Property<double>("y")
                        .HasColumnType("REAL");

                    b.HasKey("id");

                    b.ToTable("prosumers");
                });

            modelBuilder.Entity("backend.Models.Record", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<double>("currentConsumption")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("date")
                        .HasColumnType("TEXT");

                    b.Property<int>("linkerId")
                        .HasColumnType("INTEGER");

                    b.Property<double>("prediction")
                        .HasColumnType("REAL");

                    b.Property<bool>("simulaiton")
                        .HasColumnType("INTEGER");

                    b.Property<int>("timeStamp")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("records");
                });

            modelBuilder.Entity("backend.Models.RecordStatus", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<double>("currentConsumption")
                        .HasColumnType("REAL");

                    b.Property<DateTime?>("endDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("linkerId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("startDate")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("recordStatus");
                });
#pragma warning restore 612, 618
        }
    }
}
