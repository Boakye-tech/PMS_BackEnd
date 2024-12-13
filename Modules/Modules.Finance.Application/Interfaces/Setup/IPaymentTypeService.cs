using System;
namespace Modules.Finance.Application.Interfaces.Setup
{
	public interface IPaymentTypeService
	{
        Task<PaymentTypeReadDto> AddPaymentTypeAsync(PaymentTypeCreateDto values);
        Task<PaymentTypeReadDto> UpdatePaymentTypeAsync(PaymentTypeUpdateDto values);
        Task<IEnumerable<PaymentTypeReadDto>> GetPaymentTypeAsync();
        Task<PaymentTypeReadDto> GetPaymentTypeAsync(int value);
        Task<PaymentTypeReadDto> GetPaymentTypeAsync(string value);
    }
}

