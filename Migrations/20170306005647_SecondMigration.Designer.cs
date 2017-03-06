using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ASPNETCOREDATABASE.Models;

namespace ASPNETCOREDATABASE.Migrations
{
    [DbContext(typeof(InventoryContext))]
    [Migration("20170306005647_SecondMigration")]
    partial class SecondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752");

            modelBuilder.Entity("ASPNETCOREDATABASE.Models.Detail", b =>
                {
                    b.Property<int>("DetailId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int?>("InventoryId");

                    b.Property<int>("Quantity");

                    b.Property<int>("UPC");

                    b.HasKey("DetailId");

                    b.HasIndex("InventoryId");

                    b.ToTable("Details");
                });

            modelBuilder.Entity("ASPNETCOREDATABASE.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EmployeeNumber");

                    b.Property<string>("FirstName");

                    b.Property<int?>("InventoryId");

                    b.Property<string>("LastName");

                    b.HasKey("EmployeeId");

                    b.HasIndex("InventoryId");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("ASPNETCOREDATABASE.Models.Inventory", b =>
                {
                    b.Property<int>("InventoryId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("InventoryId");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("ASPNETCOREDATABASE.Models.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("InventoryId");

                    b.Property<string>("PaymentMethod");

                    b.Property<string>("State");

                    b.Property<double>("Tax");

                    b.HasKey("PaymentId");

                    b.HasIndex("InventoryId");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("ASPNETCOREDATABASE.Models.Detail", b =>
                {
                    b.HasOne("ASPNETCOREDATABASE.Models.Inventory", "Inventory")
                        .WithMany("Detail")
                        .HasForeignKey("InventoryId");
                });

            modelBuilder.Entity("ASPNETCOREDATABASE.Models.Employee", b =>
                {
                    b.HasOne("ASPNETCOREDATABASE.Models.Inventory", "Inventory")
                        .WithMany("Employee")
                        .HasForeignKey("InventoryId");
                });

            modelBuilder.Entity("ASPNETCOREDATABASE.Models.Payment", b =>
                {
                    b.HasOne("ASPNETCOREDATABASE.Models.Inventory", "Inventory")
                        .WithMany("Payment")
                        .HasForeignKey("InventoryId");
                });
        }
    }
}
