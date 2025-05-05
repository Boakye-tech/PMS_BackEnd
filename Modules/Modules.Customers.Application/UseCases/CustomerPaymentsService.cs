// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


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



        public async Task<IEnumerable<CustomerPaymentsDto>> CustomerPaymentDetails(string? customerCode,string propertyNumber, string? receiptNumber, string paymentMode, int? paymentYear)
        {
            //var customerPayments = (await _unitOfWork.CustomerPayment.GetAll()).AsQueryable();

            var transactionsQuery = (await _unitOfWork.CustomerPayment.GetAll()).AsQueryable();

            if (!string.IsNullOrEmpty(customerCode))
                transactionsQuery = transactionsQuery.Where(t => t.CustomerCode == customerCode);

            if (!string.IsNullOrEmpty(propertyNumber))
                transactionsQuery = transactionsQuery.Where(t => t.PropertyNumber == propertyNumber);

            if (!string.IsNullOrEmpty(receiptNumber))
                transactionsQuery = transactionsQuery.Where(t => t.ReceiptNumber!.Contains(receiptNumber));

            if (!string.IsNullOrEmpty(paymentMode))
                transactionsQuery = transactionsQuery.Where(t => t.PaymentMode == paymentMode);

            if (!string.IsNullOrEmpty(paymentYear.ToString()))
                transactionsQuery = transactionsQuery.Where(t => t.DateOfPayment.Year >= paymentYear);

            transactionsQuery = transactionsQuery.OrderByDescending(t => t.DateOfPayment);


            return _mapper.Map<IEnumerable<CustomerPaymentsDto>>(transactionsQuery.ToList());
        }



        public async Task<IEnumerable<CustomerPaymentsSummaryDto>> CustomerPaymentSummary(string? customerCode, string? propertyNumber, string? receiptNumber, string paymentMode, int? paymentYear)
        {
            var transactionsQuery = (await _unitOfWork.CustomerPayment.GetAll()).AsQueryable();


            if (!string.IsNullOrEmpty(customerCode))
                transactionsQuery = transactionsQuery.Where(t => t.CustomerCode == customerCode);

            if (!string.IsNullOrEmpty(propertyNumber))
                transactionsQuery = transactionsQuery.Where(t => t.PropertyNumber == propertyNumber);

            if (!string.IsNullOrEmpty(receiptNumber))
                transactionsQuery = transactionsQuery.Where(t => t.ReceiptNumber == receiptNumber);

            if (!string.IsNullOrEmpty(paymentMode))
                transactionsQuery = transactionsQuery.Where(t => t.PaymentMode == paymentMode );

            if (!string.IsNullOrEmpty(paymentYear.ToString()))
                transactionsQuery = transactionsQuery.Where(t => t.DateOfPayment.Year >= paymentYear);

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



      
    



       
    }
}

