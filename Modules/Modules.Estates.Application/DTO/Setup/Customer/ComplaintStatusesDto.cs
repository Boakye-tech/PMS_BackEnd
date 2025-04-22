using System;
namespace Modules.Estates.Application.DTO.Setup.Customer
{
    public record ComplaintStatusesReadDto(int complaintStatusId, string complaintStatus, string description);
    public record ComplaintStatusesCreateDto(int complaintStatusId, string complaintStatus, string description, string createdBy);
    public record ComplaintStatusesUpdateDto(int complaintStatusId, string complaintStatus, string description, string modifiedBy);
    public record ComplaintStatusesDeleteDto(int complaintStatusId);
}

