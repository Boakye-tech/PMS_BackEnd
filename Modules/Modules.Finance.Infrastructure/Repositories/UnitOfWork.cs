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
        CurrencyAndExchangeRate = new CurrencyAndExchangeRateRepository(dbContext);
        Forms = new FormsRepository(dbContext);
        PaymentMode = new PaymentModeRepository(dbContext);
        PaymentType = new PaymentTypeRepository(dbContext);
        Paypoints = new PaypointsRespository(dbContext);
    }

    public IBankRepository Bank { get; private set; }

    public IBankBranchRepository BankBranch { get; private set; }

    public IBankSortCodesRepository BankSortCodes { get; private set; }

    public IChartOfAccountsRepository ChartOfAccounts { get; private set; }

    public ICurrencyAndExchangeRateRepository CurrencyAndExchangeRate { get; private set; }

    public IFormsRepository Forms { get; private set; }

    public IPaymentModeRepository PaymentMode { get; private set; }

    public IPaymentTypeRepository PaymentType { get; private set; }

    public IPaypointsRespository Paypoints { get; private set; }

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

