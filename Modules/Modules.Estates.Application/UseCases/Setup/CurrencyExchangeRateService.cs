// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/UseCases/Setup/CurrencyExchangeRateService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 19/05/2025 4:57 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Microsoft.AspNetCore.Http;
using Modules.Estates.Domain.Entities.Setup;

namespace Modules.Estates.Application.UseCases.Setup
{
	public class CurrencyExchangeRateService : ICurrencyExchangeRateService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CurrencyExchangeRateService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CurrencyExchangeRateReadDto>> GetCurrencyExchangeRateAsync()
        {
            var currencies = await _unitOfWork.CurrencyExchangeRate.GetAll();
            return _mapper.Map<IEnumerable<CurrencyExchangeRateReadDto>>(currencies);
        }

        public async Task<CurrencyExchangeRateReadDto> GetCurrencyExchangeRateAsync(int value)
        {
            var currency = await _unitOfWork.CurrencyExchangeRate.Get(value);
            return _mapper.Map<CurrencyExchangeRateReadDto>(currency);
        }

        public async Task<CurrencyExchangeRateReadDto> GetCurrencyExchangeRateAsync(string value)
        {
            var currency = await _unitOfWork.CurrencyExchangeRate.Get(c => c.CurrencyInitial == value || c.CurrencyName == value);
            return _mapper.Map<CurrencyExchangeRateReadDto>(currency);
        }

        public async Task<ReturnResponsesDto> CreateCurrencyExchangeRateAsync(CurrencyExchangeRateCreateDto values)
        {
            try
            {
                int currencyId = 0;

                var existingCurrency = await _unitOfWork.CurrencyExchangeRate.Get(c => c.CurrencyInitial == values.CurrencyInitial);
                if (existingCurrency != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Currency Initial already exists." },
                        SuccessResponse = null
                    };
                }

                existingCurrency = await _unitOfWork.CurrencyExchangeRate.Get(c => c.CurrencyName == values.CurrencyName);
                if (existingCurrency != null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status400BadRequest, Message = "Currency Name already exists." },
                        SuccessResponse = null
                    };
                }

                var currency = CurrencyExchangeRate.CreateCurrencyExchangeRate(
                    currencyId,
                    values.CurrencyInitial!,
                    values.CurrencyName!,
                    values.BuyingRate,
                    values.SellingRate,
                    values.BaseCurrency,
                    values.ApplicableDate
                );

                currency.CreatedBy = values.CreatedBy;
                currency.CreatedOn = DateTime.Now;

                _unitOfWork.CurrencyExchangeRate.Insert(currency);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Currency exchange rate created successfully." }
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

        public async Task<ReturnResponsesDto> UpdateCurrencyExchangeRateAsync(CurrencyExchangeRateUpdateDto values)
        {
            try
            {
                var currency = await _unitOfWork.CurrencyExchangeRate.Get(values.CurrencyId);
                if (currency == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Currency with ID {values.CurrencyId} not found." },
                        SuccessResponse = null
                    };
                }

                currency.UpdateCurrencyExchangeRate(
                    values.CurrencyId,
                    values.CurrencyInitial!,
                    values.CurrencyName!,
                    values.BaseCurrency,
                    values.BuyingRate,
                    values.SellingRate,
                    values.ApplicableDate
                );

                currency.ModifiedBy = values.ModifiedBy;
                currency.ModifiedOn = DateTime.Now;

                _unitOfWork.CurrencyExchangeRate.Update(currency);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Currency exchange rates updated successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException?.Message ?? ex.Message },
                    SuccessResponse = null
                };
            }
        }

        public async Task<ReturnResponsesDto> DeleteCurrencyExchangeRateAsync(int currencyId)
        {
            try
            {
                var currency = await _unitOfWork.CurrencyExchangeRate.Get(currencyId);
                if (currency == null)
                {
                    return new ReturnResponsesDto
                    {
                        IsSuccess = false,
                        ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status404NotFound, Message = $"Currency with ID {currencyId} not found." },
                        SuccessResponse = null
                    };
                }

                _unitOfWork.CurrencyExchangeRate.Delete(currency);
                await _unitOfWork.Complete();

                return new ReturnResponsesDto
                {
                    IsSuccess = true,
                    ErrorResponse = null,
                    SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = $"Currency with ID {currencyId} deleted successfully." }
                };
            }
            catch (Exception ex)
            {
                return new ReturnResponsesDto
                {
                    IsSuccess = false,
                    ErrorResponse = new ErrorResponseDto { Code = StatusCodes.Status500InternalServerError, Message = ex.InnerException?.Message ?? ex.Message },
                    SuccessResponse = null
                };
            }
        }
    }
}

