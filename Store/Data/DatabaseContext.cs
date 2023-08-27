﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Store.Entities;

namespace Store.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        public DbSet<Product> Product { get; set; }
    }
}
