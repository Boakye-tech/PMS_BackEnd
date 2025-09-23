// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using Microsoft.EntityFrameworkCore;
using Modules.Common.Infrastructure;
using Modules.Finance.Domain.Entities.Setup;

namespace Modules.Finance.Infrastructure.Data;

public class FinanceDbContext : ModuleDbContext
{
    protected override string Schema => "fin";

    public FinanceDbContext(DbContextOptions<FinanceDbContext> options) : base(options)
    {
	}

    public DbSet<Bank> Bank { get; set; }
    public DbSet<BankBranch> BankBranch { get; set; }
    public DbSet<BankSortCodes> BankSortCodes { get; set; }
    public DbSet<ChartOfAccounts> ChartOfAccounts { get; set; }
    public DbSet<CurrencyExchangeRate> CurrencyExchangeRate { get; set; }
    public DbSet<CurrencyExchangeRateHistory> CurrencyExchangeRateHistory { get; set; }
    public DbSet<Forms> Forms { get; set; }
    public DbSet<PaymentMode> PaymentMode { get; set; }
    public DbSet<PaymentType> PaymentType { get; set; }
    public DbSet<Paypoints> Paypoints { get; set; }
    public DbSet<Services> Services { get; set; }
    public DbSet<InvoiceTypes> InvoiceTypes { get; set; }

    //7-07-25
    public DbSet<Department> Department { get; set; }
    public DbSet<DepartmentUnit> DepartmentUnit { get; set; }

    //19/09/2025
    public DbSet<RentalTypes> RentalTypes { get; set; }
    public DbSet<DebtorTypes> DebtorTypes { get; set; }
    public DbSet<DebtorGroups> DebtorGroups { get; set; }

    //20-09-2025
    public DbSet<PaymentTerms> PaymentTerms { get; set; }

    //22-09-2025
    public DbSet<BankAccountNumbers> BankAccountNumbers { get; set; }

    public DbSet<PenaltyType> PenaltyTypes { get; set; }
    public DbSet<PenaltyRule> PenaltyRules { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<InvoiceTypes>().HasKey(e => e.InvoiceTypesId);
        modelBuilder.Entity<Services>().HasKey(e => e.ServicesId);

        modelBuilder.Entity<InvoiceTypes>()
            .HasMany(i => i.Services)
            .WithMany(s => s.InvoiceTypes)
            .UsingEntity<Dictionary<string, object>>(
                "InvoiceTypeServices", // join table name
                j => j.HasOne<Services>()
                      .WithMany()
                      .HasForeignKey("ServicesId")
                      .OnDelete(DeleteBehavior.Restrict),
                j => j.HasOne<InvoiceTypes>()
                      .WithMany()
                      .HasForeignKey("InvoiceTypesId")
                      .OnDelete(DeleteBehavior.Restrict),
                j =>
                {
                    j.HasKey("InvoiceTypesId", "ServicesId"); // composite PK
                    j.ToTable("InvoiceTypeServices","fin");
                });


        modelBuilder.Entity<CurrencyExchangeRate>()
            .Property(c => c.BuyingRate)
            .HasColumnType("decimal(18,4)");

        modelBuilder.Entity<CurrencyExchangeRate>()
            .Property(c => c.SellingRate)
            .HasColumnType("decimal(18,4)");

        modelBuilder.Entity<CurrencyExchangeRateHistory>()
        .Property(c => c.BuyingRate)
        .HasColumnType("decimal(18,4)");

        modelBuilder.Entity<CurrencyExchangeRateHistory>()
            .Property(c => c.SellingRate)
            .HasColumnType("decimal(18,4)");

        modelBuilder.Entity<PenaltyType>().HasIndex(pt => pt.Name);

        modelBuilder.Entity<DepartmentUnit>().Property(d => d.UnitId).ValueGeneratedNever();

    }

}

