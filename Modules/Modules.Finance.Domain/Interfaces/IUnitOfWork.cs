// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


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
        IInvoiceTypesRepository InvoiceTypes { get; }


        Task<int> Complete();
    }
}