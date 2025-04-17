using System;
namespace Modules.Customers.Application.Dtos.Complaints;

public record ComplaintTypeDto(int complaintTypeId, string complaintTypes,int departmentId, int departmentUnitId);

