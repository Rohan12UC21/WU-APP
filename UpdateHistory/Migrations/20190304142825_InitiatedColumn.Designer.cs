﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UpdateHistory.Models;

namespace UpdateHistory.Migrations
{
    [DbContext(typeof(UpdateHistoryContext))]
    [Migration("20190304142825_InitiatedColumn")]
    partial class InitiatedColumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("UpdateHistory.Models.Info", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Active");

                    b.Property<string>("Architecture");

                    b.Property<string>("Classification");

                    b.Property<string>("ICW");

                    b.Property<string>("KBID");

                    b.Property<string>("LastReleased");

                    b.Property<string>("MSRCNumber");

                    b.Property<string>("MSRCSeverity");

                    b.Property<string>("Reason");

                    b.Property<string>("Server");

                    b.Property<string>("SupportedLanguages");

                    b.Property<string>("SupportedProducts");

                    b.Property<DateTime>("TestDate");

                    b.Property<string>("TestResults");

                    b.Property<string>("Title");

                    b.Property<string>("UpdateStatus");

                    b.Property<string>("updateID");

                    b.HasKey("ID");

                    b.ToTable("Info");
                });

            modelBuilder.Entity("UpdateHistory.Models.Server", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ICW");

                    b.Property<int>("Index");

                    b.Property<bool>("Initiated");

                    b.Property<string>("Location");

                    b.Property<string>("RealtimeVersion");

                    b.Property<string>("ServerName");

                    b.Property<string>("WindowsVersion");

                    b.Property<bool>("isIt");

                    b.HasKey("ID");

                    b.ToTable("Server");
                });
#pragma warning restore 612, 618
        }
    }
}
