using System;
namespace Modules.Estates.Domain.Interfaces.DomainServices
{
	public interface ICustomerDomainService
	{
        Task<bool> LocalityExists(int localityId);
        Task<bool> CustomerTypeExists(int customerTypeId);
        Task<bool> ResidentTypeExists(int residentTypeId);
        Task<bool> TitleExists(int titleId);
        Task<bool> GenderExists(int genderId);
        Task<bool> NationalityExists(int nationalityId);
        Task<bool> SocialMediaExists(int socialMediaTypeId);
        Task<bool> IdentificationTypeExists(int identificationTypeId);

        Task<Locality> GetLocalityDetails(int localityId);
    }
}

