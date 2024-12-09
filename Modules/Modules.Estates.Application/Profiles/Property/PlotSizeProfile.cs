using System;
using Modules.Estates.Application.DTO.Setup.Property;

namespace Modules.Estates.Application.Profiles.Property;

public class PlotSizeProfile : Profile
{
	public PlotSizeProfile()
	{
        CreateMap<PlotSize, PlotSizeReadDto>();

        CreateMap<PlotSizeCreateDto, PlotSize>();
        CreateMap<PlotSizeUpdateDto, PlotSize>();
        //CreateMap<PlotSizeDeleteDto, PlotSize>();
    }
}

