using System;
using System.Collections.Generic;
using System.Text;
using CompanyAuth.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CompanyAuth.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
          public virtual DbSet<Area> Area { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
