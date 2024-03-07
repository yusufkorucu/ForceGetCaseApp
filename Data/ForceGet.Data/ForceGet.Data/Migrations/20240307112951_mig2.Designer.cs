﻿// <auto-generated />
using ForceGet.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ForceGet.Context.Migrations
{
    [DbContext(typeof(ForceGetContext))]
    [Migration("20240307112951_mig2")]
    partial class mig2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("ForceGet.Entity.Entites.City", b =>
                {
                    b.Property<int>("CityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CityId"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("CityId");

                    b.HasIndex("CountryId");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("ForceGet.Entity.Entites.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CountryId"));

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("ForceGet.Entity.Entites.Currency", b =>
                {
                    b.Property<int>("CurrencyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CurrencyId"));

                    b.Property<string>("Code")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("CurrencyId");

                    b.ToTable("Currencies");
                });

            modelBuilder.Entity("ForceGet.Entity.Entites.ShippingInfo", b =>
                {
                    b.Property<int>("ShippingInfoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ShippingInfoId"));

                    b.Property<int>("CityId")
                        .HasColumnType("int");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<int>("CurrencyId")
                        .HasColumnType("int");

                    b.Property<int>("Incoterms")
                        .HasColumnType("int");

                    b.Property<int>("Mode")
                        .HasColumnType("int");

                    b.Property<int>("MovementType")
                        .HasColumnType("int");

                    b.Property<int>("PackageType")
                        .HasColumnType("int");

                    b.Property<int>("Unit1Id")
                        .HasColumnType("int");

                    b.Property<int>("Unit1Size")
                        .HasColumnType("int");

                    b.Property<int>("Unit2Id")
                        .HasColumnType("int");

                    b.Property<int>("Unit2Size")
                        .HasColumnType("int");

                    b.HasKey("ShippingInfoId");

                    b.HasIndex("CityId");

                    b.HasIndex("CountryId");

                    b.HasIndex("CurrencyId");

                    b.HasIndex("Unit1Id");

                    b.HasIndex("Unit2Id");

                    b.ToTable("ShippingInfos");
                });

            modelBuilder.Entity("ForceGet.Entity.Entites.Unit1", b =>
                {
                    b.Property<int>("Unit1Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Unit1Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Unit1Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Unit1");
                });

            modelBuilder.Entity("ForceGet.Entity.Entites.Unit2", b =>
                {
                    b.Property<int>("Unit2Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Unit2Id"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("Unit2Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Unit2");
                });

            modelBuilder.Entity("ForceGet.Entity.Entites.City", b =>
                {
                    b.HasOne("ForceGet.Entity.Entites.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("ForceGet.Entity.Entites.ShippingInfo", b =>
                {
                    b.HasOne("ForceGet.Entity.Entites.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ForceGet.Entity.Entites.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ForceGet.Entity.Entites.Currency", "Currency")
                        .WithMany()
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ForceGet.Entity.Entites.Unit1", "Unit1")
                        .WithMany()
                        .HasForeignKey("Unit1Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ForceGet.Entity.Entites.Unit2", "Unit2")
                        .WithMany()
                        .HasForeignKey("Unit2Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Country");

                    b.Navigation("Currency");

                    b.Navigation("Unit1");

                    b.Navigation("Unit2");
                });

            modelBuilder.Entity("ForceGet.Entity.Entites.Unit1", b =>
                {
                    b.HasOne("ForceGet.Entity.Entites.Country", "Country")
                        .WithMany("Units1")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("ForceGet.Entity.Entites.Unit2", b =>
                {
                    b.HasOne("ForceGet.Entity.Entites.Country", "Country")
                        .WithMany("Units2")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("ForceGet.Entity.Entites.Country", b =>
                {
                    b.Navigation("Cities");

                    b.Navigation("Units1");

                    b.Navigation("Units2");
                });
#pragma warning restore 612, 618
        }
    }
}
