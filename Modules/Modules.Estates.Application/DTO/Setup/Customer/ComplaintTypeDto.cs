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
    public record ComplaintTypeDto(int complaintTypeId, string complaintTypes, int departmentId, int departmentUnitId);


    public record ComplaintTypeReadDto(int complaintTypeId, string complaintTypes, int departmentId, int departmentUnitId);
    public record ComplaintTypeCreateDto(int complaintTypeId, string complaintTypes, int departmentId, int departmentUnitId, string createdBy);
    public record ComplaintTypeUpdateDto(int complaintTypeId, string complaintTypes, int departmentId, int departmentUnitId, string modifiedBy);
    public record ComplaintTypeDeleteDto(int complaintTypeId, string deletedBy);

}

