// /**************************************************
// * Company: MindSprings Company Limited
// * Author: Boakye Ofori-Atta
// * Email Address: boakye.ofori-atta@mindsprings-gh.com
// * Copyright: © 2024 MindSprings Company Limited
// * Create Date: 01/03/2025 
// * Version: 1.0.1
// * Description: Property Management System
//  **************************************************/


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

