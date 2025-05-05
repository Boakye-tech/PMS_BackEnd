// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/01/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/



namespace Modules.Estates.Application.Profiles.Management
{
	public class PropertyMasterProfile : Profile
	{
		public PropertyMasterProfile()
		{
            CreateMap<PropertyMaster, PropertyMasterCreatePlotResponseDto>();
            CreateMap<PropertyMasterCreatePlotDto, PropertyMaster>();


            CreateMap<PropertyMasterUpdateDto, PropertyMaster>();
            CreateMap<PropertyMasterUpdateLeaseDetailsDto, PropertyMaster>();

        }
    }
}

