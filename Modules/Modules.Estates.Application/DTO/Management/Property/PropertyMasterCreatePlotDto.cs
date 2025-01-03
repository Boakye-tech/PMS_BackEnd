using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Estates.Application.DTO.Management.Property
{

    public record PropertyMasterCreatePlotDto
    {
        [Key]
        public int PropertyMasterId { get; set; }

        public required int PropertyTypeId { get; set; }

        public int LocalityId { get; set; }

        [StringLength(3)]
        public required string LocalityInitial { get;  set; }

        public required int LandUseId { get; set; }

        [StringLength(3)]
        public required string LandUseInitial { get; set; }

        public required int LandUseTypeId { get; set; }

        [StringLength(3)]
        public required string LandUseTypeInitial { get; set; }

        public required int AllocationTypeId { get; set; }

        [StringLength(3)]
        public required string AllocationTypeInitial { get; set; }

        [StringLength(3)]
        public string? BlockNumber { get; set; }

        [StringLength(3)]
        public required string PlotNumber { get; set; }

        public double AcreageOne { get; set; }

        public double AcreageTwo { get; set; }

        public int PropertyHeightId { get; set; }

        public int PlotSizeId { get; set; }

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

        [StringLength(50)]
        public required string CreatedBy { get; set; }
    }
}

