using System;
using Modules.Customers.Application.Dtos;
using Modules.Customers.Domain.Entities;

namespace Modules.Customers.Application.UseCases
{
	public class CustomerInvoiceService : ICustomerInvoiceService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CustomerInvoiceService(IUnitOfWork unitOfWork, IMapper mapper) //, IMapper mapper
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<GenericResponseDto> AddCustomerInvoiceDetails(CustomerInvoiceDto values)
        {
            //throw new NotImplementedException();
            CustomerInvoice invoices = CustomerInvoice.AddInvoiceDetails(values.InvoiceNumber, values.InvoiceDate, values.PropertyNumber, values.Acreage, values.TransactionCode, values.TransactionNumber, values.ExpirationDate, values.CustomerCode, values.CustomerName,
                                                                         values.CustomerAddress, values.CustomerEmailAddress, values.CustomerPhoneNumber, values.InvoiceAmount, values.AmountPaid, values.BalanceDue, values.InvoiceStatus!);
            _unitOfWork.CustomerInvoice.Insert(invoices);

            int counter = 0;
            foreach (var item in values.InvoiceItems)
            {
                CustomerInvoiceItems invoiceItems = CustomerInvoiceItems.AddInvoiceItems(counter,values.InvoiceNumber,item.Description,item.Amount,item.AmountPaid,item.BalanceDue,item.Status!);
                _unitOfWork.CustomerInvoiceItems.Insert(invoiceItems);
                //counter++;
            }


            await _unitOfWork.Complete();

            return new GenericResponseDto { response = "200" };

        }

        public Task<IEnumerable<CustomerInvoiceDto>> CustomerInvoiceDetails(string invoiceNumber, string customerCode, string propertyNumber, string status, DateTime? startDate, DateTime? endDate)
        {
            throw new NotImplementedException();


        }

        public async Task<IEnumerable<CustomerInvoiceSummaryReadDto>> CustomerInvoiceSummary(string invoiceNumber, string customerCode, string propertyNumber, string status, DateTime? startDate, DateTime? endDate)
        {
            //throw new NotImplementedException();
            var invoiceItemsQuery = (from a in await _unitOfWork.CustomerInvoiceItems.GetAll()
                                    join b in await _unitOfWork.CustomerInvoice.GetAll()
                                    on a.InvoiceNumber equals b.InvoiceNumber
                                    orderby b.InvoiceDate descending // Optional ordering
                                    select new CustomerInvoiceSummaryDto
                                    {
                                        InvoiceNumber = $"{a.InvoiceNumber} - {a.InvoiceItemsId}",
                                        InvoiceDescription = a.Description!,
                                        CustomerCode = b.CustomerCode,
                                        PropertyNumber = b.PropertyNumber,
                                        InvoiceAmount = a.Amount,
                                        InvoiceStatus = a.Status,
                                        InvoiceDate = b.InvoiceDate
                                    }).AsQueryable();

            if (!string.IsNullOrEmpty(invoiceNumber))
                invoiceItemsQuery = invoiceItemsQuery.Where(t => t.InvoiceNumber.Contains(invoiceNumber));

            if (!string.IsNullOrEmpty(customerCode))
                invoiceItemsQuery = invoiceItemsQuery.Where(t => t.CustomerCode == customerCode);

            if (!string.IsNullOrEmpty(propertyNumber))
                invoiceItemsQuery = invoiceItemsQuery.Where(t => t.PropertyNumber == propertyNumber);

            if (!string.IsNullOrEmpty(status))
                invoiceItemsQuery = invoiceItemsQuery.Where(t => t.InvoiceStatus == status);


            // Ensure both startDate and endDate are supplied together
            if (startDate.HasValue && endDate.HasValue)
            {
                invoiceItemsQuery = invoiceItemsQuery.Where(t => t.InvoiceDate >= startDate && t.InvoiceDate <= endDate);
            }

            // Order by latest DateOfPayment first
            invoiceItemsQuery = invoiceItemsQuery.OrderByDescending(t => t.InvoiceDate);


            return _mapper.Map<IEnumerable<CustomerInvoiceSummaryReadDto>>(invoiceItemsQuery.ToList()); 

        }





    }
}

