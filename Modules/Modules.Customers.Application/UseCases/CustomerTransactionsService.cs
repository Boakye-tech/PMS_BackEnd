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

        public async Task<IEnumerable<CustomerTransactionsReadDto>> CustomerTransactionDetails(string customerCode)
        {
            //throw new NotImplementedException();
            var transactions = (await _unitOfWork.CustomerTransaction.GetAll())
                            .Where(t => t.CustomerCode == customerCode) // Filter for specific CustomerCode
                            .OrderByDescending(t => t.TransactionDate) // Order by latest TransactionDate first
                            .Select(t => new CustomerTransactionsReadDto
                            {
                                VoucherNumber = t.VoucherNumber,
                                CustomerCode = t.CustomerCode,
                                PropertyNumber = t.PropertyNumber,
                                TransactionDate = t.TransactionDate,
                                ChequeNumber =t.ChequeNumber,
                                ReferenceNumber = t.ReferenceNumber,
                                Narration =t.Narration,
                                Amount = t.Amount,
                                PaymentMethod = string.IsNullOrEmpty(t.ChequeNumber)
                                    ? (!string.IsNullOrEmpty(t.ReferenceNumber) ? "Transfers" : "Cash")
                                    : "Cheque",
                                VoucherType = t.VoucherType,
                                TransactionType = t.TransactionType
                            })
                            .ToList();

            return transactions!;

        }

        public async Task<IEnumerable<CustomerTransactionsReadDto>> PropertyTransactionDetails(string propertyNumber)
        {
            //throw new NotImplementedException();
            var transactions = (await _unitOfWork.CustomerTransaction.GetAll())
                            .Where(t => t.PropertyNumber == propertyNumber) // Filter for specific Property Number
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
                            })
                            .ToList();

            return transactions!;
        }

        public async Task<IEnumerable<CustomerTransactionsReadDto>> CustomerStatementDetails(string customerCode)
        {
            //throw new NotImplementedException();
            var transactions = (await _unitOfWork.CustomerTransaction.GetAll())
                            .Where(t => t.CustomerCode == customerCode) // Filter for specific CustomerCode
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
                            })
                            .ToList();

            return transactions!;

        }

        public async Task<IEnumerable<CustomerTransactionsReadDto>> CustomerStatementDetails(string customerCode, string propertyNumber)
        {
            //throw new NotImplementedException();
            var transactions = (await _unitOfWork.CustomerTransaction.GetAll())
                            .Where(t => t.CustomerCode == customerCode && t.PropertyNumber == propertyNumber) // Filter for specific CustomerCode
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
                            })
                            .ToList();

            return transactions!;

        }


        //public async Task<IEnumerable<CustomerTransactionsReadDto>> CustomerStatementDetails(string customerCode, string propertyNumber, string transactionType)
        //{
        //    //throw new NotImplementedException();
        //    var transactions = (await _unitOfWork.CustomerTransaction.GetAll())
        //                    .Where(t => t.CustomerCode == customerCode && t.PropertyNumber == propertyNumber && t.TransactionType == transactionType) // Filter for specific CustomerCode
        //                    .OrderByDescending(t => t.TransactionDate) // Order by latest TransactionDate first
        //                    .Select(t => new CustomerTransactionsReadDto
        //                    {
        //                        VoucherNumber = t.VoucherNumber,
        //                        CustomerCode = t.CustomerCode,
        //                        PropertyNumber = t.PropertyNumber,
        //                        TransactionDate = t.TransactionDate,
        //                        ChequeNumber = t.ChequeNumber,
        //                        ReferenceNumber = t.ReferenceNumber,
        //                        Narration = t.Narration,
        //                        Amount = t.Amount,
        //                        PaymentMethod = string.IsNullOrEmpty(t.ChequeNumber)
        //                            ? (!string.IsNullOrEmpty(t.ReferenceNumber) ? "Transfers" : "Cash")
        //                            : "Cheque",
        //                        VoucherType = t.VoucherType,
        //                        TransactionType = t.TransactionType
        //                    })
        //                    .ToList();

        //    return transactions!;

        //}

        public async Task<IEnumerable<CustomerTransactionsReadDto>> CustomerStatementSearchDetails(string customerCode, string propertyNumber, string transactionType, DateTime? startDate, DateTime? endDate)
        {
            //throw new NotImplementedException();
            //var transactions = (await _unitOfWork.CustomerTransaction.GetAll())
            //                .Where(t => t.CustomerCode == customerCode && t.PropertyNumber == propertyNumber && t.TransactionType == transactionType && t.TransactionDate >= startDate && t.TransactionDate <= endDate) // Filter for specific CustomerCode
            //                .OrderByDescending(t => t.TransactionDate) // Order by latest TransactionDate first
            //                .Select(t => new CustomerTransactionsReadDto
            //                {
            //                    VoucherNumber = t.VoucherNumber,
            //                    CustomerCode = t.CustomerCode,
            //                    PropertyNumber = t.PropertyNumber,
            //                    TransactionDate = t.TransactionDate,
            //                    ChequeNumber = t.ChequeNumber,
            //                    ReferenceNumber = t.ReferenceNumber,
            //                    Narration = t.Narration,
            //                    Amount = t.Amount,
            //                    PaymentMethod = string.IsNullOrEmpty(t.ChequeNumber)
            //                        ? (!string.IsNullOrEmpty(t.ReferenceNumber) ? "Transfers" : "Cash")
            //                        : "Cheque",
            //                    VoucherType = t.VoucherType,
            //                    TransactionType = t.TransactionType
            //                })
            //                .ToList();

            //return transactions!;


            var transactionsQuery = (await _unitOfWork.CustomerTransaction.GetAll()).AsQueryable();


            // Apply filters dynamically based on provided parameters
            if (!string.IsNullOrEmpty(customerCode))
                transactionsQuery = transactionsQuery.Where(t => t.CustomerCode == customerCode);

            if (!string.IsNullOrEmpty(propertyNumber))
                transactionsQuery = transactionsQuery.Where(t => t.PropertyNumber == propertyNumber);

            if (!string.IsNullOrEmpty(transactionType)) 
                transactionsQuery = transactionsQuery.Where(t => t.TransactionType == transactionType);

            // Ensure both startDate and endDate are supplied together
            if (startDate.HasValue && endDate.HasValue)
            {
                transactionsQuery = transactionsQuery.Where(t => t.TransactionDate >= startDate && t.TransactionDate <= endDate);
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


        public async Task<IEnumerable<CustomerTransactionsReadDto>> CustomerStatementVoucherSearchDetails(string voucherNumber)
        {
            //throw new NotImplementedException();
            var transactions = (await _unitOfWork.CustomerTransaction.GetAll())
                            .Where(t => t.VoucherNumber.Contains(voucherNumber)) // Filter for specific receit number or invoice/bill number
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
                            })
                            .ToList();

            return transactions!;

        }


    }
}

