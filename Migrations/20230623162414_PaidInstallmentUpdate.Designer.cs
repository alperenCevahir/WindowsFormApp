﻿// <auto-generated />
using System;
using KuzeyYildizi.Classes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KuzeyYildizi.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20230623162414_PaidInstallmentUpdate")]
    partial class PaidInstallmentUpdate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("KuzeyYildizi.Classes.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("BirthPlaceAndYear")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BloodType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Cash")
                        .HasColumnType("bit");

                    b.Property<bool>("CreditCard")
                        .HasColumnType("bit");

                    b.Property<string>("Diseases")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emergency1NameSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emergency1Relativity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emergency1TelNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emergency2NameSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emergency2Relativity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emergency2TelNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emergency3NameSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emergency3Relativity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Emergency3TelNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherIsCustodian")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherNameSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherOccupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherTc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherTelNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IncludeFood")
                        .HasColumnType("bit");

                    b.Property<int>("Installment")
                        .HasColumnType("int");

                    b.Property<bool>("IsFatherAlive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsMotherAlive")
                        .HasColumnType("bit");

                    b.Property<string>("Medicines")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherIsCustodian")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherNameSurname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherOccupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherTc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherTelNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PaidInstallment")
                        .HasColumnType("int");

                    b.Property<bool>("ParentsLiveTogether")
                        .HasColumnType("bit");

                    b.Property<string>("PaymentWeek")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("School")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("StudentGender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentGrade")
                        .HasColumnType("int");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TcNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.Property<bool>("Transfer")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("students");
                });
#pragma warning restore 612, 618
        }
    }
}
