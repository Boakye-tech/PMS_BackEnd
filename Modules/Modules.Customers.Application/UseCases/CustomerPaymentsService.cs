using System;

namespace Modules.Customers.Application.UseCases
{
	public class CustomerPaymentsService: ICustomerPaymentsService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomerPaymentsService(IUnitOfWork unitOfWork) //, IMapper mapper
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<GenericResponseDto> AddNewCustomerPaymentDetails(CustomerPaymentsDto values)
        {
            CustomerPayments payments = CustomerPayments.AddPaymentDetails(values.ReceiptNumber, values.PropertyNumber, values.CustomerCode, values.CustomerName, values.DateOfPayment, values.PaymentMode, values.PaymentType!, values.InvoiceCurrency!, values.PaymentCurrency!, values.Amount,
                                                                           values.AmountPaid, values.IssuingBank!, values.IssuingBranch!,values.ReceivingBank!,values.ProcessingBranch!,values.ReceivingBranch!,values.PayPoint!,values.ChequeNumber!,values.ReferenceNumber!,values.PayeeName,
                                                                           values.Narration,values.InvoiceNumber,values.Cashier);
            _unitOfWork.CustomerPayment.Insert(payments);

            await _unitOfWork.Complete();

            return new GenericResponseDto { response = "200" };

        }
    }
}

