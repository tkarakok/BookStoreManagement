using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{

    // context : db tablosu ile proje classını ilişkilendirme
    public class BookStoreDatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\mssqllocaldb ; Database = BookStore ; Trusted_Connection = true");
        }

        public DbSet<User> Users{ get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Book> Books{ get; set; }
        public DbSet<Author> Authors{ get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Employee> Employees{ get; set; }
        public DbSet<Customer> Customers{ get; set; }
    }
}
