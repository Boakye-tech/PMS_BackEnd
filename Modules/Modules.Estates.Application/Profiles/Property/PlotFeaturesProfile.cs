// /**************************************************
// * Company: MindSprings Company Limited
// * Project Name: Modules.Estates.Application
// * Full FileName: /Users/imac5k/Projects/PropertyManagementSolution/pms-api/Modules/Modules.Estates.Application/Profiles/Property/PlotFeaturesProfile.cs
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 30/06/2025 1:34 PM
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/
using System;
namespace Modules.Estates.Application.Profiles.Property
{
	public class PlotFeaturesProfile : Profile
    {
		public PlotFeaturesProfile()
		{
            CreateMap<PlotFeatures, PlotFeaturesReadDto>();

            CreateMap<PlotFeaturesCreateDto, PlotFeatures>();
            CreateMap<PlotFeaturesUpdateDto, PlotFeatures>();
            CreateMap<PlotFeaturesDeleteDto, PlotFeatures>();

        }
    }
}

