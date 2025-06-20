// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Http;

namespace Modules.Finance.Application.UseCases
{
    public class InvoiceTypesService : IInvoiceTypesService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public InvoiceTypesService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<InvoiceTypesReadDto>> GetInvoiceTypesAsync()
        {
            var types = await _unitOfWork.InvoiceTypes.GetAll();
            return _mapper.Map<IEnumerable<InvoiceTypesReadDto>>(types);
        }

        public async Task<InvoiceTypesReadDto> GetInvoiceTypesAsync(int value)
        {
            var type = await _unitOfWork.InvoiceTypes.Get(value);
            return _mapper.Map<InvoiceTypesReadDto>(type);
        }

        public async Task<InvoiceTypesReadDto> GetInvoiceTypesAsync(string value)
        {
            var type = await _unitOfWork.InvoiceTypes.Get(p => p.InvoiceInitials == value);
            return _mapper.Map<InvoiceTypesReadDto>(type);
        }

        public async Task<ReturnResponsesDto> CreateInvoiceTypesAsync(InvoiceTypesCreateDto values)
        {
            try
            {
                var existingType = await _unitOfWork.InvoiceTypes.Get(p => p.InvoiceInitials == values.InvoiceInitials);
                if (existingType != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Invoice type already exists." },
                        SuccessResponse = null
                    };
                }

                var type = new InvoiceTypes(values.InvoiceTypesId, values.InvoiceInitials!, values.InvoiceDescriptions!, values.InvoiceAmount)
                {
                    CreatedBy = values.CreatedBy,
                    CreatedOn = DateTime.Now
                };

                _unitOfWork.InvoiceTypes.Insert(type);
                await _unitOfWork.Complete();

                var result = _mapper.Map<InvoiceTypesReadDto>(type);

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Invoice type created successfully.", Data = result }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.Message },
                    SuccessResponse = null
                };
            }
        }

        public async Task<ReturnResponsesDto> UpdateInvoiceTypesAsync(InvoiceTypesUpdateDto values)
        {
            try
            {
                var type = await _unitOfWork.InvoiceTypes.Get(values.InvoiceTypesId);
                if (type == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = "Invoice type not found." },
                        SuccessResponse = null
                    };
                }

                var existingType = await _unitOfWork.InvoiceTypes.Get(p => p.InvoiceInitials == values.InvoiceInitials && p.InvoiceTypesId != values.InvoiceTypesId);
                if (existingType != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Invoice type already exists." },
                        SuccessResponse = null
                    };
                }

                type.Update(values.InvoiceTypesId, values.InvoiceInitials!, values.InvoiceDescriptions!, values.InvoiceAmount);
                type.ModifiedBy = values.ModifiedBy;
                type.ModifiedOn = DateTime.Now;

                _unitOfWork.InvoiceTypes.Update(type);
                await _unitOfWork.Complete();

                var result = _mapper.Map<InvoiceTypesReadDto>(type);

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Invoice type updated successfully.", Data = result }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.Message },
                    SuccessResponse = null
                };
            }
        }

        public async Task<ReturnResponsesDto> DeleteInvoiceTypesAsync(int invoiceTypesId)
        {
            try
            {
                var type = await _unitOfWork.InvoiceTypes.Get(invoiceTypesId);
                if (type == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = "Invoice type not found." },
                        SuccessResponse = null
                    };
                }

                _unitOfWork.InvoiceTypes.Delete(type);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Invoice type deleted successfully.", Data = null }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.Message },
                    SuccessResponse = null
                };
            }
        }
    }
}

