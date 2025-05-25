// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Interfaces/ModuleServices/IModuleCommunicationServices.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 20/05/2025 6:10 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Finance.Application.Interfaces.ModuleServices
{
	public interface IModuleCommunicationServices
	{
        Task<bool> SendCurrencyDetailsAsync(CurrencyExchangeRateCreateDto payload);
        Task<bool> SendModifiedCurrencyDetailsAsync(CurrencyUpdateDto payload);

    }
}

