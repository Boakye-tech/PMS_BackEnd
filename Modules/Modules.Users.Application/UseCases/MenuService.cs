using System;
using System.Data;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Modules.Users.Application.Dtos.Entities.Menu;
using Modules.Users.Application.Validations;
using Modules.Users.Domain.Entities.Menu;

namespace Modules.Users.Application.UseCases
{
	public class MenuService : IMenuService
    {
        readonly IUnitOfWork _unitOfWork;
        readonly IMapper _mapper;

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

        public Task<IEnumerable<MenusWithActionsDto>> GetMenuActions()
        {
            throw new NotImplementedException();
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

