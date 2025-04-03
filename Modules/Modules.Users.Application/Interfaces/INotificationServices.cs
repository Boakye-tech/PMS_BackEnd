using System;
namespace Modules.Users.Application.Interfaces
{
	public interface INotificationServices
    {
        //Task SendTokenViaNotification(ApplicationIdentityUser user, string temp_password);

        Task<bool> SendTemporaryPasswordEmailNotification(ApplicationIdentityUser user, string temp_password);

    }
}

