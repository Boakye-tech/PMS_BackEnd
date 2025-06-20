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

