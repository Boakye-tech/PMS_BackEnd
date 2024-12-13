using System;
namespace Modules.Finance.Application.Interfaces.Setup
{
	public interface IPayPointsService
    {
        Task<PaypointsReadDto> AddPaypointsAsync(PaypointsCreateDto values);
        Task<PaypointsReadDto> UpdatePaypointsAsync(PaypointsUpdateDto values);
        Task<IEnumerable<PaypointsReadDto>> GetPaypointsAsync();
        Task<PaypointsReadDto> GetPaypointsAsync(int value);
        Task<PaypointsReadDto> GetPaypointsAsync(string value);
    }
}

