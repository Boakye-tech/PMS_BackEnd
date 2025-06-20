// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Setup/Bank.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Domain.Entities.Setup;

public class Bank : AuditableEntity
{
    [Key]
    [Required]
    [StringLength(10)]
    public string BankId { get; private set; }

    [Required]
    [StringLength(50)]
    public string BankName { get; private set; }

    public Bank(string bankId, string bankName)
    {
        BankId = bankId;
        BankName = bankName;
    }

    public static Bank Create(string bankId, string bankName)
    {
        Validate(bankId, bankName);
        return new Bank(bankId, bankName);
    }

    public void Update(string bankId, string bankName)
    {
        Validate(bankId, bankName);
        BankName = bankName;
    }

    private static void Validate(string bankId, string bankName)
    {
        if (string.IsNullOrWhiteSpace(bankId) || bankId.Length < 10)
            throw new ArgumentException("Bank Id must be more than 10 characters.");

        if (string.IsNullOrWhiteSpace(bankName) || bankName.Length > 50)
            throw new ArgumentException("Bank Name must not be null or exceed 50 characters.");
    }
}

