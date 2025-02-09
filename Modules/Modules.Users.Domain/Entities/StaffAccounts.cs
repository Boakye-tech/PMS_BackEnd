using System;

using Microsoft.EntityFrameworkCore;

namespace Modules.Users.Domain.Entities
{
    [Keyless]
	public class StaffAccounts
	{
        //[Key]
        public string? Id { get; set; }
        public string? IdentificationNumber { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? DepartmentName { get; set; }
        public string? UnitName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? RoleName { get; set; }
        public int Status { get; set; }
    }



}

