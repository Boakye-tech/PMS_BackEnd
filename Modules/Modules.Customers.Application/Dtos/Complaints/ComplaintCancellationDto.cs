// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Customers.Application.Dtos.Complaints
{
    public record ComplaintCancellationDto
    {
        [Required]
        [StringLength(10)]
        public string? ComplaintNumber { get; set; }

        [StringLength(36)]
        public string? CancelledBy { get; set; }

        public string? CancelNotes { get; set; }

    }
}

