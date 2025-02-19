using System;

namespace Modules.Customers.Application.UseCases
{
	public class CustomerInvoiceService : ICustomerInvoiceService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomerInvoiceService(IUnitOfWork unitOfWork) //, IMapper mapper
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<GenericResponseDto> AddCustomerInvoiceDetails(CustomerInvoiceDto values)
        {
            //throw new NotImplementedException();
            CustomerInvoice invoices = CustomerInvoice.AddInvoiceDetails(values.InvoiceNumber, values.InvoiceDate, values.PropertyNumber, values.Acreage, values.TransactionCode, values.TransactionNumber, values.ExpirationDate, values.CustomerCode, values.CustomerName, values.CustomerAddress, values.CustomerEmailAddress, values.CustomerPhoneNumber, values.InvoiceAmount);
            _unitOfWork.CustomerInvoice.Insert(invoices);

            int counter = 0;
            foreach (var item in values.InvoiceItems)
            {
                CustomerInvoiceItems invoiceItems = CustomerInvoiceItems.AddInvoiceItems(counter,values.InvoiceNumber,item.Description,item.Amount,0);
                _unitOfWork.CustomerInvoiceItems.Insert(invoiceItems);
                //counter++;
            }


            await _unitOfWork.Complete();

            return new GenericResponseDto { response = "200" };

        }
    }
}

