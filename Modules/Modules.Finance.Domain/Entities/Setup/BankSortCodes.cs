// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Setup/BankSortCodes.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Domain.Entities.Setup;

public class BankSortCodes : AuditableEntity
{
    [Key]
    public int BankSortCodesId { get; private set; }

    [Required]
    [StringLength(6)]
    public string? SortCode { get; private set; }

    [Required]
    [StringLength(50)]
    public string? BankName { get; private set; }

    [Required]
    [StringLength(120)]
    public string? BranchName { get; private set; }

    public BankSortCodes()
    {
    }

    public BankSortCodes(int id, string sortCode, string bankName, string branchName)
    {
        BankSortCodesId = id;
        SortCode = sortCode;
        BankName = bankName;
        BranchName = branchName;
    }

    public static BankSortCodes Create(int id, string sortCode, string bankName, string branchName)
    {
        Validate(id, sortCode, bankName, branchName);
        return new BankSortCodes(id, sortCode, bankName, branchName);
    }

    public void Update(int id, string sortCode, string bankName, string branchName)
    {
        Validate(id, sortCode, bankName, branchName);
        SortCode = sortCode;
        BankName = bankName;
        BranchName = branchName;
    }

    private static void Validate(int id, string sortCode, string bankName, string branchName)
    {
        if (id <= 0)
            throw new ArgumentException("The bank sort code ID must be greater than zero.");

        if (string.IsNullOrWhiteSpace(sortCode) || sortCode.Length > 6)
            throw new ArgumentException("The sort code must not be null or exceed 6 characters.");

        if (string.IsNullOrWhiteSpace(bankName) || bankName.Length > 50)
            throw new ArgumentException("The bank name must not be null or exceed 50 characters.");

        if (string.IsNullOrWhiteSpace(branchName) || branchName.Length > 120)
            throw new ArgumentException("The bank branch name must not be null or exceed 120 characters.");
    }
}

