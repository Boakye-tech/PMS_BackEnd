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
    public class ChartOfAccountsService : IChartOfAccountsService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ChartOfAccountsService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ChartOfAccountsReadDto>> GetChartOfAccountsAsync()
        {
            var accounts = await _unitOfWork.ChartOfAccounts.GetAll();
            return _mapper.Map<IEnumerable<ChartOfAccountsReadDto>>(accounts);
        }

        public async Task<ChartOfAccountsReadDto> GetChartOfAccountsAsync(int value)
        {
            var account = await _unitOfWork.ChartOfAccounts.Get(value);
            return _mapper.Map<ChartOfAccountsReadDto>(account);
        }

        public async Task<ChartOfAccountsReadDto> GetChartOfAccountsAsync(string value)
        {
            var account = await _unitOfWork.ChartOfAccounts.Get(p => p.AccountName == value);
            return _mapper.Map<ChartOfAccountsReadDto>(account);
        }

        public async Task<ReturnResponsesDto> CreateChartOfAccountsAsync(ChartOfAccountsCreateDto values)
        {
            try
            {
                var existingAccount = await _unitOfWork.ChartOfAccounts.Get(p => p.AccountName == values.AccountName);
                if (existingAccount != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Chart of account already exists." },
                        SuccessResponse = null
                    };
                }

                var account = new ChartOfAccounts(values.AccountCode, values.AccountName!)
                {
                    CreatedBy = values.CreatedBy,
                    CreatedOn = DateTime.Now
                };

                _unitOfWork.ChartOfAccounts.Insert(account);
                await _unitOfWork.Complete();

                var result = _mapper.Map<ChartOfAccountsReadDto>(account);

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Chart of account created successfully.", Data = result }
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

        public async Task<ReturnResponsesDto> UpdateChartOfAccountsAsync(ChartOfAccountsUpdateDto values)
        {
            try
            {
                var account = await _unitOfWork.ChartOfAccounts.Get(values.AccountCode);
                if (account == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = "Chart of account not found." },
                        SuccessResponse = null
                    };
                }

                var existingAccount = await _unitOfWork.ChartOfAccounts.Get(p => p.AccountName == values.AccountName && p.AccountCode != values.AccountCode);
                if (existingAccount != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Chart of account already exists." },
                        SuccessResponse = null
                    };
                }

                account.Update(values.AccountCode, values.AccountName!);
                account.ModifiedBy = values.ModifiedBy;
                account.ModifiedOn = DateTime.Now;

                _unitOfWork.ChartOfAccounts.Update(account);
                await _unitOfWork.Complete();

                var result = _mapper.Map<ChartOfAccountsReadDto>(account);

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Chart of account updated successfully.", Data = result }
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

        public async Task<ReturnResponsesDto> DeleteChartOfAccountsAsync(int accountCode)
        {
            try
            {
                var account = await _unitOfWork.ChartOfAccounts.Get(accountCode);
                if (account == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = "Chart of account not found." },
                        SuccessResponse = null
                    };
                }

                _unitOfWork.ChartOfAccounts.Delete(account);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Chart of account deleted successfully.", Data = null }
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

