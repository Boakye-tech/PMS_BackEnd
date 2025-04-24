using System;
namespace Modules.Customers.Application.Dtos.Complaints
{
    public record ComplaintHistoryReadDto
    {

        public required string ComplaintStatus { get; set; }

        public required string ComplaintDescription { get; set; }

        public required DateTime ActionOn { get; set; }
    }
}

