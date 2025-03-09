using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Application.Dtos.Entities.Permissions
{
	public record ApplicationModulesDto
	{
        [StringLength(12)]
        public string? ModuleId { get; set; }

        [StringLength(20)]
        public string? ModuleName { get; set; }
    }


    public record ApplicationModulesCreateDto
    {
        [StringLength(20)]
        public string? ModuleName { get; set; }
    }
}

