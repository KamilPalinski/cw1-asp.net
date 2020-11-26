using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using cw1_asp.net.Models;

namespace cw1_asp.net.Database
{
    public class ExchangesDbContext : DbContext
    {
        public ExchangesDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<ExchangeModel> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ExchangeModel>().ToTable("Items");
          
        }
    }
}
