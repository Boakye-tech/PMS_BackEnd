// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


using System.ComponentModel.DataAnnotations;

namespace Modules.Common.Domain.Base;

public abstract class AuditableEntity
{
    public DateTime CreatedOn { get; set; } = DateTime.Parse("1900-01-01");

    [StringLength(50)]
    public string? CreatedBy { get; set; }

    public DateTime ModifiedOn { get; set; } = DateTime.Parse("1900-01-01");

    [StringLength(50)]
    public string? ModifiedBy { get; set; }

    public DateTime DeletedOn { get; set; } = DateTime.Parse("1900-01-01");

    [StringLength(50)]
    public string? DeletedBy { get; set; }

}

