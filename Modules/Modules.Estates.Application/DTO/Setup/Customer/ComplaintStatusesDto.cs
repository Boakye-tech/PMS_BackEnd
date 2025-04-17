using System;
namespace Modules.Estates.Application.DTO.Setup.Customer
{
    public record ComplaintStatusesReadDto(int complaintStatusId, string complaintStatus);
    public record ComplaintStatusesCreateDto(int complaintStatusId, string complaintStatus, string createdBy);
    public record ComplaintStatusesUpdateDto(int complaintStatusId, string complaintStatus, string modifiedBy);
    public record ComplaintStatusesDeleteDto(int complaintStatusId);
}

