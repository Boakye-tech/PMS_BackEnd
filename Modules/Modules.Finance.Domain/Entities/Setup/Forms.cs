// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Domain.Entities.Setup
{
	public class Forms : AuditableEntity
	{
        [Key]
        [Required]
        [StringLength(5)]
        public string? FormCode { get; set; }

        [Required]
        [StringLength(50)]
        public string? FormName { get; set; }

        [Required]
        public double Amount { get; set; }

        [Required]
        public int AccountCode { get; set; }


        public Forms(string formCode, string formName, double amount, int accountCode)
        {
            FormCode = formCode;
            FormName = formName;
            Amount = amount;
            AccountCode = accountCode;
        }

        public static Forms CreateUpdate(string formCode, string formName, double amount, int accountCode)
        {
            if (string.IsNullOrWhiteSpace(formCode) || string.IsNullOrWhiteSpace(formName) || amount < 0 || accountCode < 0)
            {
                throw new ArgumentException("Invalid Forms Data.");
            }

            if (string.IsNullOrWhiteSpace(formCode) || formName.Length > 5)
                throw new ArgumentException("Form code must not be null or exceed 5 characters.");

            if (amount <= 0)
                throw new ArgumentException("Forms amount must be greater than zero.");

            if (accountCode <= 0)
                throw new ArgumentException("Forms account code must be greater than zero.");

            if (string.IsNullOrWhiteSpace(formName) || formName.Length > 50)
                throw new ArgumentException("Form names must not be null or exceed 50 characters.");

            return new Forms(formCode, formName, amount, accountCode);
        }
    }
}

