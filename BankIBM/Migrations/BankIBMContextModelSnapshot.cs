﻿// <auto-generated />
using System;
using BankIBM.Datas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace BankIBM.Migrations
{
    [DbContext(typeof(BankIBMContext))]
    partial class BankIBMContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("BankIBM.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<decimal>("Balance")
                        .HasColumnType("numeric");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("NumberAccount")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .HasMaxLength(2147483647)
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("BankIBM.Models.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ClientDestinyID")
                        .HasColumnType("integer");

                    b.Property<int>("ClientSourceID")
                        .HasColumnType("integer");

                    b.Property<DateTime>("TransactionDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("TransactionType")
                        .HasColumnType("text");

                    b.Property<decimal>("Value")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("ClientDestinyID");

                    b.HasIndex("ClientSourceID");

                    b.ToTable("Transactions");
                });

            modelBuilder.Entity("BankIBM.Models.Transaction", b =>
                {
                    b.HasOne("BankIBM.Models.Client", "ClientDestiny")
                        .WithMany("ClientDestiny")
                        .HasForeignKey("ClientDestinyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BankIBM.Models.Client", "ClientSource")
                        .WithMany("ClientSource")
                        .HasForeignKey("ClientSourceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClientDestiny");

                    b.Navigation("ClientSource");
                });

            modelBuilder.Entity("BankIBM.Models.Client", b =>
                {
                    b.Navigation("ClientDestiny");

                    b.Navigation("ClientSource");
                });
#pragma warning restore 612, 618
        }
    }
}
