// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Domain/Entities/Setup/Property/Sites.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 04/06/2025 8:26 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Domain.Entities.Setup.Property
{
	public class Sites : AuditableEntity
    {
        [Required]
        public int LocalityId { get; private set; }

        [Key]
        [Required]
        public int SitesId { get; private set; }

        [Required]
        [StringLength(50)]
        public string SiteName { get; private set; }


        // Navigation property for Locality
        public virtual Locality? Locality { get; private set; }


        public Sites(int localityId, int sitesId, string siteName)
		{
            LocalityId = localityId;
            SitesId = sitesId;
            SiteName = siteName;
		}

        public static Sites Create(int localityId, int sitesId, string siteName)
        {
            Validate(localityId, sitesId, siteName);
            return new Sites(localityId, sitesId, siteName);
        }

        public void Update(int localityId, int sitesId, string siteName)
        {
            Validate(localityId, sitesId, siteName);
            LocalityId = localityId;
            SitesId = sitesId;
            SiteName = siteName;
        }

        private static void Validate(int localityId, int sitesId, string siteName)
        {
            if (localityId <= 0)
                throw new ArgumentException("Locality Id must be greater than zero.");

            if (sitesId < 0)
                throw new ArgumentException("Site Id must be greater than zero.");

            if (string.IsNullOrWhiteSpace(siteName) || siteName.Length > 50)
                throw new ArgumentException("Site Name cannot be empty or exceed 50 characters.");

        }
    }


}

