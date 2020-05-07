﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcFormulario.Data;

namespace MvcFormulario.Migrations
{
    [DbContext(typeof(MvcFormularioContext))]
    partial class MvcFormularioContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3");

            modelBuilder.Entity("MvcFormulario.Models.Formulario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Age")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CDivision")
                        .HasColumnType("TEXT");

                    b.Property<string>("Character")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<string>("Game")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gamertag")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gender")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("ODivision")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PremiumService")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Servername")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Formulario");
                });
#pragma warning restore 612, 618
        }
    }
}