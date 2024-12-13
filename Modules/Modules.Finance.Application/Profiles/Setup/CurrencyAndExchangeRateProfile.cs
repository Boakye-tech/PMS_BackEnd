using System;
namespace Modules.Finance.Application.Profiles.Setup
{
	public class CurrencyAndExchangeRateProfile : Profile
	{
		public CurrencyAndExchangeRateProfile()
		{
            CreateMap<CurrencyAndExchangeRate, CurrencyAndExchangeRateReadDto>();
            CreateMap<CurrencyAndExchangeRateCreateDto, CurrencyAndExchangeRate>();
            CreateMap<CurrencyAndExchangeRateUpdateDto, CurrencyAndExchangeRate>();
            CreateMap<CurrencyAndExchangeRateDeleteDto, CurrencyAndExchangeRate>();

        }
    }
}

