using Microsoft.EntityFrameworkCore;
using System;

namespace OnlineFoodDeliveryBackend.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Payment> Payments { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {


        }

    }
}
