using System;
namespace Modules.Estates.Application.DTO.Setup.Customer
{
    public record NatureOfComplaintDto(int complaintTypeId, int natureOfComplaintId, string natureOfComplaints);


    public record NatureOfComplaintReadDto(int complaintTypeId, int natureOfComplaintId, string natureOfComplaints);
    public record NatureOfComplaintCreateDto(int complaintTypeId, int natureOfComplaintId, string natureOfComplaints, string createdBy);
    public record NatureOfComplaintUpdateDto(int complaintTypeId, int natureOfComplaintId, string natureOfComplaints, string modifiedBy);
    public record NatureOfComplaintDeleteDto(int complaintTypeId, string deletedBy);
}

