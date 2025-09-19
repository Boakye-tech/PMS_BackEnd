// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Infrastructure/Configuration/DebtorGroupsConfiguration.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 19/09/2025 3:30 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Modules.Finance.Infrastructure.Configuration
{
    public class DebtorGroupsConfiguration : IEntityTypeConfiguration<DebtorGroups>
    {
        public void Configure(EntityTypeBuilder<DebtorGroups> builder)
        {
            builder.HasData
                (
                new DebtorGroups(debtorTypesId: 2, debtorGroupsId: 1, groupName: "16", "REGGIMANUEL RESIDENTIAL WITHOUT ACREAGE COMM.19"),
                new DebtorGroups(debtorTypesId: 2, debtorGroupsId: 13, groupName: "17", "COMM.13 HOUSE WITHOUT ACREAGE"),
                new DebtorGroups(debtorTypesId: 2, debtorGroupsId: 14, groupName: "26", "OTHER HOUSES AT COMM.13"),

                new DebtorGroups(debtorTypesId: 3, debtorGroupsId: 2, groupName: "1", "COMMUNITIES - 6,10,15,18,19,20,22,25"),
                new DebtorGroups(debtorTypesId: 3, debtorGroupsId: 3, groupName: "2", "COMMUNITIES - 3,5,11,12,13,14"),
                new DebtorGroups(debtorTypesId: 3, debtorGroupsId: 4, groupName: "3", "COMMUNITIES - 1,2,4,7,8,9. 22(UNSERVICED) KLANGON"),
                new DebtorGroups(debtorTypesId: 3, debtorGroupsId: 5, groupName: "4", "COMMUNITIES - 16,17,19ANX,23,SAKUMON"),
                new DebtorGroups(debtorTypesId: 3, debtorGroupsId: 6, groupName: "5", "TEMA NEW-TOWN"),
                new DebtorGroups(debtorTypesId: 3, debtorGroupsId: 7, groupName: "6", "TSUI BLEOO,GOLF.SAKI,BETHLEHAM,KPN"),
                new DebtorGroups(debtorTypesId: 3, debtorGroupsId: 8, groupName: "7", "COMMUNITY 25 PARTIAL"),
                new DebtorGroups(debtorTypesId: 3, debtorGroupsId: 9, groupName: "8", "COMMUNITY 24"),
                new DebtorGroups(debtorTypesId: 3, debtorGroupsId: 10, groupName: "9", "LARGE SCALE TRJ"),

                new DebtorGroups(debtorTypesId: 7, debtorGroupsId: 11, groupName: "1", "AGRIC PLOTS"),
                new DebtorGroups(debtorTypesId: 7, debtorGroupsId: 12, groupName: "2", "AGRIC INDUSTRIAL PLOT(PLUS 0.5) OF IND. PLOT")
                );
        }
    }
}

