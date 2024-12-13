using System;
namespace Modules.Finance.Application.Profiles.Setup
{
	public class BankProfile : Profile
	{
		public BankProfile()
		{
            CreateMap<Bank, BankReadDto>();
            CreateMap<BankCreateDto, Bank>();
            CreateMap<BankUpdateDto, Bank>();
            CreateMap<BankDeleteDto, Bank>();

        }
    }
}

