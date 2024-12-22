using System;
using System.ComponentModel.DataAnnotations;

namespace Modules.Users.Domain.Entities.Menu
{
	public class MenuActions
	{
		[Key]
		[Required]
		public int ActionId { get; set; }

		[Required]
		[StringLength(255)]
		public string ActionName { get; set; }

        [StringLength(255)]
        public string Description { get; set; }

        public MenuActions(int actionId, string actionName, string description)
		{
			ActionId = actionId;
			ActionName = actionName;
			Description = description;
		}

		public static MenuActions CreateMenuActions(int actionId, string actionName, string description)
		{
            if (string.IsNullOrWhiteSpace(actionName) || actionId < 0)
            {
                throw new ArgumentException("Invalid menu action data.");
            }

            return new MenuActions(actionId, actionName, description);
        }
	}
}

