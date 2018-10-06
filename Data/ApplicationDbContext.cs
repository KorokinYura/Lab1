using System;
using System.Collections.Generic;
using System.Text;
using Lab1.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lab1.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Alternative> Alternatives { get; set; }
        public DbSet<Criterion> Criterions { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Vector> Vectors { get; set; }
        public DbSet<LPR> LPRs { get; set; }
        public DbSet<Result> Results { get; set; }
    }
}
