using System;
using Microsoft.EntityFrameworkCore;

namespace IndyBooks.Models
{
    public class IndyBooksDataContext:DbContext
    {
        public IndyBooksDataContext(DbContextOptions<IndyBooksDataContext> options) : base(options) { }

        //TODO: Define DbSets for Collections representing all DB tables
        public DbSet<Book> Books { get; set; }
        public DbSet<Writer> Writers { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Book>().Property(b => b.Price).HasColumnType("decimal(18,2)");
        //}
    }
}
