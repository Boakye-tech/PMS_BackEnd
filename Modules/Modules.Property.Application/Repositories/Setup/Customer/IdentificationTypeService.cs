using System;

namespace Modules.Estates.Application.Repositories.Setup.Customer
{
	public class IdentificationTypeService : IIdentificationTypeService
    {
		public IdentificationTypeService()
		{
		}

        public Task<IdentificationTypeReadDto> AddIdentificationTypeAsync(IdentificationTypeCreateDto values)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<IdentificationTypeReadDto>> GetIdentificationTypeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IdentificationTypeReadDto> GetIdentificationTypeAsync(int value)
        {
            throw new NotImplementedException();
        }

        public Task<IdentificationTypeReadDto> GetIdentificationTypeAsync(string value)
        {
            throw new NotImplementedException();
        }

        public Task<IdentificationTypeReadDto> UpdateIdentificationTypeAsync(IdentificationTypeUpdateDto values)
        {
            throw new NotImplementedException();
        }
    }
}

