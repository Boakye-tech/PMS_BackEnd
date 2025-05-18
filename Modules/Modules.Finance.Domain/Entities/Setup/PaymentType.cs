// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Setup/PaymentType.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Domain.Entities.Setup;

public class PaymentType : AuditableEntity
{
    [Key]
    [Required]
    public int PaymentTypeId { get; private set; }

    [Required]
    [StringLength(20)]
    public string PaymentTypes { get; private set; }

    public PaymentType(int paymentTypeId, string paymentTypes)
    {
        PaymentTypeId = paymentTypeId;
        PaymentTypes = paymentTypes;
    }

    public static PaymentType Create(int paymentTypeId, string paymentType)
    {
        Validate(paymentTypeId, paymentType);
        return new PaymentType(paymentTypeId, paymentType);
    }

    public void Update(int paymentTypeId, string paymentType)
    {
        Validate(paymentTypeId, paymentType);
        PaymentTypes = paymentType;
    }

    private static void Validate(int paymentTypeId, string paymentType)
    {
        if (paymentTypeId <= 0)
            throw new ArgumentException("The payment type id must be greater than zero.");

        if (string.IsNullOrWhiteSpace(paymentType) || paymentType.Length > 20)
            throw new ArgumentException("The payment type must not be null or exceed 20 characters.");
    }
}

