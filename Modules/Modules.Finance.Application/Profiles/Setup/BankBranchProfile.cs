using System;
namespace Modules.Finance.Application.Profiles.Setup
{
	public class BankBranchProfile : Profile
	{
		public BankBranchProfile()
		{
            CreateMap<BankBranch, BankBranchReadDto>();
            CreateMap<PaymentTypeCreateDto, BankBranch>();
            CreateMap<PaymentTypeUpdateDto, BankBranch>();
            CreateMap<PaymentTypeDeleteDto, BankBranch>();

        }
    }
}

