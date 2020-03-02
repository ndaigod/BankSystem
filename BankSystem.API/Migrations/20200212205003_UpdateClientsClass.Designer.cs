﻿// <auto-generated />
using System;
using BankSystem.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BankSystem.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200212205003_UpdateClientsClass")]
    partial class UpdateClientsClass
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("BankSystem.API.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BirthPlace")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("TEXT");

                    b.Property<int?>("DisabilityId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("HomePhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("IdPassportNumber")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("IssuanceDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("IssuancePlace")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LivingPlaceAddress")
                        .HasColumnType("TEXT");

                    b.Property<int?>("LivingPlaceCityId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MaritalStatusId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MobilePhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("MoneyIncome")
                        .HasColumnType("TEXT");

                    b.Property<int?>("NationalityId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PassportNumber")
                        .HasColumnType("TEXT");

                    b.Property<string>("PassportSerie")
                        .HasColumnType("TEXT");

                    b.Property<string>("Patronymic")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ResidencePermitCityId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Retired")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Sex")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DisabilityId");

                    b.HasIndex("LivingPlaceCityId");

                    b.HasIndex("MaritalStatusId");

                    b.HasIndex("NationalityId");

                    b.HasIndex("ResidencePermitCityId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("BankSystem.API.Models.Disability", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Disability");
                });

            modelBuilder.Entity("BankSystem.API.Models.LivingPlaceCity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("LivingPlaceCities");
                });

            modelBuilder.Entity("BankSystem.API.Models.MaritalStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("MaritalStatus");
                });

            modelBuilder.Entity("BankSystem.API.Models.Nationality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Nationality");
                });

            modelBuilder.Entity("BankSystem.API.Models.ResidencePermitCity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ResidencePermitCity");
                });

            modelBuilder.Entity("BankSystem.API.Models.Client", b =>
                {
                    b.HasOne("BankSystem.API.Models.Disability", "Disability")
                        .WithMany()
                        .HasForeignKey("DisabilityId");

                    b.HasOne("BankSystem.API.Models.LivingPlaceCity", "LivingPlaceCity")
                        .WithMany()
                        .HasForeignKey("LivingPlaceCityId");

                    b.HasOne("BankSystem.API.Models.MaritalStatus", "MaritalStatus")
                        .WithMany()
                        .HasForeignKey("MaritalStatusId");

                    b.HasOne("BankSystem.API.Models.Nationality", "Nationality")
                        .WithMany()
                        .HasForeignKey("NationalityId");

                    b.HasOne("BankSystem.API.Models.ResidencePermitCity", "ResidencePermitCity")
                        .WithMany()
                        .HasForeignKey("ResidencePermitCityId");
                });
#pragma warning restore 612, 618
        }
    }
}
