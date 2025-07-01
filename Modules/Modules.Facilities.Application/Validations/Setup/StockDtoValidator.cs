// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Application/Validations/Setup/StockDtoValidator.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/07/2025 10:20 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Facilities.Application.Validations.Setup
{
    public class StockDtoValidator : AbstractValidator<StockCreateDto>
    {
        public StockDtoValidator()
        {
            RuleFor(x => x.stockNumber).NotEmpty().MaximumLength(20);
            RuleFor(x => x.itemCode).NotEmpty().MaximumLength(20);
            RuleFor(x => x.quantity).GreaterThanOrEqualTo(0);
            RuleFor(x => x.unitPrice).GreaterThanOrEqualTo(0);
            RuleFor(x => x.supplierId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.transactionDate).NotEmpty();
            RuleFor(x => x.transactionType).NotEmpty().MaximumLength(20);
            RuleFor(x => x.receiptNoteNumber).MaximumLength(50);
            RuleFor(x => x.issueNoteNumber).MaximumLength(50);
            RuleFor(x => x.remarks).MaximumLength(500);
            RuleFor(x => x.lowStockThreshold).GreaterThanOrEqualTo(0);
            RuleFor(x => x.createdBy).Length(36);
        }
    }

    public class StockUpdateDtoValidator : AbstractValidator<StockUpdateDto>
    {
        public StockUpdateDtoValidator()
        {
            RuleFor(x => x.stockId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.stockNumber).NotEmpty().MaximumLength(20);
            RuleFor(x => x.itemCode).NotEmpty().MaximumLength(20);
            RuleFor(x => x.quantity).GreaterThanOrEqualTo(0);
            RuleFor(x => x.unitPrice).GreaterThanOrEqualTo(0);
            RuleFor(x => x.supplierId).GreaterThanOrEqualTo(0);
            RuleFor(x => x.transactionDate).NotEmpty();
            RuleFor(x => x.transactionType).NotEmpty().MaximumLength(20);
            RuleFor(x => x.receiptNoteNumber).MaximumLength(50);
            RuleFor(x => x.issueNoteNumber).MaximumLength(50);
            RuleFor(x => x.remarks).MaximumLength(500);
            RuleFor(x => x.lowStockThreshold).GreaterThanOrEqualTo(0);
            RuleFor(x => x.modifiedBy).Length(36);
        }
    }
}