// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Finance.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Finance.Application/Dtos/Setup/PenaltyRuleDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 22/09/2025 3:06 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;


namespace Modules.Finance.Application.Dtos.Setup
{
    //public record PenaltyRuleReadDto(
    //    int PenaltyRuleId,
    //    int PenaltyTypeId,
    //    string PenaltyTypeName,
    //    PenaltyCalculationMethod CalculationMethod,
    //    decimal Rate,
    //    int GracePeriodDays,
    //    decimal? CapAmount,
    //    DateTime EffectiveDate,
    //    DateTime? ExpiryDate,
    //    bool IsActive
    //    );

    public record PenaltyRuleReadDto(
    int PenaltyRuleId,
    int PenaltyTypeId,
    string PenaltyTypeName,
    PenaltyCalculationMethod CalculationMethod,
    decimal Rate,
    int GracePeriodDays,
    decimal? CapAmount,
    DateTime EffectiveDate,
    DateTime? ExpiryDate,
    bool IsActive,
    string CalculationMethodDescription);


    public record PenaltyRuleCreateDto(
        int PenaltyTypeId,
        PenaltyCalculationMethod CalculationMethod,
        decimal Rate,
        int GracePeriodDays,
        decimal? CapAmount,
        DateTime EffectiveDate,
        DateTime? ExpiryDate,
        string CreatedBy);

    public record PenaltyRuleUpdateDto(
        int PenaltyRuleId,
        PenaltyCalculationMethod CalculationMethod,
        decimal Rate,
        int GracePeriodDays,
        decimal? CapAmount,
        DateTime EffectiveDate,
        DateTime? ExpiryDate,
        string ModifiedBy);

    public record PenaltyRuleDeleteDto(int PenaltyRuleId);




}

