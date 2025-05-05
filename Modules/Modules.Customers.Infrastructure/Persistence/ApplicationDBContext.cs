// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

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
    public DbSet<ComplaintStatuses> ComplaintStatus { get; set; }
    public DbSet<ComplaintHistory> ComplaintHistory { get; set; }

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

        modelBuilder.Entity<ComplaintStatuses>()
            .HasIndex(c => c.ComplaintStatus)
            .IsUnique(true);

        modelBuilder.Entity<ComplaintHistory>()
            .HasIndex(ch => new { ch.ComplaintNumber, ch.ComplaintStatus })
            .IsUnique(true);

        //modelBuilder.ApplyConfiguration(new ComplaintStatusConfiguration());

    }
}

