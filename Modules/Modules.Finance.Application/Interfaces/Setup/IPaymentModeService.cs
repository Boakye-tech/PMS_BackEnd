using System;
namespace Modules.Finance.Application.Interfaces.Setup
{
	public interface IPaymentModeService
	{
        Task<PaymentModeReadDto> AddPaymentModeAsync(PaymentModeCreateDto values);
        Task<PaymentModeReadDto> UpdatePaymentModeAsync(PaymentModeUpdateDto values);
        Task<IEnumerable<PaymentModeReadDto>> GetPaymentModeAsync();
        Task<PaymentModeReadDto> GetPaymentModeAsync(int value);
        Task<PaymentModeReadDto> GetPaymentModeAsync(string value);
    }
}

