using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Estates.Application.DTO.Management.Complaints
{
	public record ComplaintReadDto
	{
        [StringLength(20)]
        public string? ComplaintNumber { get; set; }

        public string? NatureOfComplaint { get; set; }

        [StringLength(50)]
        public string? PropertyNumber { get; set; }

        public DateTime ComplaintDate { get; set; }

        public string? ComplaintStatus { get; set; }
    }


    public record ComplaintStaffReadDto
    (
         string? ComplaintNumber,

         string? NatureOfComplaint,

         string? PropertyNumber,

         DateTime ComplaintDate,

         string? ComplaintStatus,

         string? CustomerName
    );

}

