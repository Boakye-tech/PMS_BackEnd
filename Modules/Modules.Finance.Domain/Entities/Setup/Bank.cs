using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Finance.Domain.Entities.Setup
{
	public class Bank : AuditableEntity
    {
        [Key]
        [Required]
        [StringLength(10)]
        public string BankId { get; set; }

        [Required]
        [StringLength(50)]
        public string BankName { get; set; }


        public Bank(string bankId, string bankName)
        {
            BankId = bankId;
            BankName = bankName;
        }

        public static Bank CreateUpdate(string bankId, string bankName)
        {
            if (string.IsNullOrWhiteSpace(bankId) || string.IsNullOrWhiteSpace(bankName))
                throw new ArgumentException("Invalid Bank Data.");

            if (string.IsNullOrWhiteSpace(bankId) || bankName.Length < 10)
                throw new ArgumentException("Bank Id must be more than 10 characters.");

            if (string.IsNullOrWhiteSpace(bankName) || bankName.Length > 50)
                throw new ArgumentException("Bank Name must not be null or exceed 50 characters.");

            return new Bank(bankId, bankName);
        }

        //public static Bank Update(string bankId, string bankName)
        //{
        //    if (string.IsNullOrWhiteSpace(bankId) || string.IsNullOrWhiteSpace(bankName))
        //    {
        //        throw new ArgumentException("Invalid Bank Data.");
        //    }

        //    if (string.IsNullOrWhiteSpace(bankId) || bankName.Length < 5)
        //        throw new ArgumentException("Bank Id must be more than 5 characters.");

        //    if (string.IsNullOrWhiteSpace(bankName) || bankName.Length > 50)
        //        throw new ArgumentException("Bank Name must not be null or exceed 50 characters.");

        //    return new Bank(bankId, bankName);
        //}

    }

    
}

