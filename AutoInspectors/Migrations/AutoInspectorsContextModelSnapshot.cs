﻿// <auto-generated />
using AutoInspectors.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AutoInspectors.Migrations
{
    [DbContext(typeof(AutoInspectorsContext))]
    partial class AutoInspectorsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AutoInspectors.Models.Inspection", b =>
                {
                    b.Property<int>("InspectionID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AirFilter")
                        .HasMaxLength(100);

                    b.Property<string>("AlternatorTest")
                        .HasMaxLength(100);

                    b.Property<string>("BatteryTest")
                        .HasMaxLength(100);

                    b.Property<string>("BrakeFluid")
                        .HasMaxLength(100);

                    b.Property<string>("CoolantLevel")
                        .HasMaxLength(100);

                    b.Property<string>("CoolantPH")
                        .HasMaxLength(100);

                    b.Property<string>("DTCCode");

                    b.Property<string>("EngineOil")
                        .HasMaxLength(100);

                    b.Property<string>("FrontBrakes")
                        .HasMaxLength(200);

                    b.Property<string>("Hoses")
                        .HasMaxLength(100);

                    b.Property<string>("Inspector")
                        .IsRequired();

                    b.Property<string>("RearBrakes")
                        .HasMaxLength(200);

                    b.Property<string>("TireRotation")
                        .HasMaxLength(100);

                    b.Property<string>("TransmissionFluid")
                        .HasMaxLength(100);

                    b.Property<int>("VehicleID");

                    b.Property<string>("Wires")
                        .HasMaxLength(100);

                    b.HasKey("InspectionID");

                    b.HasIndex("VehicleID");

                    b.ToTable("Inspection");
                });

            modelBuilder.Entity("AutoInspectors.Models.Vehicle", b =>
                {
                    b.Property<int>("VehicleID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("EngineSize")
                        .IsRequired();

                    b.Property<string>("LicensePlate")
                        .IsRequired()
                        .HasMaxLength(7);

                    b.Property<string>("Make")
                        .IsRequired();

                    b.Property<int>("Mileage");

                    b.Property<string>("Model")
                        .IsRequired();

                    b.Property<string>("TransmissionType")
                        .IsRequired();

                    b.Property<string>("VIN")
                        .IsRequired()
                        .HasMaxLength(17);

                    b.Property<int>("Year");

                    b.HasKey("VehicleID");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("AutoInspectors.Models.Inspection", b =>
                {
                    b.HasOne("AutoInspectors.Models.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
