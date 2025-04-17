using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Customers.Application.Dtos.Complaints
{
    public record ComplaintReadDto
    (
         string? ComplaintNumber,

         List<string>? NatureOfComplaint,

         string? PropertyNumber,

         DateTime ComplaintDate,

         string? ComplaintStatus

    );
}

