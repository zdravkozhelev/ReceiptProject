using Microsoft.EntityFrameworkCore;
using System;

public class ReceiptContext:DbContext
{
    

    public ReceiptContext()
	{
     
	}

    public ReceiptContext(DbContextOptions options):base(options)
    {

    }

    public virtual DbSet<Receipts> Receipts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
    {
        if (!optionBuilder.IsConfigured)
        {
             optionBuilder.UseSqlServer(Configuration.connectionString);
        }
        base.OnConfiguring(optionBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Receipts>().HasKey(x => x.Id).HasName("PK_Test");
        base.OnModelCreating(modelBuilder);
    }
}
