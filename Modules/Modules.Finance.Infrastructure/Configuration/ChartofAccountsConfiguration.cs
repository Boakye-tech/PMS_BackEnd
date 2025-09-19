// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Infrastructure/Configuration/ChartofAccountsConfiguration.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 19/09/2025 8:06 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Modules.Finance.Infrastructure.Configuration
{
    public class ChartofAccountsConfiguration : IEntityTypeConfiguration<ChartOfAccounts>
    {

        public void Configure(EntityTypeBuilder<ChartOfAccounts> builder)
        {
            builder.HasIndex("AccountCode").IsUnique(true);
            builder.HasIndex("AccountName").IsUnique(true);

            builder.HasData
                (
                new ChartOfAccounts(accountCode:23001, accountName:"HOUSE RENT DEBTORS"),
                new ChartOfAccounts(accountCode:23002, accountName:"SHOP RENT DEBTORS"),
                new ChartOfAccounts(accountCode:23003, accountName:"GROUND RENT DEBTORS"),
                new ChartOfAccounts(accountCode:53001, accountName:"APPLICATION FORMS")

                );
        }
    }
}

