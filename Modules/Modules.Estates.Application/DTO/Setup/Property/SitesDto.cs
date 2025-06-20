// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/DTO/Setup/Property/SitesDto.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 04/06/2025 9:32 AM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


namespace Modules.Estates.Application.DTO.Setup.Property;

public record SitesReadDto(int LocalityId, int SitesId, string SiteName);
public record SitesCreateDto(int LocalityId, string SiteName, string CreatedBy);
public record SitesUpdateDto(int LocalityId, int SiteId, string SiteName, string ModifiedBy);
public record SitesDeleteDto(int SiteId);

public record LocalityReadsDto(int LocalityId, string LocalityInitial, string LocalityName, string CustomerCode, int CustomerCodeCounter, bool IsOpen);
public record LocalityAndSitesReadDto(LocalityReadsDto Locality, List<SitesReadDto> Sites);

