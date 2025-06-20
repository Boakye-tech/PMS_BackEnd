// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using System.ComponentModel.DataAnnotations;

namespace Modules.Estates.Application.DTO.Registration.Property
{

    public record PropertyMasterCreatePlotResponseDto
    {
        [Key]
        [StringLength(50)]
        public string? PropertyNumber { get; set; }

        public string? PropertyType { get; set; }

        public string? Locality { get; set; }

        public string? LandUse { get; set; }

        public string? LandUseType { get; set; }

        public string? AllocationType { get; set; }

        [StringLength(3)]
        public string? BlockNumber { get; set; }

        [StringLength(3)]
        public string? PlotNumber { get; set; }

        public double AcreageOne { get; set; }

        public double AcreageTwo { get; set; }

        public string? PropertyHeight { get; set; }

        public string? PlotSize { get; set; }

        [StringLength(30)]
        public string? SitePlanNumber { get; set; }

        [StringLength(50)]
        public string? CoordinateOne { get; set; }
        [StringLength(50)]
        public string? CoordinateTwo { get; set; }
        [StringLength(50)]
        public string? CoordinateThree { get; set; }
        [StringLength(50)]
        public string? CoordinateFour { get; set; }
        [StringLength(50)]
        public string? CoordinateFive { get; set; }
        [StringLength(50)]
        public string? CoordinateSix { get; set; }


    }
}

