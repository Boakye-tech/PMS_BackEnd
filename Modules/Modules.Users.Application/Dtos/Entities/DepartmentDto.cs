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
	public record DepartmentReadDto(int DepartmentId, string DepartmentInitial, string DepartmentName);
    public record DepartmentUpdateDto(int DepartmentId, string DepartmentInitial, string DepartmentName, string ModifiedBy);
    public record DepartmentDeleteDto(int DepartmentId);

    public record DepartmentCreateDto
    {
        public int DepartmentId { get; set; }
        public string? DepartmentInitial { get; set; }
        public string? DepartmentName { get; set; }
        public string? CreatedBy { get; set; }
    }

}

