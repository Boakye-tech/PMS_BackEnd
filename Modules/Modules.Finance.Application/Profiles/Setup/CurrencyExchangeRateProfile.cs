// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Domain
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Domain/Entities/Setup/CurrencyExchangeRateProfile.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Finance.Application.Profiles.Setup
{
	public class CurrencyExchangeRateProfile : Profile
	{
		public CurrencyExchangeRateProfile()
		{
            CreateMap<CurrencyExchangeRate, CurrencyExchangeRateReadDto>();
            CreateMap<CurrencyExchangeRateCreateDto, CurrencyExchangeRate>();
            CreateMap<CurrencyExchangeRateUpdateDto, CurrencyExchangeRate>();
            CreateMap<CurrencyExchangeRateDeleteDto, CurrencyExchangeRate>();

        }
    }
}

