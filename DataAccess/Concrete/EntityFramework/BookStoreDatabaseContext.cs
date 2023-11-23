using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Employee = Core.Entities.Concrete.Employee;

namespace DataAccess.Concrete.EntityFramework
{

    // context : db tablosu ile proje classını ilişkilendirme
    public class BookStoreDatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb ; Database = BookStore ; Trusted_Connection = true");
        }


        public DbSet<Employee> Employees{ get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<EmployeeOperationClaim> EmployeeOperationClaims { get; set; }
        public DbSet<Book> Books{ get; set; }
        public DbSet<Author> Authors{ get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Customer> Customers{ get; set; }
        public DbSet<Rental> Rentals{ get; set; }
    }
}
