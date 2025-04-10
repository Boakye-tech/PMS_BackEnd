using System;
namespace Modules.Customers.Application.Dtos.Complaints;

public record NatureOfComplaintDto(int complaintTypeId, int natureOfComplaintId, string natureOfComplaints);


