using System;
namespace Modules.Users.Application.Dtos.UserAccounts
{
    public abstract record UserInformationDto
    {
        public string? UserId { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? UserName { get; set; }
        public string? EmailAddress { get; set; }
        public string? Channel { get; set; }
        public string? UserType { get; set; }
        public bool IsFirstTime { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string? Status { get; set; }


    };

    public record userRole(string role);

    public record CustomerUserInformationDto : UserInformationDto
    {
        public string? CustomerCode { get; set; }
        public string? LastReceiptNumber { get; set; }
        public string? LastReceiptImage { get; set; }
        public string? IdentificationType { get; set; }
        public string? IdentificationUniqueNumber { get; set; }
        public string? IdentificationImage { get; set; }
        public string? IdentificationImageOne { get; set; }
        public string? SelfieImage { get; set; }
        public string? PassportPicture { get; set; }

        public CustomerUserInformationDto(ApplicationIdentityUser user, string identificationType, string channelName, string userType, string status)
        {
            UserId = user.Id;
            CustomerCode = user.IdentificationNumber;
            FirstName = user.FirstName;
            MiddleName = user.MiddleName;
            LastName = user.LastName;
            PhoneNumber = user.PhoneNumber;
            EmailAddress = user.Email;
            UserName = user.UserName;
            LastReceiptNumber = user.LastReceiptNumber;
            LastReceiptImage = user.LastReceiptImage;
            IdentificationType = identificationType;
            IdentificationUniqueNumber = user.IdentificationUniqueNumber;
            IdentificationImage = user.IdentificationImage;
            IdentificationImageOne = user.IdentificationImageOne;
            SelfieImage = user.SelfieImage;
            PassportPicture = user.PassportPicture;
            Channel = channelName;
            UserType = userType;
            IsFirstTime = user.IsFirstTime;
            RegistrationDate = user.RegistrationDate;
            Status = status;
        }
       
    }


    public record StaffUserInformationDto : UserInformationDto
    { 
        public string? StaffIdentificationNumber { get; set; }
        public string? Department { get; set; }
        public string? Unit { get; set; }
        public string? ProfilePicture { get; set; }
        public IList<string>? UsersRoles { get; set; }
        public PermissionsAccessModulesReadDto? AccessPermissions { get; set; }

        public StaffUserInformationDto(ApplicationIdentityUser user, string department, string unit, string channelName, string userType, string status, IList<string>? usersRoles, PermissionsAccessModulesReadDto? accessPermissions)
        {
            UserId = user.Id;
            StaffIdentificationNumber = user.IdentificationNumber;
            Department = department;
            Unit = unit;
            FirstName = user.FirstName;
            MiddleName = user.MiddleName;
            LastName = user.LastName;
            PhoneNumber = user.PhoneNumber;
            EmailAddress = user.Email;
            UserName = user.UserName;
            ProfilePicture = user.ProfilePicture;
            Channel = channelName;
            UserType = userType;
            IsFirstTime = user.IsFirstTime;
            RegistrationDate = user.RegistrationDate;
            Status = status;
            UsersRoles = usersRoles;
            AccessPermissions = accessPermissions;

        }

    };

   

}

