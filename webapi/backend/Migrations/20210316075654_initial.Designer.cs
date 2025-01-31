﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using backend.models;

namespace backend.Migrations
{
    [DbContext(typeof(TasinmazContext))]
    [Migration("20210316075654_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("backend.models.Il", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Ad")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Iller");
                });

            modelBuilder.Entity("backend.models.Ilce", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Ad")
                        .HasColumnType("text");

                    b.Property<int>("IlId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IlId");

                    b.ToTable("Ilceler");
                });

            modelBuilder.Entity("backend.models.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Ad")
                        .HasColumnType("text");

                    b.Property<string>("Adres")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Rol")
                        .HasColumnType("text");

                    b.Property<string>("Sifre")
                        .HasColumnType("text");

                    b.Property<string>("Soyad")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Kullanicilar");
                });

            modelBuilder.Entity("backend.models.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Aciklama")
                        .HasColumnType("text");

                    b.Property<string>("Durum")
                        .HasColumnType("text");

                    b.Property<int>("Ip")
                        .HasColumnType("integer");

                    b.Property<string>("IslemTipi")
                        .HasColumnType("text");

                    b.Property<DateTime>("TarihSaat")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("Loglar");
                });

            modelBuilder.Entity("backend.models.Mahalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Ad")
                        .HasColumnType("text");

                    b.Property<int>("IlceId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("IlceId");

                    b.ToTable("Mahalleler");
                });

            modelBuilder.Entity("backend.models.Tasinmaz", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int>("Ada")
                        .HasColumnType("integer");

                    b.Property<int>("MahalleId")
                        .HasColumnType("integer");

                    b.Property<int>("Nitelik")
                        .HasColumnType("integer");

                    b.Property<int>("Parsel")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MahalleId");

                    b.ToTable("Tasinmazlar");
                });

            modelBuilder.Entity("backend.models.Ilce", b =>
                {
                    b.HasOne("backend.models.Il", "Il")
                        .WithMany()
                        .HasForeignKey("IlId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Il");
                });

            modelBuilder.Entity("backend.models.Mahalle", b =>
                {
                    b.HasOne("backend.models.Ilce", "Ilce")
                        .WithMany()
                        .HasForeignKey("IlceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ilce");
                });

            modelBuilder.Entity("backend.models.Tasinmaz", b =>
                {
                    b.HasOne("backend.models.Mahalle", "Mahalle")
                        .WithMany()
                        .HasForeignKey("MahalleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mahalle");
                });
#pragma warning restore 612, 618
        }
    }
}
