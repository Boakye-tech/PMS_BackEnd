using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Domain.Entities
{
	public class DepartmentUnit
    {
		public required int DepartmentId { get; set; }
		[Key]
        public required int UnitId { get; set; }
        public required string UnitName { get; set; }

		//public DepartmentUnit()
		//{
		//}
	}
}

