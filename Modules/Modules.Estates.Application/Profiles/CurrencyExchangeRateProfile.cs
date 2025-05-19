// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/CurrencyExchangeRateProfile.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 19/05/2025 4:53 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
using Modules.Estates.Domain.Entities.Setup;

namespace Modules.Estates.Application.Profiles
{
	public class CurrencyExchangeRateProfile : Profile
	{
		public CurrencyExchangeRateProfile()
		{
			CreateMap<CurrencyExchangeRate, CurrencyExchangeRateReadDto >();
            CreateMap<CurrencyExchangeRateCreateDto, CurrencyExchangeRate>();
            CreateMap<CurrencyExchangeRateUpdateDto, CurrencyExchangeRate>();
            CreateMap<CurrencyExchangeRateDeleteDto, CurrencyExchangeRate>();


        }
    }
}

