using System;
namespace Modules.Finance.Application.Profiles.Setup
{
	public class ChartOfAccountsProfile : Profile
	{
		public ChartOfAccountsProfile()
		{
            CreateMap<ChartOfAccounts, ChartOfAccountsReadDto>();
            CreateMap<ChartOfAccountsCreateDto, ChartOfAccounts>();
            CreateMap<ChartOfAccountsUpdateDto, ChartOfAccounts>();
            CreateMap<ChartOfAccountsDeleteDto, ChartOfAccounts>();

        }
    }
}

