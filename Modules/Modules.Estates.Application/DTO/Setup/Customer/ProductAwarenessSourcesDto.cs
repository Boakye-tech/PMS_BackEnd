// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 20/09/2025 5:40 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/

namespace Modules.Estates.Application.DTO.Setup.Customer;

public record ProductAwarenessSourcesReadDto(int productAwarenessSourcesId, string productAwarenessSource);

public record ProductAwarenessSourcesUpdateDto(int productAwarenessSourcesId, string productAwarenessSource, string modifiedBy);
public record ProductAwarenessSourcesDeleteDto(int productAwarenessSourcesId);

public record ProductAwarenessSourcesCreateDto(int productAwarenessSourcesId, string productAwarenessSource, string createdBy);

