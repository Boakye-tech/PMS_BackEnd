// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/Features.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/05/2025 01:03 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using AutoMapper.Features;

namespace Modules.Estates.Domain.Entities.Setup.Property
{
    public class Features : AuditableEntity
    {
        
        [Key]
        [Required]
        public int FeaturesId { get; private set; }

         [Required]
        [StringLength(50)]
        public string Feature { get; private set; }


        public Features( int featuresId, string feature)
        {
            FeaturesId = featuresId;
            Feature = feature;
        }

        public static Features Create( int featuresId, string feature)
        {
            Validate(featuresId, feature);
            return new Features(featuresId, feature);
        }

        public void Update(int featuresId, string feature)
        {
            Validate(featuresId, feature);
            FeaturesId = featuresId;
            Feature = feature;
        }

        private static void Validate(int featuresId,  string feature)
        {
            if (featuresId < 0)
                throw new ArgumentException("Feature Id must be greater than zero.");

           
            if (string.IsNullOrWhiteSpace(feature))
                throw new ArgumentException("Feature cannot be empty or exceed 50 characters.");

        }

        
    }
}

