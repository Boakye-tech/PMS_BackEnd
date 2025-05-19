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
    public class BankSortCodesService : IBankSortCodesService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BankSortCodesService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BankSortCodesReadDto>> GetBankSortCodesAsync()
        {
            var codes = await _unitOfWork.BankSortCodes.GetAll();
            return _mapper.Map<IEnumerable<BankSortCodesReadDto>>(codes);
        }

        public async Task<BankSortCodesReadDto> GetBankSortCodesAsync(int value)
        {
            var code = await _unitOfWork.BankSortCodes.Get(value);
            return _mapper.Map<BankSortCodesReadDto>(code);
        }

        public async Task<BankSortCodesReadDto> GetBankSortCodesAsync(string value)
        {
            var code = await _unitOfWork.BankSortCodes.Get(p => p.SortCode == value);
            return _mapper.Map<BankSortCodesReadDto>(code);
        }

        public async Task<ReturnResponsesDto> CreateBankSortCodesAsync(BankSortCodesCreateDto values)
        {
            try
            {
                var existingCode = await _unitOfWork.BankSortCodes.Get(p => p.SortCode == values.SortCode);
                if (existingCode != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Bank sort code already exists." },
                        SuccessResponse = null
                    };
                }

                var code = new BankSortCodes(values.Id, values.SortCode!, values.BankName!, values.BranchName!)
                {
                    CreatedBy = values.CreatedBy,
                    CreatedOn = DateTime.Now
                };

                _unitOfWork.BankSortCodes.Insert(code);
                await _unitOfWork.Complete();

                var result = _mapper.Map<BankSortCodesReadDto>(code);

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Bank sort code created successfully.", Data = result }
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

        public async Task<ReturnResponsesDto> UpdateBankSortCodesAsync(BankSortCodesUpdateDto values)
        {
            try
            {
                var code = await _unitOfWork.BankSortCodes.Get(values.Id);
                if (code == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = "Bank sort code not found." },
                        SuccessResponse = null
                    };
                }

                var existingCode = await _unitOfWork.BankSortCodes.Get(p => p.SortCode == values.SortCode && p.BankSortCodesId != values.Id);
                if (existingCode != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Bank sort code already exists." },
                        SuccessResponse = null
                    };
                }

                code.Update(values.Id, values.SortCode!, values.BankName!, values.BranchName!);
                code.ModifiedBy = values.ModifiedBy;
                code.ModifiedOn = DateTime.Now;

                _unitOfWork.BankSortCodes.Update(code);
                await _unitOfWork.Complete();

                var result = _mapper.Map<BankSortCodesReadDto>(code);

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Bank sort code updated successfully.", Data = result }
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

        public async Task<ReturnResponsesDto> DeleteBankSortCodesAsync(int id)
        {
            try
            {
                var code = await _unitOfWork.BankSortCodes.Get(id);
                if (code == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = "Bank sort code not found." },
                        SuccessResponse = null
                    };
                }

                _unitOfWork.BankSortCodes.Delete(code);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Bank sort code deleted successfully.", Data = null }
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

