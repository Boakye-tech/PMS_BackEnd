// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Application/Dtos/Setup/InvoiceTypesDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Finance.Application.Dtos.Setup
{

    public record InvoiceTypesReadDto(int InvoiceTypesId, string InvoiceName, string InvoiceDescriptions, int DepartmentId, int DepartmentUnitId, int RoomNumber, int PaymentTermsId, List<ServicesReadDto> Services);
    public record InvoiceTypesCreateDto(string InvoiceName, string InvoiceDescriptions, int DepartmentId, int DepartmentUnitId, int RoomNumber, int PaymentTermsId, List<int> ServicesId, string CreatedBy);
    public record InvoiceTypesUpdateDto(int InvoiceTypesId, string InvoiceName, string InvoiceDescriptions, int DepartmentId, int DepartmentUnitId, int RoomNumber, int PaymentTermsId, List<int> ServicesId, string ModifiedBy);
    public record InvoiceTypesDeleteDto(int InvoiceTypesId);

}

