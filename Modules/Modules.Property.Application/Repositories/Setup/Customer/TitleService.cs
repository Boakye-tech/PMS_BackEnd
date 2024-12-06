using System;

namespace Modules.Estates.Application.Repositories.Setup.Customer
{
	public class TitleService: ITitleService
    {
		public TitleService()
		{
		}

        public Task<TitleReadDto> AddTitleAsync(TitleCreateDto values)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TitleReadDto>> GetTitleAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TitleReadDto> GetTitleAsync(int value)
        {
            throw new NotImplementedException();
        }

        public Task<TitleReadDto> GetTitleAsync(string value)
        {
            throw new NotImplementedException();
        }

        public Task<TitleReadDto> UpdateTitleAsync(TitleUpdateDto values)
        {
            throw new NotImplementedException();
        }
    }
}

