// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Facilities.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Facilities.Application/UseCases/Setup/SuppliersService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/07/2025 10:45 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Facilities.Application.UseCases.Setup
{
    public class SuppliersService : ISuppliersService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public SuppliersService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<ReturnResponsesDto> CreateSuppliersAsync(SuppliersCreateDto values)
        {
            try
            {
                var existing = await _unitOfWork.Suppliers.Get(c => c.SupplierName == values.supplierName);
                if (existing != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status400BadRequest, StatusMessage = "Supplier already exists." },
                        SuccessResponse = null
                    };
                }
                var supplier = Suppliers.Create(
                    0,
                    values.supplierName,
                    values.phoneNumber,
                    values.emailAddress,
                    values.companyRegistrationNumber,
                    values.tinNumber,
                    values.companyAddress,
                    values.digitalAddress,
                    values.images,
                    values.contactPerson_FirstName,
                    values.contactPerson_MiddleName,
                    values.contactPerson_LastName,
                    values.contactPerson_JobTitle,
                    values.contactPerson_PhoneNumber,
                    values.contactPerson_EmailAddress
                );
                supplier.CreatedBy = values.createdBy;
                supplier.CreatedOn = DateTime.Now;
                _unitOfWork.Suppliers.Insert(supplier);
                await _unitOfWork.Complete();
                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new BaseResponseDto { StatusCode = StatusCodes.Status201Created, StatusMessage = "Supplier created successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status500InternalServerError, StatusMessage = ex.Message },
                    SuccessResponse = null
                };
            }
        }

        public async Task<ReturnResponsesDto> UpdateSuppliersAsync(SuppliersUpdateDto values)
        {
            try
            {
                var supplier = await _unitOfWork.Suppliers.Get(values.supplierID);
                if (supplier is null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status404NotFound, StatusMessage = $"Supplier with ID {values.supplierID} not found." },
                        SuccessResponse = null
                    };
                }
                supplier.Update(
                    values.supplierID,
                    values.supplierName,
                    values.phoneNumber,
                    values.emailAddress,
                    values.companyRegistrationNumber,
                    values.tinNumber,
                    values.companyAddress,
                    values.digitalAddress,
                    values.images,
                    values.contactPerson_FirstName,
                    values.contactPerson_MiddleName,
                    values.contactPerson_LastName,
                    values.contactPerson_JobTitle,
                    values.contactPerson_PhoneNumber,
                    values.contactPerson_EmailAddress
                );
                supplier.ModifiedBy = values.modifiedBy;
                supplier.ModifiedOn = DateTime.Now;
                _unitOfWork.Suppliers.Update(supplier);
                await _unitOfWork.Complete();
                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new BaseResponseDto { StatusCode = StatusCodes.Status200OK, StatusMessage = "Supplier updated successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status500InternalServerError, StatusMessage = ex.Message },
                    SuccessResponse = null
                };
            }
        }

        public async Task<IEnumerable<SuppliersReadDto>> GetSuppliersAsync()
        {
            var suppliers = await _unitOfWork.Suppliers.GetAll();
            return _mapper.Map<IEnumerable<SuppliersReadDto>>(suppliers);
        }

        public async Task<ReturnResponsesDto> DeleteSuppliersAsync(int supplierId)
        {
            try
            {
                var supplier = await _unitOfWork.Suppliers.Get(supplierId);
                if (supplier == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status404NotFound, StatusMessage = $"Supplier with ID {supplierId} not found." },
                        SuccessResponse = null
                    };
                }
                _unitOfWork.Suppliers.Delete(supplier);
                await _unitOfWork.Complete();
                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new BaseResponseDto { StatusCode = StatusCodes.Status200OK, StatusMessage = $"Supplier with ID {supplierId} deleted successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new BaseResponseDto { StatusCode = StatusCodes.Status500InternalServerError, StatusMessage = ex.Message },
                    SuccessResponse = null
                };
            }
        }
    }
}