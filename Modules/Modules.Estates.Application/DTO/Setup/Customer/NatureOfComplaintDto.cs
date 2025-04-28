// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.DTO.Setup.Customer
{
    public record NatureOfComplaintDto(int complaintTypeId, int natureOfComplaintId, string natureOfComplaints);


    public record NatureOfComplaintReadDto(int complaintTypeId, int natureOfComplaintId, string natureOfComplaints);
    public record NatureOfComplaintCreateDto(int complaintTypeId, int natureOfComplaintId, string natureOfComplaints, string createdBy);
    public record NatureOfComplaintUpdateDto(int complaintTypeId, int natureOfComplaintId, string natureOfComplaints, string modifiedBy);
    public record NatureOfComplaintDeleteDto(int complaintTypeId, string deletedBy);
}

