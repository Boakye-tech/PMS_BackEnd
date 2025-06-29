// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Customers.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Customers.Domain/Entities/CustomerOpeningBalances.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 28/06/2025 8:02 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Modules.Customers.Domain.Entities
{
	public class CustomerOpeningBalances : AuditableEntity
	{
        [Key]
        public int Id { get; private set; }

        [Required]
        [StringLength(75)]
        public string? PropertyNumber { get; private set; }

        [Required]
        [StringLength(10)]
        public string? CustomerCode { get; private set; }

        [Required]
        [StringLength(10)]
        public string? AccountCode { get; private set; }

        [Required]
        public decimal OpeningBalance { get; private set; }

        [Required]
        public int Years { get; private set; }

        public CustomerOpeningBalances()
		{
		}

        public CustomerOpeningBalances(int id, string propertyNumber, string customerCode, string accountCode, decimal openingBalance, int years)
        {
        }

        public static CustomerOpeningBalances AddCustomerOpeningBalances(int id, string propertyNumber, string customerCode, string accountCode, decimal openingBalance, int years)
        {
            if (string.IsNullOrWhiteSpace(propertyNumber) || string.IsNullOrWhiteSpace(customerCode) || string.IsNullOrWhiteSpace(accountCode) || openingBalance < 0 || years < 0)
            {
                throw new ArgumentException("Invalid customer opening balance details data.");
            }

            if (string.IsNullOrWhiteSpace(propertyNumber))
            {
                throw new ArgumentException("Property number must not be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(customerCode))
            {
                throw new ArgumentException("Customer code must not be null or empty.");
            }

            if (string.IsNullOrWhiteSpace(accountCode))
            {
                throw new ArgumentException("Account Code must not be null or empty.");
            }

            if (years <= 0)
            {
                throw new ArgumentException("The year must be greater than zero.");
            }

            return new CustomerOpeningBalances
            {
                Id = id,
                PropertyNumber = propertyNumber,
                CustomerCode = customerCode,
                AccountCode = accountCode,
                OpeningBalance = openingBalance,
                Years = years
            };

        }

    }
}

