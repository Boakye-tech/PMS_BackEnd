using System;
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
    public DbSet<CurrencyAndExchangeRate> CurrencyAndExchangeRate { get; set; }
    public DbSet<Forms> Forms { get; set; }
    public DbSet<PaymentMode> PaymentMode { get; set; }
    public DbSet<PaymentType> PaymentType { get; set; }
    public DbSet<Paypoints> Paypoints { get; set; }
    public DbSet<Services> Services { get; set; }
    public DbSet<InvoiceTypes> InvoiceTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

}

