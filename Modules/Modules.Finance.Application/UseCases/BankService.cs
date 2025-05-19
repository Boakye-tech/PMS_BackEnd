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
    public class BankService : IBankService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public BankService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<BankReadDto>> GetBankAsync()
        {
            var banks = await _unitOfWork.Bank.GetAll();
            return _mapper.Map<IEnumerable<BankReadDto>>(banks);
        }

        public async Task<BankReadDto> GetBankAsync(string value)
        {
            var bank = await _unitOfWork.Bank.Get(b => b.BankId == value);
            return _mapper.Map<BankReadDto>(bank);
        }

        public async Task<ReturnResponsesDto> CreateBankAsync(BankCreateDto values)
        {
            try
            {
                var existingBank = await _unitOfWork.Bank.Get(b => b.BankId == values.BankId);
                if (existingBank != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Bank already exists." },
                        SuccessResponse = null
                    };
                }

                var bank = new Bank(values.BankId, values.BankName!)
                {
                    CreatedBy = values.CreatedBy,
                    CreatedOn = DateTime.Now
                };

                _unitOfWork.Bank.Insert(bank);
                await _unitOfWork.Complete();

                var result = _mapper.Map<BankReadDto>(bank);

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Bank created successfully.", Data = result }
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

        public async Task<ReturnResponsesDto> UpdateBankAsync(BankUpdateDto values)
        {
            try
            {
                var bank = await _unitOfWork.Bank.Get(b => b.BankId == values.BankId);
                if (bank == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = "Bank not found." },
                        SuccessResponse = null
                    };
                }

                var existingBank = await _unitOfWork.Bank.Get(b => b.BankName == values.BankName && b.BankId != values.BankId);
                if (existingBank != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Bank already exists." },
                        SuccessResponse = null
                    };
                }

                bank.Update(values.BankId, values.BankName!);
                bank.ModifiedBy = values.ModifiedBy;
                bank.ModifiedOn = DateTime.Now;

                _unitOfWork.Bank.Update(bank);
                await _unitOfWork.Complete();

                var result = _mapper.Map<BankReadDto>(bank);

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Bank updated successfully.", Data = result }
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

        public async Task<ReturnResponsesDto> DeleteBankAsync(string bankId)
        {
            try
            {
                var bank = await _unitOfWork.Bank.Get(b => b.BankId == bankId);
                if (bank == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = "Bank not found." },
                        SuccessResponse = null
                    };
                }

                _unitOfWork.Bank.Delete(bank);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Bank deleted successfully.", Data = null }
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