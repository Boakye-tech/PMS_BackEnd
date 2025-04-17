using System;
namespace Modules.Estates.Application.DTO.Setup.Customer
{
    public record ComplaintTypeDto(int complaintTypeId, string complaintTypes, int departmentId, int departmentUnitId);


    public record ComplaintTypeReadDto(int complaintTypeId, string complaintTypes, int departmentId, int departmentUnitId);
    public record ComplaintTypeCreateDto(int complaintTypeId, string complaintTypes, int departmentId, int departmentUnitId, string createdBy);
    public record ComplaintTypeUpdateDto(int complaintTypeId, string complaintTypes, int departmentId, int departmentUnitId, string modifiedBy);
    public record ComplaintTypeDeleteDto(int complaintTypeId, string deletedBy);

}

