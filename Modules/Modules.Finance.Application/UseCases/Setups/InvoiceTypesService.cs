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
using Modules.Finance.Domain.Entities.Setup;

namespace Modules.Finance.Application.UseCases.Setups
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
            var types = await _unitOfWork.InvoiceTypes.GetAll( includes: new List<string> { "Services"});
            return _mapper.Map<IEnumerable<InvoiceTypesReadDto>>(types);
        }

        public async Task<InvoiceTypesReadDto> GetInvoiceTypesAsync(int value)
        {
            var type = await _unitOfWork.InvoiceTypes.Get(value);
            return _mapper.Map<InvoiceTypesReadDto>(type);
        }



        public async Task<ReturnResponsesDto> CreateInvoiceTypesAsync(InvoiceTypesCreateDto values)
        {
            try
            {
                var existingType = await _unitOfWork.InvoiceTypes.Get(p => p.InvoiceName == values.InvoiceName);
                if (existingType != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Invoice type already exists." },
                    };
                }

                var invoicetype = new InvoiceTypes(values.InvoiceName!, values.InvoiceDescriptions!, values.DepartmentId, values.DepartmentUnitId,values.RoomNumber, values.PaymentTermsId)
                {
                    CreatedBy = values.CreatedBy,
                    CreatedOn = DateTime.Now
                };

                //load the services
                invoicetype.Services.Clear();
                var services = (await _unitOfWork.Services.GetAll()).Where(s => values.ServicesId.Contains(s.ServicesId)).ToList();

                foreach (var service in services)
                {
                    if(!invoicetype.Services.Any(s => s.ServicesId == service.ServicesId))
                    {
                        invoicetype.Services.Add(service);
                    }
                }

                _unitOfWork.InvoiceTypes.Insert(invoicetype);
                await _unitOfWork.Complete();

                //var result = _mapper.Map<InvoiceTypesReadDto>(type);

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Invoice type created successfully." }
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

                //var existingType = await _unitOfWork.InvoiceTypes.Get(p => p.InvoiceName == values.InvoiceName && p.InvoiceTypesId != values.InvoiceTypesId);
                //if (existingType != null)
                //{
                //    return new ReturnResponsesDto
                //    {
                //        IsSuccess = false,
                //        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Invoice type already exists." },
                //        SuccessResponse = null
                //    };
                //}

                type.Update(values.InvoiceTypesId, values.InvoiceName!, values.InvoiceDescriptions!, values.DepartmentId, values.DepartmentUnitId, values.RoomNumber, values.PaymentTermsId);
                type.ModifiedBy = values.ModifiedBy;
                type.ModifiedOn = DateTime.Now;

                //load the services
                type.Services.Clear();
                var services = (await _unitOfWork.Services.GetAll()).Where(s => values.ServicesId.Contains(s.ServicesId)).ToList();

                foreach (var service in services)
                {
                    if (!type.Services.Any(s => s.ServicesId == service.ServicesId))
                    {
                        type.Services.Add(service);
                    }
                }

                _unitOfWork.InvoiceTypes.Update(type);
                await _unitOfWork.Complete();

                //var result = _mapper.Map<InvoiceTypesReadDto>(type);

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Invoice type updated successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.Message },
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
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Invoice type deleted successfully." }
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

