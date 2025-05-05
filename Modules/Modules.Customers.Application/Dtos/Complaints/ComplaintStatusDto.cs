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
    public record ComplaintStatusesReadDto(int complaintStatusId, string complaintStatus, string description);
    public record ComplaintStatusesCreateDto(int complaintStatusId, string complaintStatus, string description, string createdBy);
    public record ComplaintStatusesUpdateDto(int complaintStatusId, string complaintStatus, string description, string modifiedBy);
    public record ComplaintStatusesDeleteDto(int complaintStatusId);

}

