﻿using DDDWebAPI.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace DDDWebAPI.Infrastructure.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {
        }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Product> Products { get; set; }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("CreatedAt") != null))
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("CreatedAt").CurrentValue = DateTime.Now;
                }

                if (entry.State == EntityState.Modified)
                {
                    entry.Property("CreatedAt").IsModified = false;
                }


            }

            return base.SaveChanges();
        }
    }
}
