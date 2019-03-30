using Microsoft.EntityFrameworkCore;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eshop.Api.Context
{
    public class MsDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<ProductItem> Products { get; set; }

        public MsDbContext(DbContextOptions<MsDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
