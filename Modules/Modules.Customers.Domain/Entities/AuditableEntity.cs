using System;
namespace Modules.Customers.Domain.Entities
{
    public class AuditableEntity
    {
        public DateTime CreatedOn { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime DeletedOn { get; set; }
        public string? DeletedBy { get; set; }
    }
}

