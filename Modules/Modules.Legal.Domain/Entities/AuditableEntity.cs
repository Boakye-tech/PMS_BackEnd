// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Legal.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Legal.Domain/Entities/AuditableEntity.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 11/09/2025 11:45 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Legal.Domain.Entities
{

    public class AuditableEntity
    {
        public string? CreatedBy { get; set; }
        public DateTime DateCreated { get; set; }


        public string? ModifiedBy { get; set; }
        public DateTime DateModified { get; set; }


        public string? DeletedBy { get; set; }
        public DateTime DateDeleted { get; set; }

    }
}
