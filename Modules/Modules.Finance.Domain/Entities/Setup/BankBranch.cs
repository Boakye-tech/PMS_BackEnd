// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Setup/BankBranch.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Domain.Entities.Setup;

public class BankBranch : AuditableEntity
{
    [Required]
    [StringLength(10)]
    public string BankId { get; private set; }

    [Key]
    [Required]
    [StringLength(10)]
    public string BranchId { get; private set; }

    [Required]
    [StringLength(120)]
    public string BranchName { get; private set; }

    public BankBranch(string bankId, string branchId, string branchName)
    {
        BankId = bankId;
        BranchId = branchId;
        BranchName = branchName;
    }

    public static BankBranch Create(string bankId, string branchId, string branchName)
    {
        Validate(bankId, branchId, branchName);
        return new BankBranch(bankId, branchId, branchName);
    }

    public void Update(string bankId, string branchId, string branchName)
    {
        Validate(bankId, branchId, branchName);
        BranchName = branchName;
    }

    private static void Validate(string bankId, string branchId, string branchName)
    {
        if (string.IsNullOrWhiteSpace(bankId) || bankId.Length < 10)
            throw new ArgumentException("The bank id must be more than 10 characters.");

        if (string.IsNullOrWhiteSpace(branchId) || branchId.Length < 10)
            throw new ArgumentException("The bank branch id must be more than 10 characters.");

        if (string.IsNullOrWhiteSpace(branchName) || branchName.Length > 120)
            throw new ArgumentException("The bank branch name must not be null or exceed 120 characters.");
    }
}

