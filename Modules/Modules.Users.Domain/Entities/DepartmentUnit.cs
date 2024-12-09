using System;
namespace Modules.Users.Domain.Entities
{
	public class DepartmentUnit
    {
		public int DepartmentId { get; set; }
		public int UnitId { get; set; }
		public string? UnitName { get; set; }

		public DepartmentUnit()
		{
		}
	}
}

