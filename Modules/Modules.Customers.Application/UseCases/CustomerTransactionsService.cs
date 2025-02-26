using System;

namespace Modules.Customers.Application.UseCases
{
	public class CustomerTransactionsService : ICustomerTransactionsService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomerTransactionsService(IUnitOfWork unitOfWork) //, IMapper mapper
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<GenericResponseDto> AddNewCustomerTransactionDetails(CustomerTransactionsDto values)
        {
            //throw new NotImplementedException();
            CustomerTransactions transactions = CustomerTransactions.AddCustomerTransaction(0, values.VoucherNumber, values.PropertyNumber, values.CustomerCode, values.TransactionDate, values.ReferenceNumber, values.ChequeNumber, values.Narration ,values.Amount, values.AccountCode, values.TransactionType,values.VoucherType);

            _unitOfWork.CustomerTransaction.Insert(transactions);
            await _unitOfWork.Complete();

            return new GenericResponseDto { response = "200" };

        }

        public async Task<IEnumerable<CustomerTransactionsReadDto>> CustomerTransactionDetails(string customerCode, string propertyNumber)
        {
            var transactionsQuery = (await _unitOfWork.CustomerTransaction.GetAll())
                                    .OrderByDescending(t => t.TransactionDate) // Order by latest TransactionDate first
                                    .Select(t => new CustomerTransactionsReadDto
                                    {
                                        VoucherNumber = t.VoucherNumber,
                                        CustomerCode = t.CustomerCode,
                                        PropertyNumber = t.PropertyNumber,
                                        TransactionDate = t.TransactionDate,
                                        ChequeNumber = t.ChequeNumber,
                                        ReferenceNumber = t.ReferenceNumber,
                                        Narration = t.Narration,
                                        Amount = t.Amount,
                                        PaymentMethod = string.IsNullOrEmpty(t.ChequeNumber)
                                            ? (!string.IsNullOrEmpty(t.ReferenceNumber) ? "Transfers" : "Cash")
                                            : "Cheque",
                                        VoucherType = t.VoucherType,
                                        TransactionType = t.TransactionType
                                    }).AsQueryable();

            if (!string.IsNullOrEmpty(customerCode))
                transactionsQuery = transactionsQuery.Where(t => t.CustomerCode == customerCode);

            if (!string.IsNullOrEmpty(propertyNumber))
                transactionsQuery = transactionsQuery.Where(t => t.PropertyNumber == propertyNumber);


            transactionsQuery.OrderByDescending(t => t.TransactionDate);

            return transactionsQuery!;

        }

        public async Task<IEnumerable<CustomerTransactionsReadDto>> CustomerStatement(string customerCode, string propertyNumber, string receipt_or_invoiceNumber, string transactionType, int year)
        {

            var transactionsQuery = (await _unitOfWork.CustomerTransaction.GetAll()).AsQueryable();


            // Apply filters dynamically based on provided parameters
            if (!string.IsNullOrEmpty(customerCode))
                transactionsQuery = transactionsQuery.Where(t => t.CustomerCode == customerCode);

            if (!string.IsNullOrEmpty(propertyNumber))
                transactionsQuery = transactionsQuery.Where(t => t.PropertyNumber == propertyNumber);

            if (!string.IsNullOrEmpty(receipt_or_invoiceNumber))
                transactionsQuery = transactionsQuery.Where(t => t.VoucherNumber == receipt_or_invoiceNumber);

            if (!string.IsNullOrEmpty(transactionType)) 
                transactionsQuery = transactionsQuery.Where(t => t.TransactionType == transactionType);

            if (!string.IsNullOrEmpty(year.ToString()))
            {
                transactionsQuery = transactionsQuery.Where(t => t.TransactionDate.Year >= year);
            }

            // Order by latest TransactionDate first
            transactionsQuery = transactionsQuery.OrderByDescending(t => t.TransactionDate);

            // Execute the query (fetch from DB)
            var transactions = transactionsQuery.Select(t => new CustomerTransactionsReadDto
            {
                VoucherNumber = t.VoucherNumber,
                CustomerCode = t.CustomerCode,
                PropertyNumber = t.PropertyNumber,
                TransactionDate = t.TransactionDate,
                ChequeNumber = t.ChequeNumber,
                ReferenceNumber = t.ReferenceNumber,
                Narration = t.Narration,
                Amount = t.Amount,
                PaymentMethod = string.IsNullOrEmpty(t.ChequeNumber)
                    ? (!string.IsNullOrEmpty(t.ReferenceNumber) ? "Transfers" : "Cash")
                    : "Cheque",
                VoucherType = t.VoucherType,
                TransactionType = t.TransactionType
            }).ToList(); // Executes the query

            return transactions!;


        }


        


    }
}

