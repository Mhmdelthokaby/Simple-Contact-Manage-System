using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_DAL.Models;

namespace System_DAL.Contexts
{
    public class SystemDbContext : DbContext
    {
        
        public SystemDbContext(DbContextOptions<SystemDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure primary keys and relationships if needed
            modelBuilder.Entity<Contacts>()
                .HasKey(c => c.ContactId);  // Specify the primary key if using a non-conventional name
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Contacts> Contacts { get; set; }

    }
}
