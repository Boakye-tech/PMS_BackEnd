using System;
using System.Data;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Modules.Users.Application.Dtos.Administration;
using Modules.Users.Application.Dtos.Entities.Menu;
using Modules.Users.Application.Validations;
using Modules.Users.Domain.Entities.Menu;

namespace Modules.Users.Application.UseCases
{
	public class MenuService : IMenuService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IMapper _mapper;

        readonly UserManager<ApplicationIdentityUser> _userManager;

        private readonly ValidationService _validationService;


        public MenuService(IUnitOfWork unitOfWork, IMapper mapper, ValidationService validationService)
		{
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _validationService = validationService;
        }

        public void AssignMenuActionsToRole()
        {
            throw new NotImplementedException();
        }

        public async void AssignUserRole(AssignUserRoleDto assignUserRole)
        {
            //throw new NotImplementedException();
            var resultUser = _userManager.FindByEmailAsync(assignUserRole.EmailAddress).Result;
            if (resultUser != null)
            {
                var resultRole = await _userManager.AddToRoleAsync(resultUser, assignUserRole.RoleName);

                if (resultRole.Succeeded)
                    return Ok(new { Status = resultRole.ToString() });
                else
                    return BadRequest(new { Status = resultRole.Errors });
            }
        }

        public async Task<MenusDto> CreateMenu(MenusDto menus)
        {
            var validationResult = _validationService.Validate(menus);

            if (validationResult.IsValid)
            {
                Menus menu = new(menus.menuId, menus.menuName, menus.description);
                _unitOfWork.Menus.Insert(menu);
                await _unitOfWork.Complete();

                return new MenusDto(menu.MenuId, menus.menuName, menu.Description);
            }

            return new MenusDto(StatusCodes.Status400BadRequest, "BadRequest", "404-BadRequest");
        }

        public async Task<SubMenusDto> CreateSubMenu(SubMenusCreateDto subMenus)
        {
            //throw new NotImplementedException();
            var validationResult = _validationService.Validate(subMenus);

            if (validationResult.IsValid)
            {
                SubMenus _subMenu = new(subMenus.menuId, subMenus.subMenuId, subMenus.subMenuName, subMenus.description);
                _unitOfWork.SubMenus.Insert(_subMenu);
                await _unitOfWork.Complete();

                return new SubMenusDto(_subMenu.MenuId, _subMenu.SubMenuId, _subMenu.SubMenuName, _subMenu.Description);
            }

            return new SubMenusDto(StatusCodes.Status400BadRequest, StatusCodes.Status400BadRequest, "BadRequest", "404-BadRequest");
        }

        public void DeleteMenu(MenusDeleteDto menuid)
        {
            throw new NotImplementedException();
        }

        public void DeleteSubMenu(SubMenuDeleteDto subMenuId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<MenuActionsDto>> GetActions()
        {
            var response = await _unitOfWork.MenuActions.GetAll();
            return _mapper.Map<IEnumerable<MenuActionsDto>>(response);
        }

        public async Task<IEnumerable<MenusWithActionsDto>> GetMenuActions()
        {
            //throw new NotImplementedException();
            var _actions = await _unitOfWork.MenuActions!.GetAll();

            var result =
                (from menu in await _unitOfWork.Menus.GetAll()
                 join submenu in await _unitOfWork.SubMenus.GetAll()
                 on menu.MenuId equals submenu.MenuId into submenuGroup
                 from submenu in submenuGroup.DefaultIfEmpty() // LEFT JOIN
                 from action in _actions  // CROSS JOIN
                 group new { menu, submenu, action }
                 by new { menu.MenuName, SubmenuName = submenu != null ? submenu.SubMenuName : null } into grouped
                 select new MenusWithActionsDto
                 (0,
                  grouped.Key.MenuName,
                  grouped.Key.SubmenuName,
                  grouped.Any(g => g.action.ActionName == "No Access") ? "" : null!,
                  grouped.Any(g => g.action.ActionName == "Create") ? "" : null!,
                  grouped.Any(g => g.action.ActionName == "Read") ? "" : null!,
                  grouped.Any(g => g.action.ActionName == "Update") ? "" : null!,
                  grouped.Any(g => g.action.ActionName == "Delete") ? "" : null!,
                  grouped.Any(g => g.action.ActionName == "Approve") ? "" : null!
                 )).ToList();
            //select new MenusWithActionsDto
            //{
            //    MenuId = 0,
            //    MenuName = grouped.Key.MenuName,
            //    SubmenuName = grouped.Key.SubmenuName,
            //    NoAccess = grouped.Any(g => g.action.ActionName == "No Access") ? "" : null,
            //    Create = grouped.Any(g => g.action.ActionName == "Create") ? "" : null,
            //    Read = grouped.Any(g => g.action.ActionName == "Read") ? "" : null,
            //    Update = grouped.Any(g => g.action.ActionName == "Update") ? "" : null,
            //    Delete = grouped.Any(g => g.action.ActionName == "Delete") ? "" : null,
            //    Approve = grouped.Any(g => g.action.ActionName == "Approve") ? "" : null
            //}).ToList();

            return result!;
        }

        public async Task<IEnumerable<MenusDto>> GetMenus()
        {
            var response = await _unitOfWork.Menus.GetAll();
            return _mapper.Map<IEnumerable<MenusDto>>(response);
        }

        public void GetRolesMenusActions()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<SubMenusDto>> GetSubMenus()
        {
            //throw new NotImplementedException();
            var response = await _unitOfWork.SubMenus.GetAll();
            return _mapper.Map<IEnumerable<SubMenusDto>>(response);
        }

        public Task<MenusDto> UpdateMenu(MenusDto updateMenus)
        {
            throw new NotImplementedException();
        }

        public Task<SubMenusDto> UpdateSubMenu(SubMenusUpdateDto updateSubMenus)
        {
            throw new NotImplementedException();
        }
    }
}

