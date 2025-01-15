using System;
namespace Modules.Finance.Application.Dtos.Setup
{

    public record InvoiceTypesReadDto(int InvoiceTypesId, string InvoiceInitials, string InvoiceDescriptions, double InvoiceAmount);
    public record InvoiceTypesCreateDto(int InvoiceTypesId, string InvoiceInitials, string InvoiceDescriptions, double InvoiceAmount, string CreatedBy);
    public record InvoiceTypesUpdateDto(int InvoiceTypesId, string InvoiceInitials, string InvoiceDescriptions, double InvoiceAmount, string ModifiedBy);
    public record InvoiceTypesDeleteDto(int InvoiceTypesId);
}

