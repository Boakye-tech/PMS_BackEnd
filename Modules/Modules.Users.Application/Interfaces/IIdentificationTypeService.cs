using System;
namespace Modules.Users.Application.Interfaces
{
	public interface IIdentificationTypeService
	{
        Task<IdentificationTypeDto> AddIdentificationTypeAsync(IdentificationTypeDto values);
        Task<IdentificationTypeDto> UpdateIdentificationTypeAsync(IdentificationTypeDto values);
        Task<IEnumerable<IdentificationTypeDto>> GetIdentificationTypeAsync();

        Task<string> DeleteIdentificationTypeAsync(int value);
    }
}

