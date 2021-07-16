using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Constrution.Models;

namespace Constrution.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Constrution.Models.Clients> Clients { get; set; }
        public DbSet<Constrution.Models.Owner> Owner { get; set; }
    }
}
