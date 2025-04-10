using Microsoft.EntityFrameworkCore;
using Modules.Common.Infrastructure;

namespace Modules.Customers.Infrastructure.Persistence;

public class ApplicationDBContext : ModuleDbContext
{
    protected override string Schema => "cus";

    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
    {

    }

    public DbSet<Complaint> Complaint { get; set; }
    public DbSet<ComplaintType> ComplaintType { get; set; }
    public DbSet<NatureOfComplaint> NatureOfComplaint { get; set; }

    public DbSet<CustomerDetails> CustomerDetails { get; set; }
    public DbSet<PropertyDetails> PropertyDetails { get; set; }
    public DbSet<CustomerInvoice> CustomerInvoice { get; set; }
    public DbSet<CustomerInvoiceItems> CustomerInvoiceItems { get; set; }
    public DbSet<CustomerPayments> CustomerPayments { get; set; }
    public DbSet<CustomerTransactions> CustomerTransactions { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        base.OnModelCreating(modelBuilder);

        //set custom schema
        modelBuilder.HasDefaultSchema(Schema);

        modelBuilder.Entity<CustomerDetails>()
            .HasIndex(pm => pm.CustomerCode)
            .IsUnique(true);

        modelBuilder.Entity<PropertyDetails>()
            .HasIndex(pm => pm.PropertyNumber)
            .IsUnique(true);

        modelBuilder.Entity<CustomerTransactions>()
            .HasIndex(pm => pm.VoucherNumber)
            .IsUnique(true);

        modelBuilder.Entity<CustomerInvoice>()
            .HasIndex(pm => pm.InvoiceNumber)
            .IsUnique(true);

        modelBuilder.Entity<CustomerPayments>()
            .HasIndex(pm => pm.ReceiptNumber)
            .IsUnique(true);

        modelBuilder.Entity<CustomerTransactions>()
            .HasIndex(ct => new { ct.VoucherNumber, ct.CustomerCode })
            .IsUnique(true);

        modelBuilder.Entity<CustomerInvoice>()
            .HasIndex(ct => new { ct.InvoiceNumber, ct.CustomerCode })
            .IsUnique(true);

        modelBuilder.Entity<CustomerPayments>()
            .HasIndex(ct => new { ct.ReceiptNumber, ct.CustomerCode })
            .IsUnique(true);

        modelBuilder.Entity<Complaint>()
            .HasIndex(c => c.ComplaintNumber)
            .IsUnique(true);

    }
}

