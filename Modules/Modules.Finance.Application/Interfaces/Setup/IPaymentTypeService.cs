// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Finance.Application.Interfaces.Setup
{
    public interface IPaymentTypeService
    {
        Task<IEnumerable<PaymentTypeReadDto>> GetPaymentTypeAsync();
        Task<PaymentTypeReadDto> GetPaymentTypeAsync(int value);
        Task<PaymentTypeReadDto> GetPaymentTypeAsync(string value);
        Task<ReturnResponsesDto> CreatePaymentTypeAsync(PaymentTypeCreateDto values);
        Task<ReturnResponsesDto> UpdatePaymentTypeAsync(PaymentTypeUpdateDto values);
        Task<ReturnResponsesDto> DeletePaymentTypeAsync(int paymentTypeId);
    }
}

