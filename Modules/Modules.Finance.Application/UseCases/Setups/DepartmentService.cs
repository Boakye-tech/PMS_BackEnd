// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/UseCases/DepartmentService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 07/07/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Http;

namespace Modules.Finance.Application.UseCases.Setups
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DepartmentService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<DepartmentReadDto>> GetDepartmentAsync()
        {
            var departments = await _unitOfWork.Department.GetAll();
            return _mapper.Map<IEnumerable<DepartmentReadDto>>(departments);
        }

        public async Task<ReturnResponsesDto> CreateDepartmentAsync(DepartmentCreateDto values)
        {
            try
            {
                var existingDepartment = await _unitOfWork.Department.Get(d => d.DepartmentName == values.DepartmentName);
                if (existingDepartment != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Department name already exists." },
                    };
                }

                var department = Department.Create(values.DepartmentId, values.DepartmentInitial, values.DepartmentName!);
                department.CreatedBy = values.CreatedBy;
                department.CreatedOn = DateTime.Now;

                _unitOfWork.Department.Insert(department);
                await _unitOfWork.Complete();

                //var result = _mapper.Map<DepartmentReadDto>(department);

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Department created successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message },
                };
            }
        }

        public async Task<ReturnResponsesDto> UpdateDepartmentAsync(DepartmentUpdateDto values)
        {
            try
            {
                var department = await _unitOfWork.Department.Get(values.DepartmentId);
                if (department == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Department with ID {values.DepartmentId} not found." },
                    };
                }

                var existingDepartment = await _unitOfWork.Department.Get(d => d.DepartmentName == values.DepartmentName && d.DepartmentId != values.DepartmentId);
                if (existingDepartment != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Department name already exists." },
                    };
                }

                department.Update(values.DepartmentId,values.DepartmentInitial, values.DepartmentName!);
                department.ModifiedBy = values.ModifiedBy;
                department.ModifiedOn = DateTime.Now;

                _unitOfWork.Department.Update(department);
                await _unitOfWork.Complete();

                //var result = _mapper.Map<DepartmentReadDto>(department);

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Department updated successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message },
                };
            }
        }

        public async Task<ReturnResponsesDto> DeleteDepartmentAsync(int departmentId)
        {
            try
            {
                var department = await _unitOfWork.Department.Get(departmentId);
                if (department == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Department with ID {departmentId} not found." },
                    };
                }

                _unitOfWork.Department.Delete(department);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Department with ID {departmentId} deleted successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException!.Message ?? ex.Message },
                };
            }
        }
    }
}