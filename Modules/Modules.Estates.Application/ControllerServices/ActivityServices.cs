// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/ControllerServices/ActivityServices.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 20/05/2025 12:34 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/



namespace Modules.Estates.Application.ControllerServices;

public class ActivityServices : IActivityServices
{
    public IActivityService ActivityService { get; }
    public IActivityTypeService ActivityTypeService { get; }

    //public IActivityAndActivityTypeService ActivityAndActivityTypeService { get; }

    public IPropertyStatusService PropertyStatusService { get; }

    public ICurrencyExchangeRateService CurrencyExchangeRateService { get; }
    public ILeaseTypeAndPeriodService LeaseTypeAndPeriodService { get; }


    public ActivityServices(IActivityService activityService,IActivityTypeService activityTypeService,IPropertyStatusService propertyStatusService,
                            ICurrencyExchangeRateService currencyExchangeRateService, ILeaseTypeAndPeriodService leaseTypeAndPeriodService) // IActivityAndActivityTypeService activityAndActivityTypeService, 
    {
        ActivityService = activityService;
        ActivityTypeService = activityTypeService;
        //ActivityAndActivityTypeService = activityAndActivityTypeService;
        PropertyStatusService = propertyStatusService;

        CurrencyExchangeRateService = currencyExchangeRateService;
        LeaseTypeAndPeriodService = leaseTypeAndPeriodService;
    }

    public async Task<IEnumerable<ActivityReadDto>> GetActivitiesAsync() =>
        await ActivityService.GetActivitiesAsync();

    public async Task<ReturnResponsesDto> CreateActivityAsync(ActivityCreateDto values) =>
        await ActivityService.CreateActivityAsync(values);

    public async Task<ReturnResponsesDto> UpdateActivityAsync(ActivityUpdateDto values) =>
        await ActivityService.UpdateActivityAsync(values);

    public async Task<ReturnResponsesDto> DeleteActivity(int activityId) =>
        await ActivityService.DeleteActivity(activityId);

    // Activity type methods
    public async Task<IEnumerable<ActivityTypeReadDto>> GetActivityTypeAsync() =>
        await ActivityTypeService.GetActivityTypeAsync();

    public async Task<ReturnResponsesDto> CreateActivityTypeAsync(ActivityTypeCreateDto values) =>
        await ActivityTypeService.CreateActivityTypeAsync(values);

    public async Task<ReturnResponsesDto> UpdateActivityTypeAsync(ActivityTypeUpdateDto values) =>
        await ActivityTypeService.UpdateActivityTypeAsync(values);

    public async Task<ReturnResponsesDto> DeleteActivityType(int activityTypeId) =>
        await ActivityTypeService.DeleteActivityType(activityTypeId);


    public async Task<List<ActivityAndActivityTypeReadDto>> GetActivityAndActivityTypeAsync() =>
        await ActivityService.GeActivityAndActivityTypeAsync();

    // Property Status methods
    public async Task<IEnumerable<PropertyStatusReadDto>> GetPropertyStatusAsync() =>
        await PropertyStatusService.GetPropertyStatusAsync();
    public async Task<ReturnResponsesDto> CreatePropertyStatusAsync(PropertyStatusCreateDto values) =>
        await PropertyStatusService.CreatePropertyStatusAsync(values);
    public async Task<ReturnResponsesDto> UpdatePropertyStatusAsync(PropertyStatusUpdateDto values) =>
        await PropertyStatusService.UpdatePropertyStatusAsync(values);
    public async Task<ReturnResponsesDto> DeletePropertyStatus(int propertyStatusId) =>
        await PropertyStatusService.DeletePropertyStatus(propertyStatusId);

    //Currency methods
    public async Task<IEnumerable<CurrencyExchangeRateReadDto>> GetCurrencyExchangeRateAsync() =>
       await CurrencyExchangeRateService.GetCurrencyExchangeRateAsync();

    public async Task<ReturnResponsesDto> CreateCurrencyExchangeRateAsync(CurrencyExchangeRateCreateDto values) =>
        await CurrencyExchangeRateService.CreateCurrencyExchangeRateAsync(values);

    public async Task<ReturnResponsesDto> UpdateCurrencyExchangeRateAsync(CurrencyExchangeRateUpdateDto values) =>
        await CurrencyExchangeRateService.UpdateCurrencyExchangeRateAsync(values);

    public async Task<ReturnResponsesDto> DeleteCurrencyExchangeRateAsync(int currencyId) =>
        await CurrencyExchangeRateService.DeleteCurrencyExchangeRateAsync(currencyId);

    // Lease Types and Periods methods
    public async Task<IEnumerable<LeaseTypeAndPeriodReadDto>> GetLeaseTypeAndPeriodAsync() =>
        await LeaseTypeAndPeriodService.GetLeaseTypeAndPeriodAsync();

    public async Task<ReturnResponsesDto> CreateLeaseTypeAndPeriodAsync(LeaseTypeAndPeriodCreateDto values) =>
        await LeaseTypeAndPeriodService.CreateLeaseTypeAndPeriodAsync(values);

    public async Task<ReturnResponsesDto> UpdateLeaseTypeAndPeriodAsync(LeaseTypeAndPeriodUpdateDto values) =>
        await LeaseTypeAndPeriodService.UpdateLeaseTypeAndPeriodAsync(values);

    public async Task<ReturnResponsesDto> DeleteLeaseTypeAndPeriod(int leaseTypeAndPeriodId) =>
        await LeaseTypeAndPeriodService.DeleteLeaseTypeAndPeriod(leaseTypeAndPeriodId);

}