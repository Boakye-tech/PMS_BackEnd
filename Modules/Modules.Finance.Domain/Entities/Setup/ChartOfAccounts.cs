// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Setup/ChartOfAccounts.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Domain.Entities.Setup;

public class ChartOfAccounts : AuditableEntity
{
    [Key]
    [Required]
    public int AccountCode { get; private set; }

    [StringLength(50)]
    [Required]
    public string? AccountName { get; private set; }

    public ChartOfAccounts(int accountCode, string accountName)
    {
        AccountCode = accountCode;
        AccountName = accountName;
    }

    public static ChartOfAccounts Create(int accountCode, string accountName)
    {
        Validate(accountCode, accountName);
        return new ChartOfAccounts(accountCode, accountName);
    }

    public void Update(int accountCode, string accountName)
    {
        Validate(accountCode, accountName);
        AccountName = accountName;
    }

    private static void Validate(int accountCode, string accountName)
    {
        if (accountCode <= 0)
            throw new ArgumentException("The chart of account code must be greater than zero.");

        if (string.IsNullOrWhiteSpace(accountName) || accountName.Length > 50)
            throw new ArgumentException("The chart of account name must not be null or exceed 50 characters.");
    }
}

