// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Users.Application.Dtos.Entities
{
	public record DepartmentReadDto(int DepartmentId, string DepartmentName);
    public record DepartmentCreateDto(int DepartmentId, string DepartmentName, string CreatedBy);
    public record DepartmentUpdateDto(int DepartmentId, string DepartmentName, string ModifiedBy);
    public record DepartmentDeleteDto(int DepartmentId);

}

