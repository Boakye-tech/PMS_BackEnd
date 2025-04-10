using System;
namespace Modules.Estates.Application.DTO.Setup.Customer
{
    public record ComplaintTypeDto(int complaintTypeId, string complaintTypes);


    public record ComplaintTypeReadDto(int complaintTypeId, string complaintTypes);
    public record ComplaintTypeCreateDto(int complaintTypeId, string complaintTypes, string createdBy);
    public record ComplaintTypeUpdateDto(int complaintTypeId, string complaintTypes, string modifiedBy);
    public record ComplaintTypeDeleteDto(int complaintTypeId, string deletedBy);

}

