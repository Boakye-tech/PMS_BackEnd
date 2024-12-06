using System;

namespace Modules.Estates.Application.Repositories.Setup.Customer
{
	public class NationalityService: INationalityService
    {
		public NationalityService()
		{
		}

        public Task<NationalityReadDto> AddNationalityAsync(NationalityCreateDto values)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<NationalityReadDto>> GetNationalityAsync()
        {
            throw new NotImplementedException();
        }

        public Task<NationalityReadDto> GetNationalityAsync(int value)
        {
            throw new NotImplementedException();
        }

        public Task<NationalityReadDto> GetNationalityAsync(string value)
        {
            throw new NotImplementedException();
        }

        public Task<NationalityReadDto> UpdateNationalityAsync(NationalityUpdateDto values)
        {
            throw new NotImplementedException();
        }
    }
}

