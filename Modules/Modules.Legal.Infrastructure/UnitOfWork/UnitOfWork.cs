// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Legal.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Legal.Infrastructure/UnitOfWork/UnitOfWork.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 15/09/2025 5:34 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.EntityFrameworkCore;
using Modules.Legal.Domain.Interfaces;
using Modules.Legal.Infrastructure.Persistance;
using Modules.Legal.Infrastructure.Repositories.Setups;

namespace Modules.Legal.Infrastructure.UnitOfWork
{
	public class UnitOfWork : IUnitOfWork
    {
        private bool disposedValue;
        private readonly LegalDbContext _dbContext;

        public UnitOfWork(LegalDbContext dbContext)
        {
            _dbContext = dbContext;

            CaseType = new CaseTypeRepository(_dbContext);
            ConsentType = new ConsentTypesRepository(_dbContext);
            Courts = new CourtsRepository(_dbContext);
            CourtDivisions = new CourtDivisionsRepository(_dbContext);
            TransferTypes = new TransferTypesRepository(_dbContext);
            StatusTypes = new StatusTypesRepository(_dbContext);
        }

        public ICaseTypeRepository CaseType { get; private set; }

        public IConsentTypesRepository ConsentType { get; private set; }

        public ICourtsRepository Courts { get; private set; }

        public ICourtDivisionsRepository CourtDivisions { get; private set; }

        public ITransferTypesRepository TransferTypes { get; private set; }

        public IStatusTypesRepository StatusTypes { get; private set; }


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

