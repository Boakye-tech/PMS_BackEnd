using System;
namespace Modules.Finance.Application.Interfaces.Setup
{
	public interface IFormsService
	{
        Task<FormsReadDto> AddFormsAsync(FormsCreateDto values);
        Task<FormsReadDto> UpdateFormsAsync(FormsUpdateDto values);
        Task<IEnumerable<FormsReadDto>> GetFormsAsync();
        Task<FormsReadDto> GetFormsAsync(int value);
        Task<FormsReadDto> GetFormsAsync(string value);
    }
}

