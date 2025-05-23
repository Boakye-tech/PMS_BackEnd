﻿// /**************************************************
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
	public interface IPaymentModeService
	{
        Task<PaymentModeReadDto> AddPaymentModeAsync(PaymentModeCreateDto values);
        Task<PaymentModeReadDto> UpdatePaymentModeAsync(PaymentModeUpdateDto values);
        Task<IEnumerable<PaymentModeReadDto>> GetPaymentModeAsync();
        Task<PaymentModeReadDto> GetPaymentModeAsync(int value);
        Task<PaymentModeReadDto> GetPaymentModeAsync(string value);
    }
}

