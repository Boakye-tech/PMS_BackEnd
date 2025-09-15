// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Legal.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Legal.Domain/Entities/Setups/CourtDivisions.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/09/2025 11:36 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Legal.Domain.Entities.Setups
{
    public class CourtDivisions : AuditableEntity
    {
        [Key]
        [Required]
        public int CourtDivisionsId { get; private set; }

        [Required]
        [StringLength(50)]
        public string CourtDivision { get; private set; }

        // Foreign keys
        [Required]
        public int CourtsId { get; private set; }

        // Navigation properties
        public Courts? Court { get; }

        // Private constructor for EF Core
        private CourtDivisions()
        {
            CourtDivision = string.Empty;
        }

        public CourtDivisions(int courtDivisionsId, string courtDivision, int courtsId)
        {
            Validate(courtDivisionsId, courtDivision, courtsId);

            CourtDivisionsId = courtDivisionsId;
            CourtDivision = courtDivision ?? throw new ArgumentNullException(nameof(courtDivision));
            CourtsId = courtsId;
        }

        // Convenience overload to preserve existing callers
        public CourtDivisions(string courtDivision, int courtsId) : this(0, courtDivision, courtsId) { }

        // Domain methods
        public void UpdateCourtDivision(int courtDivisionsId, string courtDivision, int courtsId)
        {
            Validate(courtDivisionsId, courtDivision, courtsId);

            CourtDivisionsId = courtDivisionsId;
            CourtDivision = courtDivision ?? throw new ArgumentNullException(nameof(courtDivision));
            CourtsId = courtsId;
        }

        private static void Validate(int courtDivisionsId, string courtDivision, int courtsId)
        {
            if ((courtDivisionsId < 0 || string.IsNullOrWhiteSpace(courtDivision)))
            {
                throw new ArgumentException("Invalid Court Division Data.");
            }

            if (courtDivisionsId < 0)
                throw new ArgumentException("Court Division Id must be greater than or equal to zero.");

            if (courtsId <= 0)
                throw new ArgumentException("Courts Id must be greater than zero.");

            if (string.IsNullOrWhiteSpace(courtDivision) || courtDivision.Length > 50)
                throw new ArgumentException("Court Division cannot be empty or exceed 50 characters.");
        }
    }
}

