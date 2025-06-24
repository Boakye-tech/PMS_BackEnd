// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Configuration/FeaturesConfiguration.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 22/0/2025 10:45 PM
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
               new Features(1, "LIVING ROOM"), 
               new Features(2, "BEDROOM"),
               new Features(3, "KITCHEN"), 
               new Features(4, "SANITARY"), 
               new Features(5, "STORE ROOM"),
               new Features(6, "LOBBY"),
               new Features(7, "DINING"),
               new Features(8, "ENT. LOBBY"),
               new Features(9, "BEDROOM 1"),
               new Features(10, "BEDROOM 2"),
               new Features(11, "MASTER BEDROOM"),
               new Features(12, "TERRACE"),
               new Features(13, "CORRIDOR"),
               new Features(14, "UTILITY AREA"),
               new Features(15, "BOX ROOM"),
               new Features(16, "VISITORS WASH ROOM"),
               new Features(17, "KITCHEN STORE"),
               new Features(18, "KITCHEN TERRACE"),
               new Features(19, "LIVING AREA"),
               new Features(20, "STUDY"),
               new Features(21, "BALCONY"),
               new Features(22, "CLOSET SPACE"),
               new Features(23, "WASHROOM"),
               new Features(24, "SHARED WASHROOM"),
               new Features(25, "ESCAPE STAIRCASE"),
               new Features(26, "STAIR HALL"),
               new Features(27, "LIFT")
             );
        }
    }
}

