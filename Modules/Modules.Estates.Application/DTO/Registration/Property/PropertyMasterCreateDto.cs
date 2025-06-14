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

    public record PropertyMasterCreatePlotDto
    {
        [Key]
        public int PropertyMasterId { get; set; }

        public required int LandUseId { get; set; }

        public required int LandUseTypeId { get; set; }

        public required int PropertyTypeId { get; set; }

        public int LocalityId { get; set; }

        public int SiteId { get; set; }

        public required int AllocationTypeId { get; set; }

        [StringLength(3)]
        public string? BlockNumber { get; set; }

        public int NumberFrom { get; set; }

        public int NumberTo { get; set; }

        public int PlotDimensionId { get; set; }

        public double AcreageOne { get; set; }

        public double AcreageTwo { get; set; }

        [StringLength(3)]
        public string? BlockUnit { get; set; }

        public int PropertyHeightId { get; set; }

        public int ShopOfficeNumberFrom { get; set; }

        public int ShopOfficeNumberTo { get; set; }

        [StringLength(30)]
        public string? SitePlanNumber { get; set; }

        public bool IsLargScale { get; set; }

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

        [StringLength(50)]
        public required string CreatedBy { get; set; }
    }
}

