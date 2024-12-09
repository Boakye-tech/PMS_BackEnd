namespace Modules.Estates.Application.Profiles.Customer;

public class CustomerTypeProfile : Profile
{
	public CustomerTypeProfile()
	{
        CreateMap<CustomerType, CustomerTypeReadDto>();
        CreateMap<CustomerTypeCreateDto, CustomerType>();
        CreateMap<CustomerTypeUpdateDto, CustomerType>();
        CreateMap<CustomerTypeDeleteDto, CustomerType>();
    }
}

