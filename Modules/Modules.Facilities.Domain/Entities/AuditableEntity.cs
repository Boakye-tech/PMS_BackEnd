// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Domain/Entities/AuditableEntity.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 30/06/2025 8:52 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Facilities.Domain.Entities
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


    public class BaseEntity : AuditableEntity
    {
        public DateTime ApprovedOn { get; set; }
        public string? ApprovedBy { get; set; }
    }

}

