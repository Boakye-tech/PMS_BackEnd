// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Configuration/FeaturesConfiguration.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 22/06/2025 10:45 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;

namespace Modules.Estates.Infrastructure.Configuration
{
	public class FeaturesConfiguration : IEntityTypeConfiguration<Features>
    {
        public void Configure(EntityTypeBuilder<Features> builder)
        {
            builder.HasIndex(f => f.Feature).IsUnique(true);

            builder.HasData(
               new Features(601, "LIVING ROOM"), 
               new Features(602, "BEDROOM"),
               new Features(603, "KITCHEN"), 
               new Features(604, "SANITARY"), 
               new Features(605, "STORE ROOM"),
               new Features(606, "LOBBY"),
               new Features(607, "DINING"),
               new Features(608, "ENT. LOBBY"),
               new Features(609, "BEDROOM 1"),
               new Features(610, "BEDROOM 2"),
               new Features(611, "MASTER BEDROOM"),
               new Features(612, "TERRACE"),
               new Features(613, "CORRIDOR"),
               new Features(614, "UTILITY AREA"),
               new Features(615, "BOX ROOM"),
               new Features(616, "VISITORS WASH ROOM"),
               new Features(617, "KITCHEN STORE"),
               new Features(618, "KITCHEN"),
               new Features(619, "KITCHEN TERRACE"),
               new Features(620, "LIVING AREA"),
               new Features(621, "STUDY"),
               new Features(622, "BALCONY"),
               new Features(623, "CLOSET SPACE"),
               new Features(624, "WASHROOM"),
               new Features(625, "SHARED WASHROOM"),
               new Features(626, "ESCAPE STAIRCASE"),
               new Features(627, "STAIR HALL"),
               new Features(628, "LIFT")
             );
        }
    }
}

