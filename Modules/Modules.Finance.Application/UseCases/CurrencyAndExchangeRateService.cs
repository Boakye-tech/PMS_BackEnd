using System;

namespace Modules.Finance.Application.UseCases
{
	public class CurrencyAndExchangeRateService : ICurrencyAndExchangeRateService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CurrencyAndExchangeRateService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<CurrencyAndExchangeRateReadDto> AddCurrencyAndExchangeRateAsync(CurrencyAndExchangeRateCreateDto values)
        {
            CurrencyAndExchangeRate currency = new(values.CurrencyId, values.CurrencyInitial, values.CurrencyName, values.BuyingRate, values.SellingRate, values.BaseCurrency, values.ApplicableDate, values.IsCurrent)
            {
                CreatedBy = values.CreatedBy,
                CreatedOn = DateTime.Now
            };

            _unitOfWork.CurrencyAndExchangeRate.Insert(currency);
            await _unitOfWork.Complete();

            return new CurrencyAndExchangeRateReadDto(currency.CurrencyId, currency.CurrencyInitial, currency.CurrencyName, currency.BuyingRate, currency.SellingRate, currency.BaseCurrency, currency.ApplicableDate, currency.IsCurrent);
        }

        public async Task<IEnumerable<CurrencyAndExchangeRateReadDto>> GetCurrencyAndExchangeRateAsync()
        {
            var currencies = await _unitOfWork.CurrencyAndExchangeRate.GetAll();
            return _mapper.Map<IEnumerable<CurrencyAndExchangeRateReadDto>>(currencies);
        }

        public Task<CurrencyAndExchangeRateReadDto> GetCurrencyAndExchangeRateAsync(int value)
        {
            throw new NotImplementedException();
        }

        public Task<CurrencyAndExchangeRateReadDto> GetCurrencyAndExchangeRateAsync(string value)
        {
            throw new NotImplementedException();
        }

        public Task<CurrencyAndExchangeRateReadDto> UpdateCurrencyAndExchangeRateAsync(CurrencyAndExchangeRateUpdateDto values)
        {
            throw new NotImplementedException();
        }
    }
}

