using System;

namespace Modules.Estates.Application.Repositories.Setup.Customer
{
	public class ResidentTypeService: IResidentTypeService
    {
		public ResidentTypeService()
		{
		}

        public Task<ResidentTypeReadDto> AddResidentTypeAsync(ResidentTypeCreateDto values)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ResidentTypeReadDto>> GetResidentTypeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ResidentTypeReadDto> GetResidentTypeAsync(int value)
        {
            throw new NotImplementedException();
        }

        public Task<ResidentTypeReadDto> GetResidentTypeAsync(string value)
        {
            throw new NotImplementedException();
        }

        public Task<ResidentTypeReadDto> UpdateResidentTypeAsync(ResidentTypeUpdateDto values)
        {
            throw new NotImplementedException();
        }
    }
}

