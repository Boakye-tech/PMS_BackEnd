// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Application/Dto/Setup/StockDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/07/2025 10:00 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Facilities.Application.Dto.Setup
{
    public record StockReadDto(
        int stockId,
        string? stockNumber,
        string? itemCode,
        int quantity,
        decimal unitPrice,
        int supplierId,
        DateTime transactionDate,
        string? transactionType,
        string? receiptNoteNumber,
        int? quantityReceived,
        string? issueNoteNumber,
        int? quantityIssues,
        string? remarks,
        int lowStockThreshold,
        DateTime? lastRestockedDate
    );

    public record StockCreateDto(
        string? stockNumber,
        string? itemCode,
        int quantity,
        decimal unitPrice,
        int supplierId,
        DateTime transactionDate,
        string? transactionType,
        string? receiptNoteNumber,
        int? quantityReceived,
        string? issueNoteNumber,
        int? quantityIssues,
        string? remarks,
        int lowStockThreshold,
        DateTime? lastRestockedDate,
        string createdBy
    );

    public record StockUpdateDto(
        int stockId,
        string? stockNumber,
        string? itemCode,
        int quantity,
        decimal unitPrice,
        int supplierId,
        DateTime transactionDate,
        string? transactionType,
        string? receiptNoteNumber,
        int? quantityReceived,
        string? issueNoteNumber,
        int? quantityIssues,
        string? remarks,
        int lowStockThreshold,
        DateTime? lastRestockedDate,
        string modifiedBy
    );

    public record StockDeleteDto(int stockId);
}