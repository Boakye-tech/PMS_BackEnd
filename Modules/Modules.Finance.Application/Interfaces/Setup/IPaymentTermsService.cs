// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 20/09/2025 4:45 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Finance.Application.Interfaces.Setup
{
    public interface IPaymentTermsService
    {
        Task<IEnumerable<PaymentTermsReadDto>> GetPaymentTermsAsync();
        Task<PaymentTermsReadDto> GetPaymentTermsAsync(int value);
        Task<PaymentTermsReadDto> GetPaymentTermsByTermAsync(int paymentTerm);
        Task<ReturnResponsesDto> CreatePaymentTermsAsync(PaymentTermsCreateDto values);
        Task<ReturnResponsesDto> UpdatePaymentTermsAsync(PaymentTermsUpdateDto values);
        Task<ReturnResponsesDto> DeletePaymentTermsAsync(int paymentTermsId);
    }
}
