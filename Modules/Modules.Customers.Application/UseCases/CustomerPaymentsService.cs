using System;
using Modules.Customers.Application.Dtos;

namespace Modules.Customers.Application.UseCases
{
	public class CustomerPaymentsService: ICustomerPaymentsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CustomerPaymentsService(IUnitOfWork unitOfWork, IMapper mapper) //
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<GenericResponseDto> AddNewCustomerPaymentDetails(CustomerPaymentsDto values)
        {
            CustomerPayments payments = CustomerPayments.AddPaymentDetails(values.ReceiptNumber, values.PropertyNumber, values.CustomerCode, values.CustomerName, values.DateOfPayment, values.PaymentMode, values.PaymentType!, values.InvoiceCurrency!, values.PaymentCurrency!, values.Amount,
                                                                           values.AmountPaid, values.IssuingBank!, values.IssuingBranch!,values.ReceivingBank!,values.ProcessingBranch!,values.ReceivingBranch!,values.PayPoint!,values.ChequeNumber!,values.ReferenceNumber!,values.PayeeName,
                                                                           values.Narration,values.InvoiceNumber, values.InvoiceItemId, values.Cashier);
            _unitOfWork.CustomerPayment.Insert(payments);

            await _unitOfWork.Complete();

            return new GenericResponseDto { response = "200" };

        }

        public async Task<IEnumerable<CustomerPaymentsSummaryDto>> CustomerPaymentSummary(string customerCode)
        {
            //throw new NotImplementedException();
            var customerPayments = (await _unitOfWork.CustomerPayment.GetAll(p => p.CustomerCode == customerCode)) // Fetch all customer payments .Where() // Filter by CustomerCode
                    .OrderByDescending(t => t.DateOfPayment)
                    .Select(p => new CustomerPaymentsSummaryDto
                    {
                        ReceiptNumber = p.ReceiptNumber!,
                        Narration = p.Narration!,
                        DateOfPayment = p.DateOfPayment,
                        PaymentMode = p.PaymentMode!,
                        PaymentCurrency = p.PaymentCurrency,
                        AmountPaid = p.AmountPaid,
                        ChequeNumber = p.ChequeNumber
                    });

            return customerPayments;

        }

        public async Task<IEnumerable<CustomerPaymentsDto>> CustomerPaymentDetailsSearch(string propertyNumber, string paymentMode, DateTime? startDate, DateTime? endDate)
        {
            //var customerPayments = (await _unitOfWork.CustomerPayment.GetAll()).AsQueryable();

            var transactionsQuery = (await _unitOfWork.CustomerPayment.GetAll()).AsQueryable();

            if (!string.IsNullOrEmpty(propertyNumber))
                transactionsQuery = transactionsQuery.Where(t => t.PropertyNumber == propertyNumber);

            if (!string.IsNullOrEmpty(paymentMode))
                transactionsQuery = transactionsQuery.Where(t => t.PropertyNumber == paymentMode);

            // Ensure both startDate and endDate are supplied together
            if (startDate.HasValue && endDate.HasValue)
            {
                transactionsQuery = transactionsQuery.Where(t => t.DateOfPayment >= startDate && t.DateOfPayment <= endDate);
            }

            // Order by latest DateOfPayment first
            transactionsQuery = transactionsQuery.OrderByDescending(t => t.DateOfPayment);


            return _mapper.Map<IEnumerable<CustomerPaymentsDto>>(transactionsQuery.ToList());
        }

        public async Task<CustomerPaymentsSummaryDto> CustomerPaymentSearchByReceiptNumber(string receiptNumber)
        {
            var customerPayments = (await _unitOfWork.CustomerPayment.GetAll(p => p.ReceiptNumber!.Contains(receiptNumber))) 
                    .Select(p => new CustomerPaymentsSummaryDto
                    {
                        ReceiptNumber = p.ReceiptNumber!,
                        Narration = p.Narration!,
                        DateOfPayment = p.DateOfPayment,
                        PaymentMode = p.PaymentMode!,
                        PaymentCurrency = p.PaymentCurrency,
                        AmountPaid = p.AmountPaid,
                        ChequeNumber = p.ChequeNumber
                    }).FirstOrDefault();

            return customerPayments!;
        }

