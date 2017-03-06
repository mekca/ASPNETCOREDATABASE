using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


namespace ASPNETCOREDATABASE.Models
{

    public class Inventory
    {
        public int InventoryId { get; set; }
        public string Name { get; set; }
        public List<Employee> Employee { get; set; }
        public List<Detail> Detail { get; set; }
        public List<Payment> Payment { get; set; }

    }
    public class Detail
    {
        public int DetailId { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int UPC { get; set; }
        public Inventory Inventory { get; set; }
    }
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeNumber { get; set; }
        public Inventory Inventory { get; set; }
    }
    public class Payment
    {
        public int PaymentId { get; set; }
        public string PaymentMethod { get; set; }
        public double Tax { get; set; }
        public string State { get; set; }

        public Inventory Inventory { get; set; }
    }

    public class InventoryContext : DbContext
    {
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Detail> Details { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Payment> Payment { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=./Inventory.db");
        }
    }
}
