// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using System;
using Microsoft.EntityFrameworkCore;

namespace Modules.Customers.Infrastructure.Persistence.Repositories
{
	public class UnitOfWork : IUnitOfWork
	{
        private bool disposedValue;
        private readonly ApplicationDBContext _dbContext;


        public UnitOfWork(ApplicationDBContext dbContext)
		{
            _dbContext = dbContext;

            CustomerDetails = new CustomerDetailsRepository(_dbContext);
            PropertyDetails = new PropertyDetailsRepository(_dbContext);
            CustomerInvoice = new CustomerInvoiceRepository(_dbContext);
            CustomerInvoiceItems = new CustomerInvoiceItemsRepository(_dbContext);
            CustomerPayment = new CustomerPaymentsRepository(_dbContext);
            CustomerTransaction = new CustomerTransactionsRepository(_dbContext);
            Complaint = new ComplaintRepository(_dbContext);
            ComplaintType = new ComplaintTypeRepository(_dbContext);
            NatureOfComplaint = new NatureOfComplaintRepository(_dbContext);
            ComplaintHistory = new ComplaintHistoryRepository(_dbContext);
            ComplaintStatuses = new ComplaintStatusesRepository(_dbContext);
        }

        public ICustomerDetailsRepository CustomerDetails { get; private set; }

        public ICustomerInvoiceRepository CustomerInvoice { get; private set; }

        public ICustomerInvoiceItemsRepository CustomerInvoiceItems { get; private set; }

        public ICustomerPaymentsRepository CustomerPayment { get; private set; }

        public ICustomerTransactionsRepository CustomerTransaction { get; private set; }

        public IPropertyDetailsRepository PropertyDetails { get; private set; }

        public IComplaintRepository Complaint { get; private set; }

        public IComplaintTypeRepository ComplaintType { get; private set; }

        public INatureOfComplaintRepository NatureOfComplaint { get; private set; }

        public IComplaintHistoryRepository ComplaintHistory { get; private set; }

        public IComplaintStatusesRepository ComplaintStatuses { get; private set; }

        public Task<int> Complete()
        {
            return _dbContext.SaveChangesAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                    _dbContext.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}

