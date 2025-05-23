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
	public interface IInvoiceTypesService
	{
        Task<InvoiceTypesReadDto> AddInvoiceTypesAsync(InvoiceTypesCreateDto values);
        Task<InvoiceTypesReadDto> UpdateInvoiceTypesAsync(InvoiceTypesUpdateDto values);
        Task<IEnumerable<InvoiceTypesReadDto>> GetInvoiceTypesAsync();
        Task<InvoiceTypesReadDto> GetInvoiceTypesAsync(int value);
        //Task<InvoiceTypesReadDto> GetInvoiceTypesAsync(string value);

    }
}

