// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Finance.Application.Dtos.Setup
{

    public record InvoiceTypesReadDto(int InvoiceTypesId, string InvoiceInitials, string InvoiceDescriptions, double InvoiceAmount);
    public record InvoiceTypesCreateDto(int InvoiceTypesId, string InvoiceInitials, string InvoiceDescriptions, double InvoiceAmount, string CreatedBy);
    public record InvoiceTypesUpdateDto(int InvoiceTypesId, string InvoiceInitials, string InvoiceDescriptions, double InvoiceAmount, string ModifiedBy);
    public record InvoiceTypesDeleteDto(int InvoiceTypesId);
}

