﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using pruebahotel.Data;

namespace pruebahotel.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241204030802_PublisherAdded")]
    partial class PublisherAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("pruebahotel.Data.Models.Habitacion", b =>
                {
                    b.Property<int>("Id_habitacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Numero_habitacion")
                        .HasColumnType("int");

                    b.Property<int>("capacidad")
                        .HasColumnType("int");

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("hotelid_hotel")
                        .HasColumnType("int");

                    b.Property<int>("id_hotel")
                        .HasColumnType("int");

                    b.Property<int>("precio_noche")
                        .HasColumnType("int");

                    b.Property<string>("tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id_habitacion");

                    b.HasIndex("hotelid_hotel");

                    b.ToTable("habitaciones");
                });

            modelBuilder.Entity("pruebahotel.Data.Models.Hotel", b =>
                {
                    b.Property<int>("id_hotel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("horarios")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("telefono")
                        .HasColumnType("int");

                    b.HasKey("id_hotel");

                    b.ToTable("hotels");
                });

            modelBuilder.Entity("pruebahotel.Data.Models.Usuario", b =>
                {
                    b.Property<int>("id_usuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("NumTel")
                        .HasColumnType("int");

                    b.Property<string>("apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rol")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_usuario");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("pruebahotel.Data.Models.reservaciones", b =>
                {
                    b.Property<int>("id_reservacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fecha_final")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fecha_inicio")
                        .HasColumnType("datetime2");

                    b.Property<int?>("habitacionId_habitacion")
                        .HasColumnType("int");

                    b.Property<int>("id_habitacion")
                        .HasColumnType("int");

                    b.Property<int>("id_usuario")
                        .HasColumnType("int");

                    b.Property<int>("total_pagado")
                        .HasColumnType("int");

                    b.Property<int?>("usuarioid_usuario")
                        .HasColumnType("int");

                    b.HasKey("id_reservacion");

                    b.HasIndex("habitacionId_habitacion");

                    b.HasIndex("usuarioid_usuario");

                    b.ToTable("Reservaciones");
                });

            modelBuilder.Entity("pruebahotel.Data.Models.Habitacion", b =>
                {
                    b.HasOne("pruebahotel.Data.Models.Hotel", "hotel")
                        .WithMany("habitaciones")
                        .HasForeignKey("hotelid_hotel");

                    b.Navigation("hotel");
                });

            modelBuilder.Entity("pruebahotel.Data.Models.reservaciones", b =>
                {
                    b.HasOne("pruebahotel.Data.Models.Habitacion", "habitacion")
                        .WithMany()
                        .HasForeignKey("habitacionId_habitacion");

                    b.HasOne("pruebahotel.Data.Models.Usuario", "usuario")
                        .WithMany("reservaciones")
                        .HasForeignKey("usuarioid_usuario");

                    b.Navigation("habitacion");

                    b.Navigation("usuario");
                });

            modelBuilder.Entity("pruebahotel.Data.Models.Hotel", b =>
                {
                    b.Navigation("habitaciones");
                });

            modelBuilder.Entity("pruebahotel.Data.Models.Usuario", b =>
                {
                    b.Navigation("reservaciones");
                });
#pragma warning restore 612, 618
        }
    }
}