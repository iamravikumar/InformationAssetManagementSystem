﻿// <auto-generated />
using System;
using IAMS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IAMS.Data.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20190723124815_CreateModels")]
    partial class CreateModels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("IAMS.Model.AuxiliaryComputer", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Admin");

                    b.Property<DateTime>("BorrowDateTime");

                    b.Property<string>("Borrower");

                    b.Property<DateTime>("BuyDateTime");

                    b.Property<double>("BuyPrice");

                    b.Property<string>("CPU");

                    b.Property<string>("Disk");

                    b.Property<string>("GPU");

                    b.Property<string>("MDSerialNumber");

                    b.Property<string>("Memory");

                    b.Property<string>("Model");

                    b.Property<string>("NameNumber");

                    b.Property<DateTime>("ReturnDateTime");

                    b.Property<string>("Returner");

                    b.Property<string>("SSDSerialNumber");

                    b.Property<string>("Size");

                    b.Property<string>("Use");

                    b.Property<string>("WiredMAC");

                    b.Property<string>("WirelessMAC");

                    b.HasKey("ID");

                    b.ToTable("AuxiliaryComputers");
                });

            modelBuilder.Entity("IAMS.Model.DesktopComputer", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Admin");

                    b.Property<DateTime>("BuyDateTime");

                    b.Property<double>("BuyPrice");

                    b.Property<string>("CPU");

                    b.Property<string>("Disk");

                    b.Property<string>("GPU");

                    b.Property<string>("MAC");

                    b.Property<string>("MDSerialNumber");

                    b.Property<string>("Memory");

                    b.Property<string>("Model");

                    b.Property<string>("NameNumber");

                    b.Property<string>("SSDSerialNumber");

                    b.Property<string>("Size");

                    b.Property<string>("Use");

                    b.Property<string>("User");

                    b.HasKey("ID");

                    b.ToTable("DesktopComputers");
                });

            modelBuilder.Entity("IAMS.Model.LaptopComputer", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Admin");

                    b.Property<DateTime>("BuyDateTime");

                    b.Property<double>("BuyPrice");

                    b.Property<string>("CPU");

                    b.Property<string>("Disk");

                    b.Property<string>("GPU");

                    b.Property<string>("MDSerialNumber");

                    b.Property<string>("Memory");

                    b.Property<string>("Model");

                    b.Property<string>("NameNumber");

                    b.Property<string>("SSDSerialNumber");

                    b.Property<string>("Size");

                    b.Property<string>("Use");

                    b.Property<string>("User");

                    b.Property<string>("WiredMAC");

                    b.Property<string>("WirelessMAC");

                    b.HasKey("ID");

                    b.ToTable("LaptopComputers");
                });

            modelBuilder.Entity("IAMS.Model.OtherEquipment", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Admin");

                    b.Property<DateTime>("BuyDateTime");

                    b.Property<double>("BuyPrice");

                    b.Property<string>("ManagementDepartment");

                    b.Property<string>("Model");

                    b.Property<string>("NameNumber");

                    b.Property<string>("Use");

                    b.HasKey("ID");

                    b.ToTable("OtherEquipments");
                });

            modelBuilder.Entity("IAMS.Model.Person", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Department");

                    b.Property<string>("IDNumber");

                    b.Property<string>("InnerNetComputerIP");

                    b.Property<string>("InnerNetComputerNumber");

                    b.Property<string>("Job");

                    b.Property<string>("Name");

                    b.Property<string>("OuterNetComputerIP");

                    b.Property<string>("OuterNetComputerNumber");

                    b.HasKey("ID");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("IAMS.Model.RoomEquipment", b =>
                {
                    b.Property<string>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Admin");

                    b.Property<DateTime>("BuyDateTime");

                    b.Property<double>("BuyPrice");

                    b.Property<string>("Location");

                    b.Property<string>("Model");

                    b.Property<string>("NameNumber");

                    b.Property<string>("Use");

                    b.Property<string>("User");

                    b.HasKey("ID");

                    b.ToTable("RoomEquipments");
                });
#pragma warning restore 612, 618
        }
    }
}