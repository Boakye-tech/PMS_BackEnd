// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Infrastructure
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Infrastructure/Configuration/PlotFeaturesConfiguration.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 30/06/2025 1:15 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;

namespace Modules.Estates.Infrastructure.Configuration
{
	public class PlotFeaturesConfiguration : IEntityTypeConfiguration<PlotFeatures>
    {

        public void Configure(EntityTypeBuilder<PlotFeatures> builder)
        {
            builder.HasIndex(pf => new { pf.PlotTypeId, pf.FeaturesId })
                .IsUnique(true);


        }
    }
}

