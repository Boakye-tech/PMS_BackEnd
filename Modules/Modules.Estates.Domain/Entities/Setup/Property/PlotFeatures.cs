// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/PlotFeatures.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 30/06/2025 11:05 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Domain.Entities.Setup.Property
{
	public class PlotFeatures : AuditableEntity
	{
        [Key]
        [Required]
        public int PlotFeaturesId { get; private set; }

        [Required]
        public int PlotTypeId { get; private set; }

        // Navigation property for Plot Types
        public virtual PlotType? PlotType { get; private set; }

        [Required]
        public int FeaturesId { get; private set; }

        // Navigation property for Features
        public virtual Features? Features { get; private set; }

        public PlotFeatures(int plotFeaturesId, int plotTypeId, int featuresId)
		{
            PlotFeaturesId = plotFeaturesId;
            PlotTypeId = plotTypeId;
            FeaturesId = featuresId;
        }


        public static PlotFeatures Create(int plotFeaturesId, int plotTypeId, int featuresId)
        {
            Validate(plotFeaturesId, plotTypeId, featuresId);
            return new PlotFeatures(plotFeaturesId, plotTypeId, featuresId);
        }

        public void Update(int plotFeaturesId, int plotTypeId, int featuresId)
        {
            Validate(plotFeaturesId, plotTypeId, featuresId);

            PlotTypeId = plotTypeId;
            FeaturesId = featuresId;
        }

        private static void Validate(int plotFeaturesId, int plotTypeId, int featuresId)
        {
            if (plotFeaturesId < 0)
                throw new ArgumentException("Plot Features Id must be greater than zero.");

            if (plotTypeId <= 0)
                throw new ArgumentException("Plot Type Id must be greater than zero.");

            if (featuresId <= 0)
                throw new ArgumentException("Features Id must be greater than zero.");


        }
    }
}

