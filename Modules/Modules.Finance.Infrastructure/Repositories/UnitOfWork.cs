// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Finance.Infrastructure.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private bool disposedValue;
    private readonly FinanceDbContext _dbContext;

    public UnitOfWork(FinanceDbContext dbContext)
    {
        _dbContext = dbContext;
        Bank = new BankRepository(dbContext);
        BankBranch = new BankBranchRepository(dbContext);
        BankSortCodes = new BankSortCodesRepository(dbContext);
        ChartOfAccounts = new ChartOfAccountsRepository(dbContext);
        CurrencyExchangeRate = new CurrencyExchangeRateRepository(dbContext);
        Forms = new FormsRepository(dbContext);
        PaymentMode = new PaymentModeRepository(dbContext);
        PaymentType = new PaymentTypeRepository(dbContext);
        Paypoints = new PaypointsRespository(dbContext);
        InvoiceTypes = new InvoiceTypesRepository(dbContext);
        Department = new DepartmentRepository(dbContext);
        DepartmentUnit = new DepartmentUnitRepository(dbContext);
        RentalTypes = new RentalTypesRepository(dbContext);
        DebtorTypes = new DebtorTypesRepository(dbContext);
        DebtorGroups = new DebtorGroupsRepository(dbContext);
        Services = new ServicesRepository(dbContext);
        PaymentTerms = new PaymentTermsRepository(dbContext);
    }

    public IBankRepository Bank { get; private set; }

    public IBankBranchRepository BankBranch { get; private set; }

    public IBankSortCodesRepository BankSortCodes { get; private set; }

    public IChartOfAccountsRepository ChartOfAccounts { get; private set; }

    public ICurrencyExchangeRateRepository CurrencyExchangeRate { get; private set; }

    public IFormsRepository Forms { get; private set; }

    public IPaymentModeRepository PaymentMode { get; private set; }

    public IPaymentTypeRepository PaymentType { get; private set; }

    public IPaypointsRespository Paypoints { get; private set; }

    public IInvoiceTypesRepository InvoiceTypes { get; private set; }

    public IDepartmentRepository Department { get; private set; }

    public IDepartmentUnitRepository DepartmentUnit { get; private set; }

    public IRentalTypesRepository RentalTypes { get; private set; }

    public IDebtorTypesRepository DebtorTypes { get; private set; }

    public IDebtorGroupsRepository DebtorGroups { get; private set; }

    public IServicesRepository Services { get; private set; }

    public IPaymentTermsRepository PaymentTerms { get; private set; }

    public Task<int> Complete()
    {
        return _dbContext.SaveChangesAsync();
    }

    protected virtual void Dispose(bool disposing)
    {
        if (!disposedValue)
        {
            if (disposing)
            {
                // TODO: dispose managed state (managed objects)
                _dbContext.Dispose();
            }

            // TODO: free unmanaged resources (unmanaged objects) and override finalizer
            // TODO: set large fields to null
            disposedValue = true;
        }
    }

    public void Dispose()
    {
        //throw new NotImplementedException();
        Dispose(disposing: true);
        GC.SuppressFinalize(this);
    }
}

