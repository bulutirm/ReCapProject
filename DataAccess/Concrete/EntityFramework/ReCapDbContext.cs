using System;
using System.Runtime.ConstrainedExecution;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using ReCapProject.Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class ReCapDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)/usr/local/sbin:/usr/local/bin:/usr/sbin:/usr/bin:/sbin:/bin;Database=ReCapDb;Trusted_Connection=True");
        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
