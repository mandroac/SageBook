﻿using Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class SageBookDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public SageBookDbContext(DbContextOptions<SageBookDbContext> options) : base(options)
        {
        }

        public SageBookDbContext(string connectionString) : base(GetOptions(connectionString))
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Sage> Sages { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Message> Messages { get; set; }

        private static DbContextOptions GetOptions(string connectionString)
        {
            return SqlServerDbContextOptionsExtensions.UseSqlServer(new DbContextOptionsBuilder(), connectionString).Options;
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<AppUser>()
                .Ignore(c => c.PhoneNumberConfirmed)
                .Ignore(c => c.PhoneNumber);

            builder.Entity<Book>(opts =>
            {
                opts.HasMany(b => b.Messages).WithOne().HasForeignKey(m => m.BookId);
            });

            builder.Entity<Order>(opts =>
            {
                opts.HasMany(o => o.Books)
                    .WithMany();

                opts.HasOne(o => o.User)
                    .WithMany();

                opts.HasIndex(o => o.OrderNumber);
                opts.Property(o => o.OrderNumber).UseIdentityColumn(1000, 1);
            });

            builder.Entity<Message>(opts =>
            {
                opts.HasOne(m => m.Sender).WithMany().HasForeignKey(m => m.SenderId);
            });
        }
    }
}