// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/UseCases/Setups/BankAccountNumbersService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 22/09/2025 11:50 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Linq.Expressions;

namespace Modules.Finance.Application.UseCases.Setups
{
    public class BankAccountNumbersService : IBankAccountNumbersService
    {
        private readonly IUnitOfWork _unitOfWork;
        //private readonly IMapper _mapper;

        public BankAccountNumbersService(IUnitOfWork unitOfWork) //, IMapper mapper
        {
            _unitOfWork = unitOfWork;
            //_mapper = mapper;
        }

        public async Task<IEnumerable<BankAccountNumbersReadDto>> GetBankAccountNumbersAsync()
        {
            var accounts = await _unitOfWork.BankAccountNumbers.GetAll(includes: new List<string> { "Bank", "Branch", "Currency" });

            return accounts.Select(account => new BankAccountNumbersReadDto(
                account.BankAccountNumbersId,
                account.AccountNumber!,
                account.BankId!,
                account.Bank?.BankName ?? string.Empty,
                account.BranchId!,
                account.Branch?.BranchName ?? string.Empty,
                account.CurrencyId,
                account.Currency?.CurrencyName ?? string.Empty,
                account.Description!
            ));
        }

        public async Task<ReturnResponsesDto> CreateBankAccountNumbersAsync(BankAccountNumbersCreateDto values)
        {
            try
            {
                // Check if account number already exists
                var existingAccount = await _unitOfWork.BankAccountNumbers.Get(a => a.AccountNumber == values.AccountNumber);
                if (existingAccount != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Account number already exists." },
                        SuccessResponse = null
                    };
                }

                // Validate bank exists
                var bank = await _unitOfWork.Bank.Get(b => b.BankId == values.BankId.ToString());
                if (bank == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Bank does not exist." },
                        SuccessResponse = null
                    };
                }

                // Validate branch exists and belongs to the bank
                var branch = await _unitOfWork.BankBranch.Get(bb => bb.BranchId == values.BranchId && bb.BankId == values.BankId.ToString());
                if (branch == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Branch does not exist or does not belong to the specified bank." },
                        SuccessResponse = null
                    };
                }

                // Validate currency exists
                var currency = await _unitOfWork.CurrencyExchangeRate.Get(c => c.CurrencyId == values.CurrencyId);
                if (currency == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Currency does not exist." },
                        SuccessResponse = null
                    };
                }

                var account = BankAccountNumbers.Create(values.AccountNumber, values.BankId, values.BranchId, values.CurrencyId, values.Description ?? string.Empty);
                account.CreatedBy = values.CreatedBy;
                account.CreatedOn = DateTime.Now;

                _unitOfWork.BankAccountNumbers.Insert(account);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Bank account number created successfully." }
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

        public async Task<ReturnResponsesDto> UpdateBankAccountNumbersAsync(BankAccountNumbersUpdateDto values)
        {
            try
            {
                var account = await _unitOfWork.BankAccountNumbers.Get(a => a.BankAccountNumbersId == values.BankAccountNumbersId);
                if (account == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = "Bank account number not found." },
                        SuccessResponse = null
                    };
                }

                // Check if account number is being changed and if new one already exists
                if (account.AccountNumber != values.AccountNumber)
                {
                    var existingAccount = await _unitOfWork.BankAccountNumbers.Get(a => a.AccountNumber == values.AccountNumber && a.BankAccountNumbersId != values.BankAccountNumbersId);
                    if (existingAccount != null)
                    {
                        return new ReturnResponsesDto
                        {
                            IsSuccess = false,
                            ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Account number already exists." },
                            SuccessResponse = null
                        };
                    }
                }

                // Validate bank exists
                var bank = await _unitOfWork.Bank.Get(b => b.BankId == values.BankId.ToString());
                if (bank == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Bank does not exist." },
                        SuccessResponse = null
                    };
                }

                // Validate branch exists and belongs to the bank
                var branch = await _unitOfWork.BankBranch.Get(bb => bb.BranchId == values.BranchId && bb.BankId == values.BankId.ToString());
                if (branch == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Branch does not exist or does not belong to the specified bank." },
                        SuccessResponse = null
                    };
                }

                // Validate currency exists
                var currency = await _unitOfWork.CurrencyExchangeRate.Get(c => c.CurrencyId == values.CurrencyId);
                if (currency == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Currency does not exist." },
                        SuccessResponse = null
                    };
                }

                account.Update(values.AccountNumber, values.BankId, values.BranchId, values.CurrencyId, values.Description ?? string.Empty);
                account.ModifiedBy = values.ModifiedBy;
                account.ModifiedOn = DateTime.Now;

                _unitOfWork.BankAccountNumbers.Update(account);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Bank account number updated successfully." }
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

        public async Task<ReturnResponsesDto> DeleteBankAccountNumbersAsync(int bankAccountNumbersId)
        {
            try
            {
                var account = await _unitOfWork.BankAccountNumbers.Get(a => a.BankAccountNumbersId == bankAccountNumbersId);
                if (account == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = "Bank account number not found." },
                        SuccessResponse = null
                    };
                }

                _unitOfWork.BankAccountNumbers.Delete(account);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Bank account number deleted successfully." }
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

        public async Task<IEnumerable<BankAccountNumbersReadDto>> GetBankAccountNumbersByCriteriaAsync(string? searchTerm = null)
        {
            Expression<Func<BankAccountNumbers, bool>> predicate = a => true;

            if (!string.IsNullOrWhiteSpace(searchTerm))
                predicate = predicate.And(a => a.BankId!.Contains(searchTerm));

            if (!string.IsNullOrWhiteSpace(searchTerm))
                predicate = predicate.And(a => a.BranchId!.Contains(searchTerm));

            if (!string.IsNullOrWhiteSpace(searchTerm))
                predicate = predicate.And(a => a.CurrencyId == Convert.ToInt32(searchTerm));

            var accounts = await _unitOfWork.BankAccountNumbers.GetAll(predicate, includes: new List<string> { "Bank", "Branch", "Currency" });

            return accounts.Select(account => new BankAccountNumbersReadDto(
                account.BankAccountNumbersId,
                account.AccountNumber!,
                account.BankId!,
                account.Bank?.BankName ?? string.Empty,
                account.BranchId!,
                account.Branch?.BranchName ?? string.Empty,
                account.CurrencyId,
                account.Currency?.CurrencyName ?? string.Empty,
                account.Description!
            ));
        }

    }


    //Extension method for predicate building
    public static class ExpressionExtensions
    {
        public static Expression<Func<T, bool>> And<T>(this Expression<Func<T, bool>> expr1, Expression<Func<T, bool>> expr2)
        {
            var parameter = Expression.Parameter(typeof(T));
            var body = Expression.AndAlso(
                Expression.Invoke(expr1, parameter),
                Expression.Invoke(expr2, parameter));
            return Expression.Lambda<Func<T, bool>>(body, parameter);
        }
    }
}

