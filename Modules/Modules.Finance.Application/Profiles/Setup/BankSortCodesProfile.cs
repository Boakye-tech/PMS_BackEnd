using System;
namespace Modules.Finance.Application.Profiles.Setup
{
	public class BankSortCodesProfile : Profile
	{
		public BankSortCodesProfile()
		{
            CreateMap<BankSortCodes, BankSortCodesReadDto>();
            CreateMap<BankSortCodesCreateDto, BankSortCodes>();
            CreateMap<BankSortCodesUpdateDto, BankSortCodes>();
            CreateMap<BankSortCodesDeleteDto, BankSortCodes>();

        }
    }
}

