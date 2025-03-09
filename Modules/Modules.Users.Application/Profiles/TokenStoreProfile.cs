using System;
namespace Modules.Users.Application.Profiles
{
	public class TokenStoreProfile : Profile
    {
		public TokenStoreProfile()
		{
            CreateMap<TokenStore, TokenStoreReadDto>();
            CreateMap<TokenStoreCreateDto, TokenStore>();
            //CreateMap<>();
            //CreateMap<>();

        }
    }
}

