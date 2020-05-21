using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TrashCollector_Proj.Models;

namespace TrashCollector_Proj.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole 
                    { 
                        Name = "Admin", 
                        NormalizedName = "ADMIN" 
                    }
                    );
        }
        public DbSet<TrashCollector_Proj.Models.Customer> Customer { get; set; }
    }
}
