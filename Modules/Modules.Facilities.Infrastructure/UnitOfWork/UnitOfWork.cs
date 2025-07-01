// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Infrastructure/UnitOfWork/UnitOfWork.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/07/2025 9:30 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Facilities.Infrastructure.UnitOfWork
{
	public class UnitOfWork : IUnitOfWork
    {
        private bool disposedValue;
        private readonly FacilitiesDbContext _dbContext;

        public UnitOfWork(FacilitiesDbContext dbContext)
		{
            _dbContext = dbContext;

            Category = new CategoryRepository(_dbContext);
            Cleaners = new CleanersRepository(_dbContext);
            Items = new ItemsRepository(_dbContext);
            ItemsCategory = new ItemsCategoryRepository(_dbContext);
            ServiceCategory = new ServiceCategoryRepository(_dbContext);
            ServiceProviders = new ServiceProvidersRepository(_dbContext);
            Services = new ServicesRepository(_dbContext);
            Stock = new StockRepository(_dbContext);
            Suppliers = new SuppliersRepository(_dbContext);
        }

        public ICategoryRepository Category { get; private set; }

        public ICleanersRepository Cleaners { get; private set; }

        public IItemsRepository Items { get; private set; }

        public IItemsCategoryRepository ItemsCategory { get; private set; }

        public IServiceCategoryRepository ServiceCategory { get; private set; }

        public IServiceProvidersRepository ServiceProviders { get; private set; }

        public IServicesRepository Services { get; private set; }

        public IStockRepository Stock { get; private set; }

        public ISuppliersRepository Suppliers { get; private set; }



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

