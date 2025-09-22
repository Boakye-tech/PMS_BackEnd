// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Legal.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Legal.Infrastructure/Configurations/CourtDivisionsConfiguration.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 21/09/2025 9:35 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.Numerics;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Modules.Legal.Domain.Entities.Setups;

namespace Modules.Legal.Infrastructure.Configurations
{
	public class CourtDivisionsConfiguration : IEntityTypeConfiguration<CourtDivisions>
    {
        public void Configure(EntityTypeBuilder<CourtDivisions> builder)
        {
            builder.HasIndex(cd => cd.CourtDivision).IsUnique(true);

            //builder.HasData(
            //    new CourtDivisions("SUPREME COURT, ACCRA", 1),

            //    new CourtDivisions("COURT OF APPEAL (CRIMINAL & CIVIL) ACCRA", 2),

            //    new CourtDivisions("HIGH COURT, LAND DIVISION TEMA", 3),
            //    new CourtDivisions("HIGH COURT, TEMA", 3), 
            //    new CourtDivisions("HIGH COURTS - LAW COURT COMPLEX ACCRA", 3),

            //    new CourtDivisions("CIRCUIT & DISTRICT COURTS, WEIJA-OBLOGO", 4),
            //    new CourtDivisions("CIRCUIT COURT A & B	TEMA", 4),
            //    new CourtDivisions("CIRCUIT COURT, ACCRA", 4),
            //    new CourtDivisions("CIRCUIT COURT, ASHAIMAN", 4),

            //    new CourtDivisions("DISTRICT COURT TESHIE-NUNGUA", 5),
            //    new CourtDivisions("DISTRICT COURT	AMASAMAN", 5),
            //    new CourtDivisions("DISTRICT COURT	ADENTAN", 5),
            //    new CourtDivisions("DISTRICT COURT	BIG ADA", 5),
            //    new CourtDivisions("DISTRICT COURT	LA-TRADE FAIR, LADMA", 5),
            //    new CourtDivisions("DISTRICT COURT (TDC) TEMA", 5),
            //    new CourtDivisions("DISTRICT COURT 1 &2	TEMA", 5),
            //    new CourtDivisions("DISTRICT COURT, ABEKA ABEKA", 5),
            //    new CourtDivisions("DISTRICT COURT, ASHAIMAN", 5),
            //    new CourtDivisions("DISTRICT COURT, MADINA", 5),
            //    new CourtDivisions("DISTRICT COURT, PRAMPRAM", 5),
            //    new CourtDivisions("DISTRICT COURT, SEGE-ADA WEST", 5),
            //    new CourtDivisions("FAMILY & JUVENILE COURT	ACCRA", 5),
            //    new CourtDivisions("ADJABENG DISTRICT COURT	ADJABENG ACCRA", 5)
            //    );
        }
    }
}

