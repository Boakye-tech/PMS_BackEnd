using System;
namespace Modules.Common.Infrastructure.Authentication
{
	public interface IUserContextService
	{
        string? GetUserId();
    }
}

