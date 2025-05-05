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

        public async Task<IEnumerable<CustomerInvoiceDto>> CustomerInvoiceDetails(string invoiceNumber, string customerCode, string propertyNumber, string status, int year)
        {
            //throw new NotImplementedException();
            var query = from invoice in await _unitOfWork.CustomerInvoice.GetAll()
                        join items in await _unitOfWork.CustomerInvoiceItems.GetAll()
                            on invoice.InvoiceNumber equals items.InvoiceNumber into invoiceItems
                        select new CustomerInvoiceDto
                        {
                            InvoiceNumber = invoice.InvoiceNumber!,
                            InvoiceDate = invoice.InvoiceDate,
                            PropertyNumber = invoice.PropertyNumber!,
                            Acreage = invoice.Acreage,
                            TransactionCode = invoice.TransactionCode,
                            TransactionNumber = invoice.TransactionNumber,
                            ExpirationDate = invoice.ExpirationDate,
                            CustomerCode = invoice.CustomerCode!,
                            CustomerName = invoice.CustomerName,
                            CustomerAddress = invoice.CustomerAddress,
                            CustomerEmailAddress = invoice.CustomerEmailAddress,
                            CustomerPhoneNumber = invoice.CustomerPhoneNumber,
                            InvoiceAmount = invoice.InvoiceAmount,
                            AmountPaid = invoice.AmountPaid,
                            BalanceDue = invoice.BalanceDue,
                            InvoiceStatus = invoice.InvoiceStatus,
                            InvoiceItems = invoiceItems.Select(item => new CustomerInvoiceItemsDto
                            {
                                Description = item.Description!,
                                Amount = item.Amount,
                                Status = item.Status,
                                AmountPaid = item.AmountPaid,
                                BalanceDue = item.BalanceDue
                            }).ToList()
                        };

            // Apply filters dynamically
            if (!string.IsNullOrEmpty(invoiceNumber))
                query = query.Where(i => i.InvoiceNumber == invoiceNumber);

            if (!string.IsNullOrEmpty(customerCode))
                query = query.Where(i => i.CustomerCode == customerCode);

            if (!string.IsNullOrEmpty(status))
                query = query.Where(i => i.InvoiceStatus == status);

            if (!string.IsNullOrEmpty(year.ToString()))
                query = query.Where(i => i.InvoiceDate.Year >= year);


            return query.ToList();

        }

        public async Task<IEnumerable<CustomerInvoiceSummaryReadDto>> CustomerInvoiceSummary(string invoiceNumber, string customerCode, string propertyNumber, string status, int year)
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


            if (!string.IsNullOrEmpty(year.ToString()))
                invoiceItemsQuery = invoiceItemsQuery.Where(t => t.InvoiceDate.Year >= year);

            // Order by latest DateOfPayment first
            invoiceItemsQuery = invoiceItemsQuery.OrderByDescending(t => t.InvoiceDate);

            return _mapper.Map<IEnumerable<CustomerInvoiceSummaryReadDto>>(invoiceItemsQuery.ToList()); 

        }

        public Task<IEnumerable<CustomerInvoiceSummaryReadDto>> CustomerInvoiceSummary(string invoiceNumber, string customerCode, string propertyNumber, string status, int? year)
        {
            throw new NotImplementedException();
        }
    }
}

