using Modules.Finance.Domain.Interfaces.Entities.Setup;

namespace Modules.Finance.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IBankRepository Bank { get; }
        IBankBranchRepository BankBranch { get; }
        IBankSortCodesRepository BankSortCodes { get; }
        IChartOfAccountsRepository ChartOfAccounts { get; }
        ICurrencyAndExchangeRateRepository CurrencyAndExchangeRate { get; }
        IFormsRepository Forms { get; }
        IPaymentModeRepository PaymentMode { get; }
        IPaymentTypeRepository PaymentType { get; }
        IPaypointsRespository Paypoints { get; }


        Task<int> Complete();
    }
}