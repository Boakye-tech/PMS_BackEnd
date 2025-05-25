// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/UseCases/CurrencyExchangeRateService.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

using Microsoft.AspNetCore.Http;

namespace Modules.Finance.Application.UseCases;

public class CurrencyExchangeRateService : ICurrencyExchangeRateService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;
    private readonly IModuleCommunicationServices _moduleCommunication;

    public CurrencyExchangeRateService(IUnitOfWork unitOfWork, IMapper mapper, IModuleCommunicationServices moduleCommunication)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
        _moduleCommunication = moduleCommunication;
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

            var currency = CurrencyExchangeRate.Create(
                values.CurrencyId,
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

            //send to estates module
            var response = await _moduleCommunication.SendCurrencyDetailsAsync(values);
            if (!response)
            {
                //_logger.LogWarning($"Failed to send customer details to online customer module {customer_payload.CustomerCode}", customer_payload.CustomerCode);
            }

            var result = _mapper.Map<CurrencyExchangeRateReadDto>(currency);

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status201Created, Message = "Currency exchange rate created successfully.", Data = result }
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

            currency.UpdateExchangeRate(
                values.CurrencyId,
                values.BuyingRate,
                values.SellingRate,
                values.ApplicableDate
            );

            currency.ModifiedBy = values.ModifiedBy;
            currency.ModifiedOn = DateTime.Now;

            _unitOfWork.CurrencyExchangeRate.Update(currency);
            await _unitOfWork.Complete();

            var result = _mapper.Map<CurrencyExchangeRateReadDto>(currency);

            //send to estates module
            var payload = new CurrencyUpdateDto(currency.CurrencyId, currency.CurrencyInitial!, currency.CurrencyName!, currency.BaseCurrency, currency.BuyingRate, currency.SellingRate, currency.ApplicableDate, currency.ModifiedBy);
            var response = await _moduleCommunication.SendModifiedCurrencyDetailsAsync(payload);
            if (!response)
            {
                //_logger.LogWarning($"Failed to send customer details to online customer module {customer_payload.CustomerCode}", customer_payload.CustomerCode);
            }


            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Currency exchange rates updated successfully.", Data = result }
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

    public async Task<ReturnResponsesDto> UpdateCurrencyDetailsAsync(CurrencyDetailsUpdateDto values)
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

            currency.UpdateCurrencyDetails(
                values.CurrencyId,
                values.CurrencyInitial!,
                values.CurrencyName!,
                values.BaseCurrency
            );

            currency.ModifiedBy = values.ModifiedBy;
            currency.ModifiedOn = DateTime.Now;

            _unitOfWork.CurrencyExchangeRate.Update(currency);
            await _unitOfWork.Complete();

            var result = _mapper.Map<CurrencyExchangeRateReadDto>(currency);

            return new ReturnResponsesDto
            {
                IsSuccess = true,
                ErrorResponse = null,
                SuccessResponse = new SuccessResponseDto { Code = StatusCodes.Status200OK, Message = "Currency details updated successfully.", Data = result }
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

