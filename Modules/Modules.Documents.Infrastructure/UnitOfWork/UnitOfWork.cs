// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Documents.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Documents.Infrastructure/UnitOfWork/UnitOfWork.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 29/08/2025 1:52 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.EntityFrameworkCore;


namespace Modules.Documents.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
	{
        private bool disposedValue;
        private readonly ApplicationDbContext _dbContext;

        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;

            FormTemplates = new FormTemplatesRepository(_dbContext);
            FormSections = new FormSectionsRepository(_dbContext);
            FormFields = new FormFieldsRepository(_dbContext);


            ApplicationSubmissionForms = new ApplicationFormSubmissionRepository(_dbContext);
            ApplicationSubmissionFromsResponse = new ApplicationFormResponseRepository(_dbContext);
        }

        public IFormTemplatesRepository FormTemplates { get; private set; }
        public IFormSectionsRepository FormSections { get; private set; }
        public IFormFieldsRepository FormFields { get; private set; }

        public IApplicationFormSubmissionRepository ApplicationSubmissionForms { get; private set; }
        public IApplicationFormResponseRepository ApplicationSubmissionFromsResponse { get; private set; }

        

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

