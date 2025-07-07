// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/UseCases/DepartmentUnitService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 07/07/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Http;

namespace Modules.Finance.Application.UseCases
{
    public class DepartmentUnitService : IDepartmentUnitService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DepartmentUnitService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<DepartmentUnitReadDto>> GetDepartmentUnitAsync()
        {
            var departmentUnits = await _unitOfWork.DepartmentUnit.GetAll();
            return _mapper.Map<IEnumerable<DepartmentUnitReadDto>>(departmentUnits);
        }

        public async Task<IEnumerable<DepartmentUnitReadDto>> GetDepartmentUnitByDepartmentAsync(int departmentId)
        {
            var departmentUnits = await _unitOfWork.DepartmentUnit.GetAll(du => du.DepartmentId == departmentId);
            return _mapper.Map<IEnumerable<DepartmentUnitReadDto>>(departmentUnits);
        }

        public async Task<ReturnResponsesDto> CreateDepartmentUnitAsync(DepartmentUnitCreateDto values)
        {
            try
            {
                var existingDepartmentUnit = await _unitOfWork.DepartmentUnit.Get(du => du.UnitName == values.UnitName && du.DepartmentId == values.DepartmentId);
                if (existingDepartmentUnit != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Department unit name already exists for this department." },
                        SuccessResponse = null
                    };
                }

                var departmentUnit = DepartmentUnit.Create(values.DepartmentId, values.UnitId, values.UnitName!);
                departmentUnit.CreatedBy = values.CreatedBy;
                departmentUnit.CreatedOn = DateTime.Now;

                _unitOfWork.DepartmentUnit.Insert(departmentUnit);
                await _unitOfWork.Complete();

                var result = _mapper.Map<DepartmentUnitReadDto>(departmentUnit);

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Department unit created successfully.", Data = result }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message },
                    SuccessResponse = null
                };
            }
        }

        public async Task<ReturnResponsesDto> UpdateDepartmentUnitAsync(DepartmentUnitUpdateDto values)
        {
            try
            {
                var departmentUnit = await _unitOfWork.DepartmentUnit.Get(values.UnitId);
                if (departmentUnit == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Department unit with ID {values.UnitId} not found." },
                        SuccessResponse = null
                    };
                }

                var existingDepartmentUnit = await _unitOfWork.DepartmentUnit.Get(du => du.UnitName == values.UnitName && du.DepartmentId == values.DepartmentId && du.UnitId != values.UnitId);
                if (existingDepartmentUnit != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Department unit name already exists for this department." },
                        SuccessResponse = null
                    };
                }

                departmentUnit.Update(values.DepartmentId, values.UnitId, values.UnitName!);
                departmentUnit.ModifiedBy = values.ModifiedBy;
                departmentUnit.ModifiedOn = DateTime.Now;

                _unitOfWork.DepartmentUnit.Update(departmentUnit);
                await _unitOfWork.Complete();

                var result = _mapper.Map<DepartmentUnitReadDto>(departmentUnit);

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Department unit updated successfully.", Data = result }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message },
                    SuccessResponse = null
                };
            }
        }

        public async Task<ReturnResponsesDto> DeleteDepartmentUnitAsync(int unitId)
        {
            try
            {
                var departmentUnit = await _unitOfWork.DepartmentUnit.Get(unitId);
                if (departmentUnit == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Department unit with ID {unitId} not found." },
                        SuccessResponse = null
                    };
                }

                _unitOfWork.DepartmentUnit.Delete(departmentUnit);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Department unit with ID {unitId} deleted successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message },
                    SuccessResponse = null
                };
            }
        }
    }
}