        public async Task<IEnumerable<CustomerPaymentsDto>> CustomerPaymentDetails(string customerCode)
        {
            var customerPayments = (await _unitOfWork.CustomerPayment.GetAll(p => p.CustomerCode == customerCode))
                    .OrderByDescending(t => t.DateOfPayment);

            return _mapper.Map<IEnumerable<CustomerPaymentsDto>>(customerPayments);
        }

        public async Task<IEnumerable<CustomerPaymentsSummaryDto>> CustomerPaymentSummarySearch(string propertyNumber, string paymentMode, DateTime? startDate, DateTime? endDate)
        {
            //var customerPayments = (await _unitOfWork.CustomerPayment.GetAll(p => p.PropertyNumber == propertyNumber && p.DateOfPayment >= startDate && p.DateOfPayment <= endDate || p.PaymentMode!.Contains(paymentMode))) // Fetch all customer payments .Where() // Filter by propertyNumber
            //        .OrderByDescending(t => t.DateOfPayment)
            //        .Select(p => new CustomerPaymentsSummaryDto
            //        {
            //            ReceiptNumber = p.ReceiptNumber!,
            //            Narration = p.Narration!,
            //            DateOfPayment = p.DateOfPayment,
            //            PaymentMode = p.PaymentMode!,
            //            PaymentCurrency = p.PaymentCurrency,
            //            AmountPaid = p.AmountPaid,
            //            ChequeNumber = p.ChequeNumber
            //        });

            //return customerPayments;


            var transactionsQuery = (await _unitOfWork.CustomerPayment.GetAll()).AsQueryable();

            if (!string.IsNullOrEmpty(propertyNumber))
                transactionsQuery = transactionsQuery.Where(t => t.PropertyNumber == propertyNumber);

            if (!string.IsNullOrEmpty(paymentMode))
                transactionsQuery = transactionsQuery.Where(t => t.PropertyNumber == paymentMode );

            // Ensure both startDate and endDate are supplied together
            if (startDate.HasValue && endDate.HasValue)
            {
                transactionsQuery = transactionsQuery.Where(t => t.DateOfPayment >= startDate && t.DateOfPayment <= endDate);
            }

            // Order by latest DateOfPayment first
            transactionsQuery = transactionsQuery.OrderByDescending(t => t.DateOfPayment);

            // Execute the query (fetch from DB)
            var customerPayments = transactionsQuery.Select(p => new CustomerPaymentsSummaryDto
            {
                ReceiptNumber = p.ReceiptNumber!,
                Narration = p.Narration!,
                DateOfPayment = p.DateOfPayment,
                PaymentMode = p.PaymentMode!,
                PaymentCurrency = p.PaymentCurrency,
                AmountPaid = p.AmountPaid,
                ChequeNumber = p.ChequeNumber
            }).ToList(); // Executes the query

            return customerPayments!;

        }

        public async Task<IEnumerable<CustomerPaymentsDto>> CustomerPropertyPaymentDetails(string propertyNumber)
        {
            var customerPayments = (await _unitOfWork.CustomerPayment.GetAll(p => p.PropertyNumber == propertyNumber))
                    .OrderByDescending(t => t.DateOfPayment);

            return _mapper.Map<IEnumerable<CustomerPaymentsDto>>(customerPayments);
        }
    

        public async Task<IEnumerable<CustomerPaymentsSummaryDto>> CustomerPropertyPaymentSummary(string propertyNumber)
        {
            var customerPayments = (await _unitOfWork.CustomerPayment.GetAll(p => p.PropertyNumber == propertyNumber)) // Fetch all customer payments .Where() // Filter by propertyNumber
                    .OrderByDescending(t => t.DateOfPayment)
                    .Select(p => new CustomerPaymentsSummaryDto
                    {
                        ReceiptNumber = p.ReceiptNumber!,
                        Narration = p.Narration!,
                        DateOfPayment = p.DateOfPayment,
                        PaymentMode = p.PaymentMode!,
                        PaymentCurrency = p.PaymentCurrency,
                        AmountPaid = p.AmountPaid,
                        ChequeNumber = p.ChequeNumber
                    });

            return customerPayments;
        }

        public async Task<CustomerPaymentsDto> CustomerPaymentDetailsSearchByReceiptNumber(string receiptNumber)
        {
            var customerPayments = (await _unitOfWork.CustomerPayment.GetAll(p => p.ReceiptNumber == receiptNumber))
                    .OrderByDescending(t => t.DateOfPayment).FirstOrDefault();

            return _mapper.Map<CustomerPaymentsDto>(customerPayments);
        }
    }
}

