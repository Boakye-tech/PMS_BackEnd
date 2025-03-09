namespace Modules.Estates.Application.Profiles.Property;

public class FloorNumberingProfile : Profile
{
	public FloorNumberingProfile()
	{
		CreateMap<FloorNumbering, FloorNumberingReadDto>();

		CreateMap<FloorNumberingCreateDto, FloorNumbering>();
        CreateMap<FloorNumberingUpdateDto, FloorNumbering>();
        CreateMap<FloorNumberingDeleteDto, FloorNumbering>();

    }
}

